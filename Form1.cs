﻿using System;
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
using System.Collections;
using System.IO;

namespace ZBoard
{
    public partial class Dashboard : Form
    {


        private Button[] playbuttons = new Button[17];
        private Button[] editbuttons = new Button[17];

        

        public Dashboard()
        {
            InitializeComponent();

            //load everything
            initProfiles();

            //add buttons to array
            AddToArrays();

            // By the default set the volume to 0
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
           // trackWave.Value = CalcVol / (ushort.MaxValue / trackWave.Maximum);
        }

        private void ZBoard_Load(object sender, EventArgs e)
        {

        }

        private void AddToArrays()
        {
            playbuttons[1] = play1;
            playbuttons[2] = play2;
            playbuttons[3] = play3;
            playbuttons[4] = play4;
            playbuttons[5] = play5;
            playbuttons[6] = play6;
            playbuttons[7] = play7;
            playbuttons[8] = play8;
            playbuttons[9] = play9;
            playbuttons[10] = play10;
            playbuttons[11] = play11;
            playbuttons[12] = play12;
            playbuttons[13] = play13;
            playbuttons[14] = play14;
            playbuttons[15] = play15;
            playbuttons[16] = play16;
            
            editbuttons[1] = editplay1;
            editbuttons[2] = editplay2;
            editbuttons[3] = editplay3;
            editbuttons[4] = editplay4;
            editbuttons[5] = editplay5;
            editbuttons[6] = editplay6;
            editbuttons[7] = editplay7;
            editbuttons[8] = editplay8;
            editbuttons[9] = editplay9;
            editbuttons[10] = editplay10;
            editbuttons[11] = editplay11;
            editbuttons[12] = editplay12;
            editbuttons[13] = editplay13;
            editbuttons[14] = editplay14;
            editbuttons[15] = editplay15;
            editbuttons[16] = editplay16;
        }

        //              Initialize profiles
        private void initProfiles()
        {
            StreamReader Profiles = new StreamReader(Directory.GetCurrentDirectory() + "/Profiles/ProfilesNames.txt");
            string line = Profiles.ReadLine();
            while (line != null)
            {
                profilenames.Add(line);
                line = Profiles.ReadLine();
            }
            foreach (string str in profilenames)
            {
                listBox1.Items.Add(str);
            }
        }

        //moving window with mouse
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


        //button vars
        private string[] imgpaths = new string[17];
        private string[] wavpaths = new string[17];
        private string[] names = new string[17];
        private uint[] volumes = new uint[17];

        //              settings vars and img
        public void setButtonVars(int button, string ip, string wp, uint vl, string nm)
        {

            imgpaths[button] = ip;
            wavpaths[button] = wp;
            volumes[button] = vl;
            names[button] = nm;
            if (ip != null)
                playbuttons[button].BackgroundImage = Image.FromFile(ip);
            if (ip != null)
                imgpaths[button] = ip;
            if (wp != null)
                wavpaths[button] = wp;
            if (nm != null)
                playbuttons[button].Text = nm;
            volumes[button] = vl;
            
        }


        //              edit
        private bool emode = false;
        private void edit_play_Click(object sender, EventArgs e)
        {
            if (emode) emode = false;
            else emode = true;

            if (emode)
            {
                for (int i = 1; i < 17; i++)
                {
                    editbuttons[i].Visible = true;
                    playbuttons[i].Enabled = false;

                }
            }
            else
            {
                for (int i = 1; i < 17; i++)
                {
                    editbuttons[i].Visible = false;
                    playbuttons[i].Enabled = true;

                }
            }
        }

        //      open edit window
        private void openEditWindow(int n)
        {
            using (FormEdit form2 = new FormEdit())
            {
                form2.setVars(n, imgpaths[n], wavpaths[n], names[n]);
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    setButtonVars(form2.editedbutton, form2.imgpath, form2.wavpath, form2.volume, form2.name);
                }
            }
        }

        //              window options
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //          edit buttons
        private void editplay1_Click(object sender, EventArgs e)
        {
            openEditWindow(1);

        }
        private void editplay2_Click(object sender, EventArgs e)
        {
            openEditWindow(2);
        }
        private void editplay3_Click(object sender, EventArgs e)
        {
            openEditWindow(3);
        }
        private void editplay4_Click(object sender, EventArgs e)
        {
            openEditWindow(4);
        }
        private void editplay5_Click(object sender, EventArgs e)
        {
            openEditWindow(5);
        }
        private void editplay6_Click(object sender, EventArgs e)
        {
            openEditWindow(6);
        }
        private void editplay7_Click(object sender, EventArgs e)
        {
            openEditWindow(7);
        }
        private void editplay8_Click(object sender, EventArgs e)
        {
            openEditWindow(8);
        }
        private void editplay9_Click(object sender, EventArgs e)
        {
            openEditWindow(9);
        }
        private void editplay10_Click(object sender, EventArgs e)
        {
            openEditWindow(10);
        }
        private void editplay11_Click(object sender, EventArgs e)
        {
            openEditWindow(11);
        }
        private void editplay12_Click(object sender, EventArgs e)
        {
            openEditWindow(12);
        }
        private void editplay13_Click(object sender, EventArgs e)
        {
            openEditWindow(13);
        }
        private void editplay14_Click(object sender, EventArgs e)
        {
            openEditWindow(14);
        }
        private void editplay15_Click(object sender, EventArgs e)
        {
            openEditWindow(15);
        }
        private void editplay16_Click(object sender, EventArgs e)
        {
            openEditWindow(16);
        }

        //          play music
        //volume shit
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private void play(int n)
        {
            if (wavpaths[n] != null)
            {
                waveOutSetVolume(IntPtr.Zero, volumes[n]);
                SoundPlayer snd = new SoundPlayer(wavpaths[n]);
                snd.Play();
            }
        }

        //          play buttons
        private void play1_Click(object sender, EventArgs e)
        {
            play(1);
        }
        private void play2_Click(object sender, EventArgs e)
        { 
            play(2);
        }

        //          Profiles list
        List<String> profilenames = new List<String>();
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CheckProfileName(string name)
        {
            if (ProfileName.Text.Equals("Profile Name"))
                return false;
            if (ProfileName.Text.Equals(""))
                return false;
            int spaces = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals(' ')) spaces++;
            }
            if (spaces == name.Length) return false;
            foreach (string str in profilenames)
            {
                if (name.Equals(str))
                {
                    MessageBox.Show("Profile with this name already exist!");
                    return false;
                }
            }
            return true;
        }
        private void AddProfile_Click(object sender, EventArgs e)
        {

            if (CheckProfileName(ProfileName.Text))
            {
                
                StreamWriter save = new StreamWriter(Directory.GetCurrentDirectory()+"/Profiles/"+ ProfileName.Text+".txt");
                save.Close();
                profilenames.Add(ProfileName.Text);
                listBox1.Items.Add(ProfileName.Text);
                ProfileName.Text = "Profile Name";
                AddProfile.Enabled = false;
            }
            else ProfileName.Text = "Profile Name";
        }
        private void ProfileName_Click(object sender, EventArgs e)
        {
            if (ProfileName.Text.Equals("Profile Name"))
            {
                ProfileName.Text = "";
            }
        }
        private void ProfileName_TextChanged(object sender, EventArgs e)
        {
            if (!ProfileName.Text.Equals("Profile Name"))
                AddProfile.Enabled = true;
            if (ProfileName.Text.Equals("Profile Name"))
                AddProfile.Enabled = false;
        }
    }
}
