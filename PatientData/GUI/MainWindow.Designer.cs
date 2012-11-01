namespace PatientData.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_cmVisit1Enable = new System.Windows.Forms.CheckBox();
            this.ddl_cmVisit1Rational = new System.Windows.Forms.ComboBox();
            this.dtp_cmVisit1Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_cmVisit2Enable = new System.Windows.Forms.CheckBox();
            this.dtp_cmVisit2Date = new System.Windows.Forms.DateTimePicker();
            this.ddl_cmVisit2Rational = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_cmVisit3Enable = new System.Windows.Forms.CheckBox();
            this.dtp_cmVisit3Date = new System.Windows.Forms.DateTimePicker();
            this.ddl_cmVisit3Rational = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_cmVisit4Enable = new System.Windows.Forms.CheckBox();
            this.dtp_cmVisit4Date = new System.Windows.Forms.DateTimePicker();
            this.ddl_cmVisit4Rational = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chk_cmVisit5Enable = new System.Windows.Forms.CheckBox();
            this.dtp_cmVisit5Date = new System.Windows.Forms.DateTimePicker();
            this.ddl_cmVisit5Rational = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCombinationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getACVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_createCombinations = new System.Windows.Forms.Button();
            this.btn_getACVs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_createTestData = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(983, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_cmVisit1Enable);
            this.groupBox1.Controls.Add(this.ddl_cmVisit1Rational);
            this.groupBox1.Controls.Add(this.dtp_cmVisit1Date);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit 1";
            // 
            // chk_cmVisit1Enable
            // 
            this.chk_cmVisit1Enable.AutoSize = true;
            this.chk_cmVisit1Enable.Checked = true;
            this.chk_cmVisit1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cmVisit1Enable.Location = new System.Drawing.Point(6, 19);
            this.chk_cmVisit1Enable.Name = "chk_cmVisit1Enable";
            this.chk_cmVisit1Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit1Enable.TabIndex = 2;
            this.chk_cmVisit1Enable.Text = "Enable";
            this.chk_cmVisit1Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit1Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // ddl_cmVisit1Rational
            // 
            this.ddl_cmVisit1Rational.FormattingEnabled = true;
            this.ddl_cmVisit1Rational.Location = new System.Drawing.Point(6, 68);
            this.ddl_cmVisit1Rational.Name = "ddl_cmVisit1Rational";
            this.ddl_cmVisit1Rational.Size = new System.Drawing.Size(177, 21);
            this.ddl_cmVisit1Rational.TabIndex = 1;
            // 
            // dtp_cmVisit1Date
            // 
            this.dtp_cmVisit1Date.Location = new System.Drawing.Point(6, 42);
            this.dtp_cmVisit1Date.Name = "dtp_cmVisit1Date";
            this.dtp_cmVisit1Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit1Date.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_cmVisit2Enable);
            this.groupBox2.Controls.Add(this.dtp_cmVisit2Date);
            this.groupBox2.Controls.Add(this.ddl_cmVisit2Rational);
            this.groupBox2.Location = new System.Drawing.Point(199, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visit 2";
            // 
            // chk_cmVisit2Enable
            // 
            this.chk_cmVisit2Enable.AutoSize = true;
            this.chk_cmVisit2Enable.Checked = true;
            this.chk_cmVisit2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cmVisit2Enable.Location = new System.Drawing.Point(6, 19);
            this.chk_cmVisit2Enable.Name = "chk_cmVisit2Enable";
            this.chk_cmVisit2Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit2Enable.TabIndex = 5;
            this.chk_cmVisit2Enable.Text = "Enable";
            this.chk_cmVisit2Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit2Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // dtp_cmVisit2Date
            // 
            this.dtp_cmVisit2Date.Location = new System.Drawing.Point(6, 42);
            this.dtp_cmVisit2Date.Name = "dtp_cmVisit2Date";
            this.dtp_cmVisit2Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit2Date.TabIndex = 3;
            // 
            // ddl_cmVisit2Rational
            // 
            this.ddl_cmVisit2Rational.FormattingEnabled = true;
            this.ddl_cmVisit2Rational.Location = new System.Drawing.Point(6, 68);
            this.ddl_cmVisit2Rational.Name = "ddl_cmVisit2Rational";
            this.ddl_cmVisit2Rational.Size = new System.Drawing.Size(177, 21);
            this.ddl_cmVisit2Rational.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_cmVisit3Enable);
            this.groupBox3.Controls.Add(this.dtp_cmVisit3Date);
            this.groupBox3.Controls.Add(this.ddl_cmVisit3Rational);
            this.groupBox3.Location = new System.Drawing.Point(395, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visit 3";
            // 
            // chk_cmVisit3Enable
            // 
            this.chk_cmVisit3Enable.AutoSize = true;
            this.chk_cmVisit3Enable.Checked = true;
            this.chk_cmVisit3Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cmVisit3Enable.Location = new System.Drawing.Point(6, 19);
            this.chk_cmVisit3Enable.Name = "chk_cmVisit3Enable";
            this.chk_cmVisit3Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit3Enable.TabIndex = 8;
            this.chk_cmVisit3Enable.Text = "Enable";
            this.chk_cmVisit3Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit3Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // dtp_cmVisit3Date
            // 
            this.dtp_cmVisit3Date.Location = new System.Drawing.Point(6, 42);
            this.dtp_cmVisit3Date.Name = "dtp_cmVisit3Date";
            this.dtp_cmVisit3Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit3Date.TabIndex = 6;
            // 
            // ddl_cmVisit3Rational
            // 
            this.ddl_cmVisit3Rational.FormattingEnabled = true;
            this.ddl_cmVisit3Rational.Location = new System.Drawing.Point(6, 68);
            this.ddl_cmVisit3Rational.Name = "ddl_cmVisit3Rational";
            this.ddl_cmVisit3Rational.Size = new System.Drawing.Size(177, 21);
            this.ddl_cmVisit3Rational.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_cmVisit4Enable);
            this.groupBox4.Controls.Add(this.dtp_cmVisit4Date);
            this.groupBox4.Controls.Add(this.ddl_cmVisit4Rational);
            this.groupBox4.Location = new System.Drawing.Point(591, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 95);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visit 4";
            // 
            // chk_cmVisit4Enable
            // 
            this.chk_cmVisit4Enable.AutoSize = true;
            this.chk_cmVisit4Enable.Checked = true;
            this.chk_cmVisit4Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cmVisit4Enable.Location = new System.Drawing.Point(0, 19);
            this.chk_cmVisit4Enable.Name = "chk_cmVisit4Enable";
            this.chk_cmVisit4Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit4Enable.TabIndex = 11;
            this.chk_cmVisit4Enable.Text = "Enable";
            this.chk_cmVisit4Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit4Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // dtp_cmVisit4Date
            // 
            this.dtp_cmVisit4Date.Location = new System.Drawing.Point(0, 42);
            this.dtp_cmVisit4Date.Name = "dtp_cmVisit4Date";
            this.dtp_cmVisit4Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit4Date.TabIndex = 9;
            // 
            // ddl_cmVisit4Rational
            // 
            this.ddl_cmVisit4Rational.FormattingEnabled = true;
            this.ddl_cmVisit4Rational.Location = new System.Drawing.Point(0, 68);
            this.ddl_cmVisit4Rational.Name = "ddl_cmVisit4Rational";
            this.ddl_cmVisit4Rational.Size = new System.Drawing.Size(177, 21);
            this.ddl_cmVisit4Rational.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chk_cmVisit5Enable);
            this.groupBox5.Controls.Add(this.dtp_cmVisit5Date);
            this.groupBox5.Controls.Add(this.ddl_cmVisit5Rational);
            this.groupBox5.Location = new System.Drawing.Point(787, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 95);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visit 5";
            // 
            // chk_cmVisit5Enable
            // 
            this.chk_cmVisit5Enable.AutoSize = true;
            this.chk_cmVisit5Enable.Checked = true;
            this.chk_cmVisit5Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cmVisit5Enable.Location = new System.Drawing.Point(6, 19);
            this.chk_cmVisit5Enable.Name = "chk_cmVisit5Enable";
            this.chk_cmVisit5Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit5Enable.TabIndex = 14;
            this.chk_cmVisit5Enable.Text = "Enable";
            this.chk_cmVisit5Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit5Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // dtp_cmVisit5Date
            // 
            this.dtp_cmVisit5Date.Location = new System.Drawing.Point(6, 42);
            this.dtp_cmVisit5Date.Name = "dtp_cmVisit5Date";
            this.dtp_cmVisit5Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit5Date.TabIndex = 12;
            // 
            // ddl_cmVisit5Rational
            // 
            this.ddl_cmVisit5Rational.FormattingEnabled = true;
            this.ddl_cmVisit5Rational.Location = new System.Drawing.Point(6, 68);
            this.ddl_cmVisit5Rational.Name = "ddl_cmVisit5Rational";
            this.ddl_cmVisit5Rational.Size = new System.Drawing.Size(177, 21);
            this.ddl_cmVisit5Rational.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flowLayoutPanel1);
            this.groupBox6.Location = new System.Drawing.Point(12, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(996, 141);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Combination to match (CM)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDBToolStripMenuItem,
            this.openDBToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDBToolStripMenuItem
            // 
            this.newDBToolStripMenuItem.Name = "newDBToolStripMenuItem";
            this.newDBToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newDBToolStripMenuItem.Text = "New DB";
            // 
            // openDBToolStripMenuItem
            // 
            this.openDBToolStripMenuItem.Name = "openDBToolStripMenuItem";
            this.openDBToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openDBToolStripMenuItem.Text = "Open DB";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCombinationsToolStripMenuItem,
            this.getACVsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // createCombinationsToolStripMenuItem
            // 
            this.createCombinationsToolStripMenuItem.Name = "createCombinationsToolStripMenuItem";
            this.createCombinationsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createCombinationsToolStripMenuItem.Text = "Create combinations";
            // 
            // getACVsToolStripMenuItem
            // 
            this.getACVsToolStripMenuItem.Name = "getACVsToolStripMenuItem";
            this.getACVsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.getACVsToolStripMenuItem.Text = "Get ACVs";
            // 
            // btn_createCombinations
            // 
            this.btn_createCombinations.Location = new System.Drawing.Point(12, 203);
            this.btn_createCombinations.Name = "btn_createCombinations";
            this.btn_createCombinations.Size = new System.Drawing.Size(157, 23);
            this.btn_createCombinations.TabIndex = 3;
            this.btn_createCombinations.Text = "Create combinations";
            this.btn_createCombinations.UseVisualStyleBackColor = true;
            // 
            // btn_getACVs
            // 
            this.btn_getACVs.Location = new System.Drawing.Point(12, 232);
            this.btn_getACVs.Name = "btn_getACVs";
            this.btn_getACVs.Size = new System.Drawing.Size(157, 23);
            this.btn_getACVs.TabIndex = 4;
            this.btn_getACVs.Text = "Get ACVs";
            this.btn_getACVs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 414);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_createTestData
            // 
            this.btn_createTestData.Location = new System.Drawing.Point(12, 174);
            this.btn_createTestData.Name = "btn_createTestData";
            this.btn_createTestData.Size = new System.Drawing.Size(157, 23);
            this.btn_createTestData.TabIndex = 8;
            this.btn_createTestData.Text = "Create test data";
            this.btn_createTestData.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 601);
            this.Controls.Add(this.btn_createTestData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_getACVs);
            this.Controls.Add(this.btn_createCombinations);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Patient Data Matcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox ddl_cmVisit1Rational;
        private System.Windows.Forms.DateTimePicker dtp_cmVisit1Date;
        private System.Windows.Forms.CheckBox chk_cmVisit1Enable;
        private System.Windows.Forms.CheckBox chk_cmVisit2Enable;
        private System.Windows.Forms.DateTimePicker dtp_cmVisit2Date;
        private System.Windows.Forms.ComboBox ddl_cmVisit2Rational;
        private System.Windows.Forms.CheckBox chk_cmVisit3Enable;
        private System.Windows.Forms.DateTimePicker dtp_cmVisit3Date;
        private System.Windows.Forms.ComboBox ddl_cmVisit3Rational;
        private System.Windows.Forms.CheckBox chk_cmVisit4Enable;
        private System.Windows.Forms.DateTimePicker dtp_cmVisit4Date;
        private System.Windows.Forms.ComboBox ddl_cmVisit4Rational;
        private System.Windows.Forms.CheckBox chk_cmVisit5Enable;
        private System.Windows.Forms.DateTimePicker dtp_cmVisit5Date;
        private System.Windows.Forms.ComboBox ddl_cmVisit5Rational;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCombinationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getACVsToolStripMenuItem;
        private System.Windows.Forms.Button btn_createCombinations;
        private System.Windows.Forms.Button btn_getACVs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_createTestData;
    }
}