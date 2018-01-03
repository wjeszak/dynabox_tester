using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Dynabox_tester
{
    public partial class MainWindow : Form
    {
        // C++ style "function pointer"
        delegate void SetTextCallback(byte[] f);
        int desired_data = 4;
        //int desired_data = 6;
        int received_data = 0;
        int position = 0;
        byte[] rxbytearray = new byte[4];
        //byte[] rxbytearray = new byte[6];
        enum PortStatus { Connected, Disconnected, Busy };
        int queries = 0;
        int curr_address = 1;
        Led led = new Led();

        public MainWindow()
        {
            InitializeComponent();
            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);

            foreach (string s in SerialPort.GetPortNames())
            {
                ports.Items.Add(s);
            }
            if (ports.Items.Count != 0)
            {
                button_connection.Enabled = true;
                ports.SelectedIndex = 0;
                baudrate.SelectedIndex = 0;
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            //delay_between_frames.Value = led.delay;
        }

        private void PortStatusInfo(PortStatus status)
        {
            if (status == PortStatus.Connected)
            {
                button_connection.Text = "Disconnect";
                statusBar_connection_status.Text = "Connected / " + baudrate.SelectedItem.ToString() + " bps";
                tabControl1.Enabled = true;
                groupBox_preview.Enabled = true;
                groupBox_send.Enabled = true;
                groupBox_statistics.Enabled = true;
            }
            if(status == PortStatus.Disconnected)
            {
                button_connection.Text = "Connect";
                statusBar_connection_status.Text = "Disconected";
                tabControl1.Enabled = false;
                groupBox_preview.Enabled = false;
                groupBox_send.Enabled = false;
                groupBox_statistics.Enabled = false;
            }
            if (status == PortStatus.Busy)
            {
                button_connection.Text = "Connect";
                statusBar_connection_status.Text = "Busy";
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int numbytes = serial.BytesToRead;
            
            received_data += numbytes;
            if (received_data <= desired_data)
            {
                for (int i = position; i < received_data; i++)
                {
                    rxbytearray[i] = (byte)serial.ReadByte();
                }
                position += numbytes;
            }
  
            if(received_data == desired_data)
            {
                received_data = 0;
                position = 0;
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { rxbytearray }); 
            }
        }
        
        private void SetText(byte[] f)
        {
            preview.SelectionColor = System.Drawing.Color.Red;
            preview.AppendText(f[0].ToString("X2") + ' ' + f[1].ToString("X2") + ' ' + f[2].ToString("X2") + '\n');
            preview.ScrollToCaret();
            if (radioButton1.Checked == true)
            {
                if (f[1] == 0x01) { electromagnet_status.ForeColor = Color.Red; electromagnet_status.Text = "FAILED"; }
                if (f[1] == 0x00) { electromagnet_status.ForeColor = Color.Green; electromagnet_status.Text = "OK"; }
            }
            if (radioButton2.Checked == true)
            {
                if (f[1] == 0xF0) { door_status.ForeColor = Color.Red; door_status.Text = "FAILED"; }
                else 
                { 
                    door_status.ForeColor = Color.Green;
                    trans_val.Text = f[1].ToString("X2");
                    sub_pos.Text = f[2].ToString("X2");
                    door_status.Text = f[3].ToString("X2");
                }
            }
        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            if (ports.SelectedItem == null) return;
            if (serial.IsOpen == false)
            {
                serial.PortName = ports.SelectedItem.ToString();
                serial.BaudRate = int.Parse(baudrate.SelectedItem.ToString());
                try
                {
                    serial.Open();
                }
                catch (Exception ex)
                {
                    statusBar_connection_status.Text = ex.Message;
                    //PortStatusInfo(PortStatus.Busy);
                }

                if(serial.IsOpen == true) PortStatusInfo(PortStatus.Connected);
            }
            else
            {
                serial.Close();
                PortStatusInfo(PortStatus.Disconnected);
            }
        }

        private byte GetDoorCommand()
        {
            if (radioButton1.Checked) return 1;
            if (radioButton2.Checked)
            {
                byte stat = 0;
                if (set_pos.Checked)
                {
                    stat = (1 << 7) | (1 << 6);
                    stat += (byte)(state_door.Value);
                    return stat;
                }
                else
                    return (1 << 7);
            }
            return 1;
        }

        private void button_send_single_Click(object sender, EventArgs e)
        {
            byte[] frame = new byte[4];
            frame[0] = (byte)single_address.Value;
            frame[1] = GetDoorCommand();
            frame[2] = CRC8(frame, 2);
            frame[3] = 0x0A;
            SendToPort(frame);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int start_addr = (int)start_address.Value;
            int stop_addr = (int)stop_address.Value;
            
            byte[] frame = new byte[4];
            frame[0] = (byte)curr_address;
            frame[1] = GetDoorCommand();
            frame[2] = CRC8(frame, 2);
            frame[3] = 0x0A;
            SendToPort(frame);

            if (curr_address == stop_addr)
            {
                curr_address = start_addr;
                return;
            }
            curr_address++;
            label_queries.Text = queries.ToString();
        }

        private void button_send_polling_Click(object sender, EventArgs e)
        {
            if (start_address.Value > stop_address.Value)
                MessageBox.Show("Address start > address stop!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (timer.Enabled == false)
                {
                    curr_address = (int)start_address.Value;
                    timer.Interval = Int32.Parse(interval.Text);
                    timer.Enabled = true;
                    button_send_polling.Text = "Stop polling";
                }
                else
                {
                    timer.Enabled = false;
                    button_send_polling.Text = "Start polling";
                }
            }
        }

        private void SendToPort(byte[] f)
        {
            serial.Write(f, 0, f.Length);
            preview.SelectionColor = Color.Blue;
            string f_preview = f[0].ToString("X2") + ' ' + f[1].ToString("X2") + ' ' + f[2].ToString("X2") + "\n";
            preview.AppendText(f_preview);
            preview.ScrollToCaret();
            queries++;
            label_queries.Text = queries.ToString();
        }

        private byte CRC8(byte[] frame, byte len)
        {
            byte crc = 0x00;
            byte pos = 0;
            for (pos = 0; pos < len; pos++)
            {
                crc ^= frame[pos];
                byte i = 0;
                for (i = 8; i != 0; i--)
                {
                    if ((crc & 0x80) != 0)
                    {
                        crc <<= 1;
                        crc ^= 0x07;
                    }
                    else
                        crc <<= 1;
                }
            }
            return crc;
        }

        private void interval_TextChanged(object sender, EventArgs e)
        {
            timer.Interval = Int32.Parse(interval.Text);
        }
     
        private void leds_quantity_ValueChanged(object sender, EventArgs e)
        {
            if (delay_between_frames.Value < 10)
            {
                delay_between_frames.Value = 10;
                MessageBox.Show("Minimum delay between frames = 10 ms", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            
            }
        }

        private void button_send_led_Click(object sender, EventArgs e)
        {
            if (checkBox_led_off.Checked == true)
            {
                for (byte i = 0; i < led_quantity.Value; i++)
                {
                    led.command[i] = 0x00;
                }
            }
            else
            {
                led.command[0] = (byte)(comboBox1.SelectedIndex);
                led.command[1] = (byte)(comboBox2.SelectedIndex);
                led.command[2] = (byte)(comboBox3.SelectedIndex);
                led.command[3] = (byte)(comboBox4.SelectedIndex);
                led.command[4] = (byte)(comboBox5.SelectedIndex);
                led.command[5] = (byte)(comboBox6.SelectedIndex);
                led.command[6] = (byte)(comboBox7.SelectedIndex);
                led.command[7] = (byte)(comboBox8.SelectedIndex);
                led.command[8] = (byte)(comboBox9.SelectedIndex);
                led.command[9] = (byte)(comboBox10.SelectedIndex);
                led.command[10] = (byte)(comboBox11.SelectedIndex);
                led.command[11] = (byte)(comboBox12.SelectedIndex);
                led.command[12] = (byte)(comboBox13.SelectedIndex);
            }
            timer1.Interval = timer.Interval = Int32.Parse(delay_between_frames.Text);
            timer1.Enabled = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            preview.Clear();
        }

        private void button_send_led_trigger_Click(object sender, EventArgs e)
        {
            byte[] frame = new byte[4];
            frame[0] = 0xFF;
            frame[1] = 0;
            frame[2] = CRC8(frame, 2);
            frame[3] = 0x0A;
            SendToPort(frame);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] frame = new byte[4];
            
            frame[0] = (byte)(led.i + 100);
            if (queued.Checked) led.command[led.i - 1] |= (1 << 7);
            frame[1] = led.command[led.i - 1];
            frame[2] = CRC8(frame, 2);
            frame[3] = 0x0A;
            SendToPort(frame);

            if (led.i == led_quantity.Value)
            {
                timer1.Enabled = false;
                led.i = 1;
                return;
            }
            led.i++;
        }

        private void queued_CheckStateChanged(object sender, EventArgs e)
        {
            if (queued.Checked == true) button_send_led_trigger.Enabled = true;
            else
                button_send_led_trigger.Enabled = false;
        }
    }

 // moja klasa   
    public class Led
    {
        public Led()
        {
            command = new byte[13];
            //quantity = 6;
            i = 1;
        }
        public byte[] command;
        public int i; 
    }

}
