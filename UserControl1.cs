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
    public partial class UserControl1 : UserControl
    {
        public Boolean afterloading = false;
        public string option = "";
        public Boolean pass = false;
        public UserControl2 children;
        public int index;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void Columes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (afterloading)
            {
                if (((KeyValuePair<string, string>)this.Columes.SelectedItem).Value == "System.DateTime")
                {
                    this.monthCalendar1.Visible = true;
                    this.Value.ReadOnly = true;
                    domainUpDown1.Visible = true;
                }
                else
                {
                    domainUpDown1.Visible = false;
                    this.monthCalendar1.Visible = false;
                    this.Value.ReadOnly = false;
                    this.Value.Text = "";
                }
            }
        }
        private void UserControl1_Leave(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
        }

        private void setOption()
        {
            try
            {
                this.Validate();
                if (Value.Text.Trim() == "")
                {
                    option = "";
                }
                if (this.Columes.SelectedItem != null)
                {
                    switch (((KeyValuePair<string, string>)this.Columes.SelectedItem).Value)
                    {
                        case "System.Int32":
                            int num;
                            if (int.TryParse(this.Value.Text.Trim(), out num))
                                this.option = this.Columes.Text + " = " + num.ToString();
                            break;
                        case "System.String":
                            this.option = this.Columes.Text +
                                 " like '%" + this.Value.Text.Trim() + "%'";
                            break;
                        case "System.Boolean":
                            if (this.Value.Text.Trim() == "0" || this.Value.Text.Trim() == "1")
                            {
                                this.option = this.Columes.Text +
                                   " = " + Convert.ToBoolean(Convert.ToInt32(this.Value.Text.Trim()));
                            }
                            break;
                        case "System.DateTime":
                            this.option =
                                 this.Columes.Text.Trim() +
                                 domainUpDown1.Text.Trim()+"'" + monthCalendar1.SelectionStart.Date + "'";
                            break;
                    }
                    pass = true;
                    this.monthCalendar1.Visible = false;
                    this.BackColor = Color.Honeydew;

                }
            }
            catch
            {
                MessageBox.Show(this, "Fail to complete", "Error");
            }
        }
        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (Value.Text.Trim() != "" && Columes.SelectedItem == null)
                {
                    setOption();
                }
                else
                {
                    this.BackColor = Color.Silver;
                    pass = false;
                }
            }
        }
        private void Value_Enter(object sender, EventArgs e)
        {
            if (Value.Text.Trim() == ""||Columes.SelectedItem==null)
            {
                this.BackColor = Color.Silver;
                pass = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Value.Text.Trim() == "" || Columes.SelectedItem == null)
            {
                this.BackColor = Color.Silver;
                pass = false;
            }
            else
            {
                setOption();
                children.goon(index);
            }
        }
        private void Value_TextChanged(object sender, EventArgs e)
        {
            if (Value.Text.Trim() == "")
            {
                this.BackColor = Color.Silver;
                pass = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Value.Text = e.Start.Date.GetDateTimeFormats()[0].ToString();
            setOption();
            children.goon(index);
        }
    }
}
