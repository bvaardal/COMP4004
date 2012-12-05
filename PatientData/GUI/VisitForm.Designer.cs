namespace PatientData.GUI
{
    partial class VisitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patientID = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_rational = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_hp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_ohpa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diagnosis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // txt_patientID
            // 
            this.txt_patientID.Enabled = false;
            this.txt_patientID.Location = new System.Drawing.Point(116, 12);
            this.txt_patientID.Name = "txt_patientID";
            this.txt_patientID.Size = new System.Drawing.Size(155, 20);
            this.txt_patientID.TabIndex = 2;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(116, 64);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(155, 20);
            this.dtp_date.TabIndex = 4;
            // 
            // cmb_rational
            // 
            this.cmb_rational.FormattingEnabled = true;
            this.cmb_rational.Location = new System.Drawing.Point(116, 90);
            this.cmb_rational.Name = "cmb_rational";
            this.cmb_rational.Size = new System.Drawing.Size(155, 21);
            this.cmb_rational.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rational";
            // 
            // cmb_hp
            // 
            this.cmb_hp.FormattingEnabled = true;
            this.cmb_hp.Location = new System.Drawing.Point(116, 38);
            this.cmb_hp.Name = "cmb_hp";
            this.cmb_hp.Size = new System.Drawing.Size(155, 21);
            this.cmb_hp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Health Professional";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(196, 143);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(115, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_ohpa
            // 
            this.txt_ohpa.Location = new System.Drawing.Point(115, 117);
            this.txt_ohpa.Name = "txt_ohpa";
            this.txt_ohpa.Size = new System.Drawing.Size(75, 20);
            this.txt_ohpa.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OHPA, Diagnosis";
            // 
            // txt_diagnosis
            // 
            this.txt_diagnosis.Location = new System.Drawing.Point(196, 117);
            this.txt_diagnosis.Name = "txt_diagnosis";
            this.txt_diagnosis.Size = new System.Drawing.Size(75, 20);
            this.txt_diagnosis.TabIndex = 13;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 178);
            this.Controls.Add(this.txt_diagnosis);
            this.Controls.Add(this.txt_ohpa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_hp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_rational);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_patientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VisitForm";
            this.Text = "Visit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_patientID;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cmb_rational;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_hp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_ohpa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diagnosis;
    }
}