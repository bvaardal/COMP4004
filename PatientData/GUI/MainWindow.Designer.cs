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
            this.mnb_newDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnb_openDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createTestDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_match = new System.Windows.Forms.Button();
            this.lst_patients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_output = new System.Windows.Forms.ListBox();
            this.lst_visits = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createCM = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_acvSize = new System.Windows.Forms.NumericUpDown();
            this.btn_unsafePatients = new System.Windows.Forms.Button();
            this.btn_safePatients = new System.Windows.Forms.Button();
            this.btn_getACVs = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_acvSize)).BeginInit();
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
            this.chk_cmVisit4Enable.Location = new System.Drawing.Point(6, 19);
            this.chk_cmVisit4Enable.Name = "chk_cmVisit4Enable";
            this.chk_cmVisit4Enable.Size = new System.Drawing.Size(59, 17);
            this.chk_cmVisit4Enable.TabIndex = 11;
            this.chk_cmVisit4Enable.Text = "Enable";
            this.chk_cmVisit4Enable.UseVisualStyleBackColor = true;
            this.chk_cmVisit4Enable.CheckedChanged += new System.EventHandler(this.enableCMVisit);
            // 
            // dtp_cmVisit4Date
            // 
            this.dtp_cmVisit4Date.Location = new System.Drawing.Point(6, 42);
            this.dtp_cmVisit4Date.Name = "dtp_cmVisit4Date";
            this.dtp_cmVisit4Date.Size = new System.Drawing.Size(177, 20);
            this.dtp_cmVisit4Date.TabIndex = 9;
            // 
            // ddl_cmVisit4Rational
            // 
            this.ddl_cmVisit4Rational.FormattingEnabled = true;
            this.ddl_cmVisit4Rational.Location = new System.Drawing.Point(6, 68);
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnb_newDB,
            this.mnb_openDB,
            this.toolStripSeparator2,
            this.createTestDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.btn_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnb_newDB
            // 
            this.mnb_newDB.Name = "mnb_newDB";
            this.mnb_newDB.Size = new System.Drawing.Size(156, 22);
            this.mnb_newDB.Text = "New DB";
            this.mnb_newDB.Click += new System.EventHandler(this.mnb_newDB_Click);
            // 
            // mnb_openDB
            // 
            this.mnb_openDB.Name = "mnb_openDB";
            this.mnb_openDB.Size = new System.Drawing.Size(156, 22);
            this.mnb_openDB.Text = "Open DB";
            this.mnb_openDB.Click += new System.EventHandler(this.mnb_openDB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // createTestDataToolStripMenuItem
            // 
            this.createTestDataToolStripMenuItem.Name = "createTestDataToolStripMenuItem";
            this.createTestDataToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createTestDataToolStripMenuItem.Text = "Create test data";
            this.createTestDataToolStripMenuItem.Click += new System.EventHandler(this.btn_createTestData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(156, 22);
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(6, 367);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(237, 23);
            this.btn_match.TabIndex = 4;
            this.btn_match.Text = "Match CM to Selected Patient(s)";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // lst_patients
            // 
            this.lst_patients.FormattingEnabled = true;
            this.lst_patients.Location = new System.Drawing.Point(6, 32);
            this.lst_patients.Name = "lst_patients";
            this.lst_patients.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_patients.Size = new System.Drawing.Size(75, 355);
            this.lst_patients.TabIndex = 9;
            this.lst_patients.SelectedIndexChanged += new System.EventHandler(this.lst_patients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patients";
            // 
            // lst_output
            // 
            this.lst_output.FormattingEnabled = true;
            this.lst_output.HorizontalScrollbar = true;
            this.lst_output.Location = new System.Drawing.Point(6, 32);
            this.lst_output.Name = "lst_output";
            this.lst_output.Size = new System.Drawing.Size(640, 329);
            this.lst_output.TabIndex = 13;
            // 
            // lst_visits
            // 
            this.lst_visits.FormattingEnabled = true;
            this.lst_visits.HorizontalScrollbar = true;
            this.lst_visits.Location = new System.Drawing.Point(87, 32);
            this.lst_visits.Name = "lst_visits";
            this.lst_visits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_visits.Size = new System.Drawing.Size(244, 355);
            this.lst_visits.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Visits";
            // 
            // btn_createCM
            // 
            this.btn_createCM.Location = new System.Drawing.Point(256, 396);
            this.btn_createCM.Name = "btn_createCM";
            this.btn_createCM.Size = new System.Drawing.Size(75, 23);
            this.btn_createCM.TabIndex = 16;
            this.btn_createCM.Text = "Create CM";
            this.btn_createCM.UseVisualStyleBackColor = true;
            this.btn_createCM.Click += new System.EventHandler(this.btn_createCM_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lst_patients);
            this.groupBox7.Controls.Add(this.btn_createCM);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.lst_visits);
            this.groupBox7.Location = new System.Drawing.Point(12, 174);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(337, 425);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Input";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_getACVs);
            this.groupBox8.Controls.Add(this.lbl_output);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.num_acvSize);
            this.groupBox8.Controls.Add(this.btn_unsafePatients);
            this.groupBox8.Controls.Add(this.btn_safePatients);
            this.groupBox8.Controls.Add(this.lst_output);
            this.groupBox8.Controls.Add(this.btn_match);
            this.groupBox8.Location = new System.Drawing.Point(355, 174);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(653, 425);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(6, 16);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(56, 13);
            this.lbl_output.TabIndex = 17;
            this.lbl_output.Text = "(No query)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ACV Size";
            // 
            // num_acvSize
            // 
            this.num_acvSize.Location = new System.Drawing.Point(468, 399);
            this.num_acvSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_acvSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_acvSize.Name = "num_acvSize";
            this.num_acvSize.Size = new System.Drawing.Size(51, 20);
            this.num_acvSize.TabIndex = 18;
            this.num_acvSize.Tag = "ACV size";
            this.num_acvSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_unsafePatients
            // 
            this.btn_unsafePatients.Location = new System.Drawing.Point(249, 396);
            this.btn_unsafePatients.Name = "btn_unsafePatients";
            this.btn_unsafePatients.Size = new System.Drawing.Size(156, 23);
            this.btn_unsafePatients.TabIndex = 17;
            this.btn_unsafePatients.Text = "Unsafe Patients";
            this.btn_unsafePatients.UseVisualStyleBackColor = true;
            this.btn_unsafePatients.Click += new System.EventHandler(this.btn_unsafePatients_Click);
            // 
            // btn_safePatients
            // 
            this.btn_safePatients.Location = new System.Drawing.Point(87, 396);
            this.btn_safePatients.Name = "btn_safePatients";
            this.btn_safePatients.Size = new System.Drawing.Size(156, 23);
            this.btn_safePatients.TabIndex = 14;
            this.btn_safePatients.Text = "Safe Patients";
            this.btn_safePatients.UseVisualStyleBackColor = true;
            this.btn_safePatients.Click += new System.EventHandler(this.btn_safePatients_Click);
            // 
            // btn_getACVs
            // 
            this.btn_getACVs.Location = new System.Drawing.Point(6, 396);
            this.btn_getACVs.Name = "btn_getACVs";
            this.btn_getACVs.Size = new System.Drawing.Size(75, 23);
            this.btn_getACVs.TabIndex = 20;
            this.btn_getACVs.Text = "Get ACVs";
            this.btn_getACVs.UseVisualStyleBackColor = true;
            this.btn_getACVs.Click += new System.EventHandler(this.btn_getACVs_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 622);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1036, 661);
            this.MinimumSize = new System.Drawing.Size(1036, 661);
            this.Name = "MainWindow";
            this.Text = "Patient Data Matcher";
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_acvSize)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mnb_newDB;
        private System.Windows.Forms.ToolStripMenuItem mnb_openDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.ListBox lst_patients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createTestDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_output;
        private System.Windows.Forms.ListBox lst_visits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_createCM;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_acvSize;
        private System.Windows.Forms.Button btn_unsafePatients;
        private System.Windows.Forms.Button btn_safePatients;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_getACVs;
    }
}