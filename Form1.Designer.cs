namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DC = new System.Windows.Forms.DateTimePicker();
            this.DS = new System.Windows.Forms.DateTimePicker();
            this.CMM = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.Label();
            this.SA = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.TextBox();
            this.ShippingAddress = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.Label();
            this.DateShipped = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(877, 281);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.DC);
            this.groupBox1.Controls.Add(this.DS);
            this.groupBox1.Controls.Add(this.CMM);
            this.groupBox1.Controls.Add(this.Comments);
            this.groupBox1.Controls.Add(this.SA);
            this.groupBox1.Controls.Add(this.CE);
            this.groupBox1.Controls.Add(this.ShippingAddress);
            this.groupBox1.Controls.Add(this.CustomerEmail);
            this.groupBox1.Controls.Add(this.DateShipped);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CN
            // 
            this.CN.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold);
            this.CN.Location = new System.Drawing.Point(221, 36);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(148, 19);
            this.CN.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(756, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 124);
            this.button2.TabIndex = 17;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(6, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DC
            // 
            this.DC.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC.Location = new System.Drawing.Point(221, 71);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(148, 19);
            this.DC.TabIndex = 14;
            this.DC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DC_KeyPress);
            // 
            // DS
            // 
            this.DS.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS.Location = new System.Drawing.Point(221, 105);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(148, 19);
            this.DS.TabIndex = 13;
            this.DS.CloseUp += new System.EventHandler(this.DS_CloseUp);
            this.DS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DS_KeyPress);
            // 
            // CMM
            // 
            this.CMM.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMM.Location = new System.Drawing.Point(520, 107);
            this.CMM.Multiline = true;
            this.CMM.Name = "CMM";
            this.CMM.Size = new System.Drawing.Size(222, 53);
            this.CMM.TabIndex = 12;
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comments.Location = new System.Drawing.Point(423, 107);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(91, 17);
            this.Comments.TabIndex = 11;
            this.Comments.Text = "Comments";
            // 
            // SA
            // 
            this.SA.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SA.Location = new System.Drawing.Point(520, 71);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(222, 19);
            this.SA.TabIndex = 10;
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(520, 36);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(222, 19);
            this.CE.TabIndex = 9;
            // 
            // ShippingAddress
            // 
            this.ShippingAddress.AutoSize = true;
            this.ShippingAddress.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingAddress.Location = new System.Drawing.Point(374, 70);
            this.ShippingAddress.Name = "ShippingAddress";
            this.ShippingAddress.Size = new System.Drawing.Size(140, 17);
            this.ShippingAddress.TabIndex = 6;
            this.ShippingAddress.Text = "Shipping Address";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSize = true;
            this.CustomerEmail.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.Location = new System.Drawing.Point(386, 38);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(128, 17);
            this.CustomerEmail.TabIndex = 5;
            this.CustomerEmail.Text = "Customer Email";
            // 
            // DateShipped
            // 
            this.DateShipped.AutoSize = true;
            this.DateShipped.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateShipped.Location = new System.Drawing.Point(108, 107);
            this.DateShipped.Name = "DateShipped";
            this.DateShipped.Size = new System.Drawing.Size(110, 17);
            this.DateShipped.TabIndex = 3;
            this.DateShipped.Text = "Date Shipped";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Created";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 281);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 238);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detail Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateShipped;
        private System.Windows.Forms.Label ShippingAddress;
        private System.Windows.Forms.Label CustomerEmail;
        private System.Windows.Forms.TextBox SA;
        private System.Windows.Forms.TextBox CE;
        private System.Windows.Forms.TextBox CMM;
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.DateTimePicker DS;
        private System.Windows.Forms.DateTimePicker DC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CN;
    }
}

