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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 281);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 295);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 219);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Stencil Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(863, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(3, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(863, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detail Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
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
            this.groupBox1.Size = new System.Drawing.Size(863, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CN
            // 
            this.CN.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold);
            this.CN.Location = new System.Drawing.Point(218, 58);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(148, 19);
            this.CN.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(753, 58);
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
            this.button4.Location = new System.Drawing.Point(3, 93);
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
            this.DC.Location = new System.Drawing.Point(218, 93);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(148, 19);
            this.DC.TabIndex = 14;
            this.DC.CloseUp += new System.EventHandler(this.DC_CloseUp);
            this.DC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DC_KeyPress);
            // 
            // DS
            // 
            this.DS.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS.Location = new System.Drawing.Point(218, 127);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(148, 19);
            this.DS.TabIndex = 13;
            this.DS.CloseUp += new System.EventHandler(this.DS_CloseUp);
            this.DS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DS_KeyPress);
            // 
            // CMM
            // 
            this.CMM.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMM.Location = new System.Drawing.Point(517, 129);
            this.CMM.Multiline = true;
            this.CMM.Name = "CMM";
            this.CMM.Size = new System.Drawing.Size(222, 53);
            this.CMM.TabIndex = 12;
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comments.Location = new System.Drawing.Point(420, 129);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(91, 17);
            this.Comments.TabIndex = 11;
            this.Comments.Text = "Comments";
            // 
            // SA
            // 
            this.SA.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SA.Location = new System.Drawing.Point(517, 93);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(222, 19);
            this.SA.TabIndex = 10;
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Tekton Pro Ext", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(517, 58);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(222, 19);
            this.CE.TabIndex = 9;
            // 
            // ShippingAddress
            // 
            this.ShippingAddress.AutoSize = true;
            this.ShippingAddress.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingAddress.Location = new System.Drawing.Point(371, 92);
            this.ShippingAddress.Name = "ShippingAddress";
            this.ShippingAddress.Size = new System.Drawing.Size(140, 17);
            this.ShippingAddress.TabIndex = 6;
            this.ShippingAddress.Text = "Shipping Address";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSize = true;
            this.CustomerEmail.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.Location = new System.Drawing.Point(383, 60);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(128, 17);
            this.CustomerEmail.TabIndex = 5;
            this.CustomerEmail.Text = "Customer Email";
            // 
            // DateShipped
            // 
            this.DateShipped.AutoSize = true;
            this.DateShipped.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateShipped.Location = new System.Drawing.Point(105, 129);
            this.DateShipped.Name = "DateShipped";
            this.DateShipped.Size = new System.Drawing.Size(110, 17);
            this.DateShipped.TabIndex = 3;
            this.DateShipped.Text = "Date Shipped";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Created";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(877, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

