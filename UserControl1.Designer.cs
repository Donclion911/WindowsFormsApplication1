namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.Columes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Blackoak Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(212, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(233, 13);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(106, 21);
            this.Value.TabIndex = 7;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.Value.Enter += new System.EventHandler(this.Value_Enter);
            this.Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // Columes
            // 
            this.Columes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Columes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Columes.FormattingEnabled = true;
            this.Columes.Location = new System.Drawing.Point(79, 13);
            this.Columes.Name = "Columes";
            this.Columes.Size = new System.Drawing.Size(121, 20);
            this.Columes.TabIndex = 6;
            this.Columes.SelectedValueChanged += new System.EventHandler(this.Columes_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::WindowsFormsApplication1.Properties.Settings.Default, "Items", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.domainUpDown1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown1.Items.Add("=");
            this.domainUpDown1.Items.Add(">=");
            this.domainUpDown1.Items.Add("<=");
            this.domainUpDown1.Items.Add(">");
            this.domainUpDown1.Items.Add("<");
            this.domainUpDown1.Location = new System.Drawing.Point(200, 13);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.SelectedIndex = global::WindowsFormsApplication1.Properties.Settings.Default.Items;
            this.domainUpDown1.Size = new System.Drawing.Size(33, 21);
            this.domainUpDown1.TabIndex = 11;
            this.domainUpDown1.Text = "=";
            this.domainUpDown1.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Columes);
            this.Controls.Add(this.label3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(425, 223);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.TextBox Value;
        public System.Windows.Forms.ComboBox Columes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}
