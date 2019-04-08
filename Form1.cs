using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBoard
{
    public partial class Dashboard : Form
    {
        

        private Button[] playbuttons = new Button[17];
        private Button[] editbuttons = new Button[17];

        public Dashboard()
        {
            InitializeComponent();
            //init of play button list
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
            //init of edit button list
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

        private void ZBoard_Load(object sender, EventArgs e)
        {
            // this.Location = Screen.AllScreens[1].WorkingArea.Location;
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
        public void setButtonVars(int button,string ip, string wp, uint vl,string nm)
        {
            
            imgpaths[button] = ip;
            wavpaths[button] = wp;
            volumes[button] = vl;
            names[button] = nm;
            if(ip!=null)
                playbuttons[button].BackgroundImage = Image.FromFile(ip);
            if (nm != null)
                playbuttons[button].Text = nm;
        }


        //              edit
        private bool emode = false;
        private void edit_play_Click(object sender, EventArgs e)
        {
            if (emode) emode = false;
            else emode = true;

            if (emode)
            {
                for (int i = 1 ; i<17 ; i++)
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
                form2.setVars(n,imgpaths[n],wavpaths[n],names[n]);
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                 setButtonVars(form2.editedbutton, form2.imgpath, form2.wavpath, form2.volume, form2.name);
                }
            }
        }
       
        private void play1_Click(object sender, EventArgs e)
        {
            
        }

        private void play2_Click(object sender, EventArgs e)
        {

        }
        


        private void editplay1_Click(object sender, EventArgs e)
        {
           openEditWindow(1);
           
        }
        private void editplay2_Click(object sender, EventArgs e)
        {
            openEditWindow(2);
        }
        

        
        //window options
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimalize_Click()
        {
            throw new NotImplementedException();
        }


       
       
    }
}
