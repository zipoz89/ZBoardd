using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ZBoard
{
    public partial class FormEdit : Form
    {
        


        //          moving with mouse
        int mov;
        int movX;
        int movY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        //              seting values if already set
        public void setVars(int n,string ip,string wp,string nm)
        {
            editedbutton = n;
            imgpath = ip;
            wavpath = wp;
            if (imgpath != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(imgpath);
                Jpgpath.Text = imgpath;
            }
            if (wavpath != null)
            {
                wavPath.Text = wavpath;
                playTest.Enabled = true;
            }
            if (nm != null)
            {
                nameBox.Text = nm;
            }
        }

        //       vars to be saves
        public int editedbutton { get; set; }
        public string imgpath { get; set; }
        public string wavpath { get; set; }
        public uint volume { get; set; }
        public string name { get; set; }

        //volume shit
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);


        //init
        public FormEdit()
        {
            InitializeComponent();
            


            //             VOLUME
            // By the default set the volume to 0
            uint CurrVol = 1;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            trackWave.Value = CalcVol / (ushort.MaxValue / 100);
        }

        private void trackWave_Scroll(object sender, EventArgs e)
        {
            // Calculate the volume that's being set. BTW: this is a trackbar!
            int NewVolume = ((ushort.MaxValue / trackWave.Maximum) * trackWave.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            volume = NewVolumeAllChannels;
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //open buttons
        private void openImg_Click(object sender, EventArgs e)
        {
            // OpenFileDialog openFileDialog1 = new OpenFileDialog();
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff", Multiselect = false, ValidateNames = true })
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgpath = openFileDialog1.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(imgpath);
                    Jpgpath.Text = imgpath;
                }
            }
        }
        private void openWav_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "WAV|*.wav", Multiselect = false, ValidateNames = true })
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    wavpath = openFileDialog1.FileName;
                    wavPath.Text = wavpath;
                    playTest.Enabled = true;
                }
            }
        }
        //              holders
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        //              play
        private void playTest_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(wavpath);
            snd.Play();
        }

        public event Action ReloadForm1;

        //on the place where you will reload form1


        //              save and discard
        private void save_Click(object sender, EventArgs e)
        {

        }
        
        private void discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
