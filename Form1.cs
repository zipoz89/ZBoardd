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
    public partial class ZBoard : Form
    {
        public ZBoard()
        {
            InitializeComponent();
            imgpaths[1] = @"C:\Users\zipoz\source\repos\ZBoard\ZBoard\Resources\giphy.gif";
            play1.BackgroundImage = Image.FromFile(imgpaths[1]);
            names[1] = "hakuna ma tata";
        }

        private bool emode = false;
        //button vars
        private string[] imgpaths = new string[17];
        private string[] wavpaths = new string[17];
        private string[] names = new string[17];
        private uint[] volumes = new uint[17];

        
        public void setButtonVars(int button,string ip, string wp, uint vl,string nm)
        {
            imgpaths[button] = ip;
            wavpaths[button] = wp;
            volumes[button] = vl;
            names[button] = nm;

        }

        //edit
        private void edit_play_Click(object sender, EventArgs e)
        {
            if (emode) emode = false;
            else emode = true;

            if (emode)
            {
                editplay1.Visible = true;
                play1.Enabled = false;
                editplay2.Visible = true;
                play2.Enabled = false;
            }
            else
            {
                editplay1.Visible = false;
                play1.Enabled = true;
                editplay2.Visible = false;
                play2.Enabled = true;
            }
        }
       

        //play
        private void play1_Click(object sender, EventArgs e)
        {
            
        }

        private void play2_Click(object sender, EventArgs e)
        {

        }
        //edit
        private void editplay1_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit();
            form2.Show();
            form2.setVars(1,imgpaths[1],wavpaths[1],names[1]);
        }
        private void editplay2_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit();
            form2.Show();
        }
        

        private void ZBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
