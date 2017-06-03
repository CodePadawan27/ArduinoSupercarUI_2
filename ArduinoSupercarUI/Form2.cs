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

namespace ArduinoSupercarUI
{
    public partial class Form2 : Form
    {
        public Form2(VideoCaptureDevice popout_cam)
        {
            InitializeComponent();
            popout_cam.NewFrame += new NewFrameEventHandler(popout_NewFrame);
            popout_cam.Start();
        }

        void popout_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            popout_webcam.Image = bit;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
