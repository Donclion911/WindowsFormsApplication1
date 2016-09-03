using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl2 : UserControl
    {
        public Form1 perent;
        public UserControl1 GroupPerent;
        int show=0;
        public string option;
        public UserControl2()
        {
            InitializeComponent();     
        }
        public void getPernt(Form1 f1,UserControl1 u1)
        {
            perent = f1;
            GroupPerent = u1;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            goon(GroupPerent.index+1);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            goon(GroupPerent.index+1);
        }
        public void goon(int current)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                option = null;
                GroupPerent.option = null;
                GroupPerent.BackColor = Color.Silver;
            }
            if (GroupPerent.pass)
            {
                if (show == 0 && !radioButton3.Checked && GroupPerent.pass)
                {
                    show++;
                    perent.addOption();
                }
                if (radioButton1.Checked)
                {
                    option = GroupPerent.option + " "+radioButton1.Text+" ";
                }
                else if (radioButton2.Checked)
                {
                    option = GroupPerent.option + " "+radioButton2.Text+" ";
                }
                else
                {
                    option = " "+GroupPerent.option+" ";
                }
            }
            else
            {
                radioButton3.Checked = true;
            }
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!radioButton3.Enabled)
            {
                goon(GroupPerent.index);
            }
            else
            {
                if (GroupPerent.index < perent.LC.Count - 1)
                {
                    radioButton3.Checked = false;
                    option = null;
                    GroupPerent.option = null;
                    GroupPerent.BackColor = Color.Silver;
                }
            }
        }
    }
}
