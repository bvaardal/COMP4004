namespace PatientData.GUI
{
    partial class GenerateTestData
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
            this.num_matchingPatients = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_matchingVisits = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_randomVisits = new System.Windows.Forms.NumericUpDown();
            this.num_randomPatients = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_matchingPatients)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_matchingVisits)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_randomVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_randomPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // num_matchingPatients
            // 
            this.num_matchingPatients.Location = new System.Drawing.Point(57, 19);
            this.num_matchingPatients.Name = "num_matchingPatients";
            this.num_matchingPatients.Size = new System.Drawing.Size(53, 20);
            this.num_matchingPatients.TabIndex = 1;
            this.num_matchingPatients.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_matchingVisits);
            this.groupBox1.Controls.Add(this.num_matchingPatients);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matching";
            // 
            // num_matchingVisits
            // 
            this.num_matchingVisits.Location = new System.Drawing.Point(57, 45);
            this.num_matchingVisits.Name = "num_matchingVisits";
            this.num_matchingVisits.Size = new System.Drawing.Size(53, 20);
            this.num_matchingVisits.TabIndex = 2;
            this.num_matchingVisits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(94, 89);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 5;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(175, 89);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_randomVisits);
            this.groupBox2.Controls.Add(this.num_randomPatients);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(134, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random";
            // 
            // num_randomVisits
            // 
            this.num_randomVisits.Location = new System.Drawing.Point(57, 45);
            this.num_randomVisits.Name = "num_randomVisits";
            this.num_randomVisits.Size = new System.Drawing.Size(53, 20);
            this.num_randomVisits.TabIndex = 4;
            this.num_randomVisits.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // num_randomPatients
            // 
            this.num_randomPatients.Location = new System.Drawing.Point(57, 19);
            this.num_randomPatients.Name = "num_randomPatients";
            this.num_randomPatients.Size = new System.Drawing.Size(53, 20);
            this.num_randomPatients.TabIndex = 3;
            this.num_randomPatients.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patients";
            // 
            // GenerateTestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 124);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerateTestData";
            this.Text = "Test data";
            ((System.ComponentModel.ISupportInitialize)(this.num_matchingPatients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_matchingVisits)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_randomVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_randomPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_matchingPatients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_matchingVisits;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_randomVisits;
        private System.Windows.Forms.NumericUpDown num_randomPatients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}