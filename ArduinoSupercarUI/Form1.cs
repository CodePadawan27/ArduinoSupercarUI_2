using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ArduinoSupercarUI
{
    public partial class arduinoUI : Form
    {
        //Yhteyden määrittelymuuttujat
        public bool connected_to_host = false;

        //Kameran määrittelymuuttujat
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        private bool webcam_on = false;

        public class Globals
        {
            public static Socket led_socket;
            public static Thread oThread;

            public static string Lights = "X";
            public static string Temperature = "???";

            public static string Forward = "X";
            public static string Backward = "X";
            public static string Left = "X";
            public static string Right = "X";
        }

        public arduinoUI()
        {
            InitializeComponent();
        }
        

        


        private void arduinoUI_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                UI_combobox_valikko.Items.Add(VideoCaptureDevice.Name);
            }            
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webcam_on)
            {
                cam.Stop();
            }
            Close();
        }

        private void UI_button_picture_Click(object sender, EventArgs e)
        {
            UI_tallennusRuutu.InitialDirectory = @"c:\ArduinoKuvat";
            if(UI_tallennusRuutu.ShowDialog() == DialogResult.OK)
            {
                UI_webcam.Image.Save(UI_tallennusRuutu.FileName);
            }
        }

        private void UI_button_popout_Click(object sender, EventArgs e)
        {
            if(webcam_on)
            {
                Form2 Form2 = new Form2(cam);
                Form2.Show();
            }
        }

        private void UI_button_start_Click(object sender, EventArgs e)
        {
            if (webcam_on)
            {
                cam.Stop();
                webcam_on = false;
                UI_button_start.Text = "Start";
                UI_button_picture.Enabled = false;
                UI_button_popout.Enabled = false;
                UI_webcam.Image = Properties.Resources.presstartlivefeed;
            }
            else if (UI_combobox_valikko.Items.Count != 0)
            {
                if (UI_combobox_valikko.SelectedItem != null)
                {
                    cam = new VideoCaptureDevice(webcam[UI_combobox_valikko.SelectedIndex].MonikerString);

                    cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                    cam.Start();

                    UI_button_start.Text = "Stop";
                    UI_button_picture.Enabled = true;
                    UI_button_popout.Enabled = true;
                    webcam_on = true;
                } else
                {
                    MessageBox.Show("Select a webcam first.");
                }
            }
            else
            {
                MessageBox.Show("Connect a webcam first.");
            }
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            UI_webcam.Image = bit;
        }

        private void UI_combobox_valikko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arduino Supercar Team\n\n Jarno Rostedt\n Teemu Kettunen\n Saija Kaitio\n Seila Laakso\n Niina Sormunen ");
        }

        private void UI_webcam_Click(object sender, EventArgs e)
        {

        }

        //Connect-napin määrittely
        private void UI_button_connect_Click(object sender, EventArgs e)
        {
            if (connected_to_host == false)
            {
                UI_button_connect.Text = "Connect";

                string ip = UI_connection_ip.Text;
                int port = Convert.ToInt32(UI_connection_port.Text);

                Globals.led_socket = ConnectSocket(ip, port);

                Worker oWorker = new Worker();

                // Create the thread object, passing in the Alpha.Beta method
                // via a ThreadStart delegate. This does not start the thread.
                Globals.oThread = new Thread(new ThreadStart(oWorker.Beta));

                Globals.oThread.Start();


                if (Globals.led_socket != null)
                {
                    connected_to_host = true;
                    UI_button_connect.Text = "Disconnect";

                }
            }
            else
            {
                UI_button_connect.Text = "Disconnect";
                Globals.led_socket.Close();
                Globals.oThread.Abort();
                connected_to_host = false;
                UI_button_connect.Text = "Connect";

            }
        }

        private void UI_up_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.Up);
        }
        private void UI_left_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.Left);
        }
        private void UI_right_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.Right);
        }
        private void UI_down_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.Down);
        }
        private void UI_break_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.Space);
        }
        private void UI_lights_ON_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.L);
        }

        private void UI_lights_OFF_Click(object sender, EventArgs e)
        {
            UI_Button_Press(Keys.L);
        }

        private void UI_connection_ip_TextChanged(object sender, EventArgs e)
        {

        }

        public static Socket ConnectSocket(string server, int port)
        {
            Socket s = null;
            IPHostEntry hostEntry = null;

            // Get host related information.
            hostEntry = Dns.GetHostEntry(server);

            // Loop through the AddressList to obtain the supported AddressFamily. This is to avoid
            // an exception that occurs when the host IP Address is not compatible with the address family
            // (typical in the IPv6 case).
            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint ipe = new IPEndPoint(address, port);
                Socket tempSocket =
                    new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    tempSocket.Connect(ipe);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("This is your fault, Make sure Car is Turned on.");
                }

                if (tempSocket.Connected)
                {
                    s = tempSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return s;
        }


        public class Worker
        {
            public void Beta()
            {
                while (true)
                {
                    //Console.WriteLine(Globals.Forward + Globals.Backward + Globals.Left + Globals.Right 
                    //     + Globals.Lights +"\n");

                    arduinoUI.SendCommand(Globals.led_socket, Globals.Forward + Globals.Backward + Globals.Left + Globals.Right + Globals.Lights + "\n");

                }

            }
        }

        private static void SendCommand(Socket s, string c)
        {
            Byte[] command = Encoding.ASCII.GetBytes(c);
            try
            {
                s.Send(command, command.Length, 0);

            }
            catch (Exception Ex)
            {

                Globals.oThread.Abort();

                MessageBox.Show("Connection Aborted because it was already gone. I blame you.");


            }

        }

        private void UI_Button_Press(Keys key)
        {
            switch (key)
            {
                case Keys.L:
                    Globals.Lights = Globals.Lights == "O" ? "X" : "O";
                    UI_lights_ON.BackColor = UI_lights_ON.BackColor == SystemColors.Control ? Color.LightBlue : SystemColors.Control;
                    UI_lights_ON.Text = UI_lights_ON.Text == "ON" ? "OFF" : "ON";
                    break;
                case Keys.Up:
                    Globals.Forward = Globals.Forward == "F" ? "X" : "F";
                    Globals.Backward = "X";
                    break;
                case Keys.Down:
                    Globals.Backward = Globals.Backward == "B" ? "X" : "B";
                    Globals.Forward = "X";
                    break;
                case Keys.Left:
                    Globals.Left = Globals.Left == "L" ? "X" : "L";
                    Globals.Right = "X";
                    break;
                case Keys.Right:
                    Globals.Right = Globals.Right == "R" ? "X" : "R";
                    Globals.Left = "X";
                    break;
                case Keys.Space:
                    Globals.Forward = "X";
                    Globals.Backward = "X";
                    break;
            }

            UI_Debug.Text = Globals.Forward.ToString() + "\n" + Globals.Backward.ToString() + "\n" + Globals.Left.ToString() + "\n" + Globals.Right.ToString() + "\n" + Globals.Lights.ToString();

        }

        private void arduinoUI_KeyUP(object sender, KeyEventArgs e)
        {
            // Determine whether the key entered is the F1 key. Display help if it is.
            /*if (e.KeyCode == Keys.L)
            {
                Globals.Lights = "X";
            }*/
            if (e.KeyCode == Keys.Up)
            {
                Globals.Forward = "X";
                UI_up.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Down)
            {
                Globals.Backward = "X";
                UI_down.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Left)
            {
                Globals.Left = "X";
                UI_left.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Right)
            {
                Globals.Right = "X";
                UI_right.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Space)
            {
                UI_break.BackColor = SystemColors.Control;
            }

            UI_Debug.Text = Globals.Forward.ToString() + "\n" + Globals.Backward.ToString() + "\n" + Globals.Left.ToString() + "\n" + Globals.Right.ToString() + "\n" + Globals.Lights.ToString();

        }

        private void arduinoUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (!connected_to_host)
            {

                if (e.KeyCode == Keys.L)
                {
                    Globals.Lights = Globals.Lights == "O" ? "X" : "O";
                    UI_lights_ON.BackColor = UI_lights_ON.BackColor == SystemColors.Control ? Color.LightBlue : SystemColors.Control;
                    UI_lights_ON.Text = UI_lights_ON.Text == "ON" ? "OFF" : "ON";
                }
                if (e.KeyCode == Keys.Up)
                {
                    Globals.Forward = "F";
                    Globals.Backward = "X";
                    UI_up.BackColor = Color.LightBlue;
                }
                if (e.KeyCode == Keys.Down)
                {
                    Globals.Backward = "B";
                    Globals.Forward = "X";
                    UI_down.BackColor = Color.LightBlue;
                }
                if (e.KeyCode == Keys.Left)
                {
                    Globals.Left = "L";
                    Globals.Right = "X";
                    UI_left.BackColor = Color.LightBlue;
                }
                if (e.KeyCode == Keys.Right)
                {
                    Globals.Right = "R";
                    Globals.Left = "X";
                    UI_right.BackColor = Color.LightBlue;
                }
                if (e.KeyCode == Keys.Space)
                {
                    Globals.Forward = "X";
                    Globals.Backward = "X";
                    UI_break.BackColor = Color.LightBlue;
                }
            }
            else
            {
                MessageBox.Show("Not Connected to Client");
            }
            UI_Debug.Text = Globals.Forward.ToString() + "\n" + Globals.Backward.ToString() + "\n" + Globals.Left.ToString() + "\n" + Globals.Right.ToString() + "\n" + Globals.Lights.ToString();

        }

        private void UI_Debug_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            UI_Debug.Focus();
        }

        private void arduinoUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(webcam_on)
            {
                cam.Stop();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ManualPath = Application.StartupPath + @"\Manual\Manual.htm";
            try
            {
                System.Diagnostics.Process.Start(ManualPath);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Failed to open manual.\nIt is located in the Manual folder.");
            }
        }
    }
}
