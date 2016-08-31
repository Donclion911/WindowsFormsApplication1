using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        DataTable dt;
        SqlDataAdapter adp;
        SqlCommandBuilder comm;
        BindingSource bs;
        DataRow newRow;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(@"Data Source=.;Initial Catalog=master;Integrated Security=True");
        }
        private void checkDatePick(DateTimePicker DP,int Rindex ,int Cindex)
        {
            if (this.dataGridView1.Rows[Rindex].Cells[Cindex].Value.ToString() == "")
            {
                DP.Format = DateTimePickerFormat.Custom;
                DP.CustomFormat = "Unknown";
            }
            else
            {
                DP.Format = DateTimePickerFormat.Custom;
                DP.CustomFormat = "yyyy/MM/dd";
            }
        }
        private void checkDatePick(DateTimePicker DP,int Cindex)
        {
            if (this.dataGridView1.CurrentRow.Cells[Cindex].Value.ToString() == "")
            {
                DP.Format = DateTimePickerFormat.Custom;
                DP.CustomFormat = "Unknown";            
            }
            else
            {
                DP.Format = DateTimePickerFormat.Custom;
                DP.CustomFormat = "yyyy/MM/dd";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt=new DataTable();
            adp = new SqlDataAdapter("select * from Orders", cnn);
            bs = new BindingSource();
            cnn.Open();
            adp.Fill(dt);
            cnn.Close();
            bs.DataSource = dt;
            this.dataGridView1.DataSource = bs;
            DC.DataBindings.Add(new Binding("Text", bs, "DateCreated", true, DataSourceUpdateMode.OnValidation));
            DS.DataBindings.Add(new Binding("Text", bs, "DateShipped", true, DataSourceUpdateMode.OnValidation));
            CE.DataBindings.Add(new Binding("Text", bs, "CustomerEmail", true, DataSourceUpdateMode.OnValidation));
            SA.DataBindings.Add(new Binding("Text", bs, "ShippingAddress", true, DataSourceUpdateMode.OnValidation));
            CMM.DataBindings.Add(new Binding("Text", bs, "Comments", true, DataSourceUpdateMode.OnValidation));
            CN.DataBindings.Add(new Binding("Text", bs, "CustomerName", true, DataSourceUpdateMode.OnValidation));
            loadTable();
        }
        private void loadTable()
        {
            foreach (DataGridViewColumn temp in dataGridView1.Columns)
            {
                if (temp.HeaderText == "OrderID")
                {
                    temp.ReadOnly = true;
                }
                if (temp.HeaderText == "DateShipped" 
                   || temp.HeaderText == "DateCreated")
                {
                    temp.Visible = false;
                }
                if (  temp.HeaderText == "Comments"
                   || temp.HeaderText == "CustomerEmail"
                   || temp.HeaderText == "ShippingAddress")
                {
                    temp.Visible = false;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder feedback = new StringBuilder();
            try
            {
                comm = new SqlCommandBuilder(adp);
                feedback.Append(MessageBox.Show(this, 
                             "Do you want to saving your changed?", 
                             "Enter", MessageBoxButtons.YesNo));
                if (feedback.ToString() == "Yes")
                {
                    adp.Update(dt);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to update your changed");
                Debug.WriteLine(ex.Message);
            }
            this.dataGridView1.RefreshEdit();
            loadTable();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MessageBox.Show(this, e.Exception.Message, "Help Message");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Boolean canceled = false;
            try
            {
                this.Validate();
                bs.EndEdit();
                if (dt.GetChanges() != null)
                {
                    int index = 0;
                    comm = new SqlCommandBuilder(adp);
                        if (MessageBox.Show(this, "Do you want to save the changed?",
                           "Saving", MessageBoxButtons.YesNo).ToString() == "Yes")
                        {
                            adp.Update(dt);
                            index = this.dataGridView1.CurrentCell.RowIndex;
                        }
                        else
                        {
                            canceled = true;
                        }
                    this.button4.Enabled = true;
                    dataGridView1.Enabled = true;
                    this.dataGridView1.RefreshEdit();
                    if (!canceled)
                        dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.CurrentCell = this.dataGridView1.Rows[index].Cells[0];
                    dataGridView1.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("There has no any changed");
                }
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Fail to submit form");
                canceled = true;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                if (!(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType ==
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.GetType()))
                {
                    MessageBox.Show(this, "Changed value must be" +
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name.ToString(), "Help");
                    dt.RejectChanges();
                    dataGridView1.CurrentCell=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Help");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 27)
            {
                this.DC.DataBindings.Clear();
                this.DC.DataBindings.Add(new Binding("text", dt, "DateCreated", true, DataSourceUpdateMode.OnValidation));
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            newRow = dt.NewRow();
            dt.Rows.Add(newRow);
            DC.Text = "";
            this.dataGridView1.Enabled = false;
            this.dataGridView1.ClearSelection();
            this.dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            DC.Format = DateTimePickerFormat.Custom;
            DC.CustomFormat = "yyyy/MM/dd";
            DS.Format = DateTimePickerFormat.Custom;
            DS.CustomFormat = "yyyy/MM/dd";
            button4.Enabled = false;
        }
        private void DS_CloseUp(object sender, EventArgs e)
        {
            DS.Format = DateTimePickerFormat.Custom;
            DS.CustomFormat = "yyyy/MM/dd";
        }

        private void DC_CloseUp(object sender, EventArgs e)
        {
            DC.Format = DateTimePickerFormat.Custom;
            DC.CustomFormat = "yyyy/MM/dd";
        }

        private void DC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 27)
            {
                checkDatePick(DC,1);
            }
        }
        private void DS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 27)
            {
                checkDatePick(DS,2);
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 1)
            {
                checkDatePick(DC,e.RowIndex,1);
                checkDatePick(DS,e.RowIndex,2);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
                if (MessageBox.Show(this, "Do you want to Delete records?", "Deleting", MessageBoxButtons.YesNo).ToString() == "No")
                {
                    e.Cancel = true;
                }
        }
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                comm = new SqlCommandBuilder(adp);
                this.Validate();
                bs.EndEdit();
                adp.Update(dt);
            }
            catch
            {
                MessageBox.Show(this,"Fail to delete records.","FeedBack");
            }
            dt.Clear();
            adp.Fill(dt);
            this.dataGridView1.RefreshEdit();
        }
    }
}
