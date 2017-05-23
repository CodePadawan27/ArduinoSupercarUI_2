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
        public Socket led_socket = null;

        //Kameran määrittelymuuttujat
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

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
            Close();
        }

        //Kameran stop-nappi
        private void UI_button_stop_Click(object sender, EventArgs e)
        {
            if(cam.IsRunning)
            {
                cam.Stop();
                UI_webcam.Image = ArduinoSupercarUI.Properties.Resources.presstartlivefeed;
            }
        }

        private void UI_button_picture_Click(object sender, EventArgs e)
        {
            UI_tallennusRuutu.InitialDirectory = @"c:\ArduinoKuvat";
            if(UI_tallennusRuutu.ShowDialog() == DialogResult.OK)
            {
                UI_webcam.Image.Save(UI_tallennusRuutu.FileName);
            }
        }

        private void UI_button_start_Click(object sender, EventArgs e)
        {
            if(UI_combobox_valikko.Items.Count != 0)
            {
                if (UI_combobox_valikko.SelectedItem != null)
                {
                    cam = new VideoCaptureDevice(webcam[UI_combobox_valikko.SelectedIndex].MonikerString);

                    cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                    cam.Start();
                } else
                {
                    MessageBox.Show("Select a webcam first.");
                }
            } else
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
            MessageBox.Show("Terve");
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

        }

        private void UI_left_Click(object sender, EventArgs e)
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

        private void UI_connection_ip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
