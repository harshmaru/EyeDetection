using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace CamOut
{
    public partial class Form1 : Form
    {
        private Capture cap;
        private bool capinp;
        private HaarCascade haar;
        public Form1()
        {
            InitializeComponent();
        }
        private void FrameProcess(object sender,EventArgs e)
        {
            Image<Bgr, Byte> ImageFrame = cap.QueryFrame();
            if(ImageFrame != null)
            {
                Image<Gray,Byte> grayframe = ImageFrame.Convert<Gray , Byte>();
                var faces = grayframe.DetectHaarCascade(haar, 1.4, 4, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(25, 25))[0];
                foreach(var face in faces)
                {
                    ImageFrame.Draw(face.rect,new Bgr(Color.Green),3);
                }
            }
            ImgBox.Image = ImageFrame.ToBitmap();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            if(cap == null)
            {
                    try
                    {
                        cap = new Capture();
                    }
                    catch(Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
            }
            if(cap != null)
            {
                if (capinp)
                {
                    start();
                }
                else
                {
                    stop();
                }
                capinp = !capinp;
            }
        }
        public void start()
        {
            btns.Text = "Start";
            Application.Idle -= FrameProcess;
        }
        public void stop()
        {
            btns.Text = "Stop";
            Application.Idle += FrameProcess;
        }
        private void btncap_Click(object sender, EventArgs e)
        {
            /*if(btns.Text == "Start")
            {
                //ImgBox.Refresh;
                //ImgBox.Update;
                btncap.Text = "Capture";
                stop();
                Image<Bgr, Byte> ImageFrame = cap.QueryFrame();
                ImgBox.Image = ImageFrame.ToBitmap();
                stop();
                DialogResult result;
                result = MessageBox.Show("Do you want to save ??","",MessageBoxButtons.YesNo);
                if(result.ToString() == "Yes")
                {
                     ImageFrame.Save("E:\\harsh\\speech\\Save1.jpg");

                }
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            haar = new HaarCascade("haarcascade_eye.xml");
        }

    }
}
