namespace GUI_XML
{
    partial class DataManagementView
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.cbEyeColor = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCreditPoint = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtMatriculation = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnXmlSave = new System.Windows.Forms.Button();
            this.btnLoadBinary = new System.Windows.Forms.Button();
            this.btnPromoteEmployee = new System.Windows.Forms.Button();
            this.btnPromoteStudent = new System.Windows.Forms.Button();
            this.btnSaveBinary = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelForm.Controls.Add(this.btnNext);
            this.panelForm.Controls.Add(this.btnPrevious);
            this.panelForm.Controls.Add(this.cbEyeColor);
            this.panelForm.Controls.Add(this.cbGender);
            this.panelForm.Controls.Add(this.lblSalary);
            this.panelForm.Controls.Add(this.lblCreditPoint);
            this.panelForm.Controls.Add(this.txtEmployeeNumber);
            this.panelForm.Controls.Add(this.txtMatriculation);
            this.panelForm.Controls.Add(this.txtHeight);
            this.panelForm.Controls.Add(this.txtFamilyName);
            this.panelForm.Controls.Add(this.txtSurname);
            this.panelForm.Controls.Add(this.lblType);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.label9);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(16, 15);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(768, 559);
            this.panelForm.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(703, 16);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 41);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(644, 16);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(51, 41);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cbEyeColor
            // 
            this.cbEyeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEyeColor.FormattingEnabled = true;
            this.cbEyeColor.Location = new System.Drawing.Point(284, 288);
            this.cbEyeColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEyeColor.Name = "cbEyeColor";
            this.cbEyeColor.Size = new System.Drawing.Size(333, 37);
            this.cbEyeColor.TabIndex = 15;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(284, 233);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(333, 37);
            this.cbGender.TabIndex = 14;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(279, 508);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(0, 29);
            this.lblSalary.TabIndex = 19;
            // 
            // lblCreditPoint
            // 
            this.lblCreditPoint.AutoSize = true;
            this.lblCreditPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditPoint.Location = new System.Drawing.Point(279, 409);
            this.lblCreditPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditPoint.Name = "lblCreditPoint";
            this.lblCreditPoint.Size = new System.Drawing.Size(0, 29);
            this.lblCreditPoint.TabIndex = 18;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(284, 452);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(333, 34);
            this.txtEmployeeNumber.TabIndex = 17;
            // 
            // txtMatriculation
            // 
            this.txtMatriculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculation.Location = new System.Drawing.Point(284, 350);
            this.txtMatriculation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatriculation.Name = "txtMatriculation";
            this.txtMatriculation.Size = new System.Drawing.Size(333, 34);
            this.txtMatriculation.TabIndex = 16;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(284, 167);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(333, 34);
            this.txtHeight.TabIndex = 13;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyName.Location = new System.Drawing.Point(284, 107);
            this.txtFamilyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(333, 34);
            this.txtFamilyName.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(284, 64);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(333, 34);
            this.txtSurname.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(205, 16);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 29);
            this.lblType.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 458);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Employee Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Credit Points";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 508);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Matriculation Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Eye color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.Controls.Add(this.btnLoadXml);
            this.panelButtons.Controls.Add(this.btnXmlSave);
            this.panelButtons.Controls.Add(this.btnLoadBinary);
            this.panelButtons.Controls.Add(this.btnPromoteEmployee);
            this.panelButtons.Controls.Add(this.btnPromoteStudent);
            this.panelButtons.Controls.Add(this.btnSaveBinary);
            this.panelButtons.Location = new System.Drawing.Point(792, 15);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(381, 559);
            this.panelButtons.TabIndex = 1;
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.BackColor = System.Drawing.Color.Blue;
            this.btnLoadXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXml.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadXml.Location = new System.Drawing.Point(197, 81);
            this.btnLoadXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(180, 47);
            this.btnLoadXml.TabIndex = 8;
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.UseVisualStyleBackColor = false;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // btnXmlSave
            // 
            this.btnXmlSave.BackColor = System.Drawing.Color.Blue;
            this.btnXmlSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXmlSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXmlSave.Location = new System.Drawing.Point(4, 81);
            this.btnXmlSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXmlSave.Name = "btnXmlSave";
            this.btnXmlSave.Size = new System.Drawing.Size(185, 47);
            this.btnXmlSave.TabIndex = 7;
            this.btnXmlSave.Text = "Save XML";
            this.btnXmlSave.UseVisualStyleBackColor = false;
            this.btnXmlSave.Click += new System.EventHandler(this.btnXmlSave_Click);
            // 
            // btnLoadBinary
            // 
            this.btnLoadBinary.BackColor = System.Drawing.Color.Blue;
            this.btnLoadBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBinary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadBinary.Location = new System.Drawing.Point(197, 27);
            this.btnLoadBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadBinary.Name = "btnLoadBinary";
            this.btnLoadBinary.Size = new System.Drawing.Size(180, 47);
            this.btnLoadBinary.TabIndex = 6;
            this.btnLoadBinary.Text = "Load binary";
            this.btnLoadBinary.UseVisualStyleBackColor = false;
            this.btnLoadBinary.Click += new System.EventHandler(this.btnLoadBinary_Click);
            // 
            // btnPromoteEmployee
            // 
            this.btnPromoteEmployee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPromoteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromoteEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromoteEmployee.Location = new System.Drawing.Point(4, 228);
            this.btnPromoteEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromoteEmployee.Name = "btnPromoteEmployee";
            this.btnPromoteEmployee.Size = new System.Drawing.Size(373, 47);
            this.btnPromoteEmployee.TabIndex = 5;
            this.btnPromoteEmployee.Text = "Promote to Employee";
            this.btnPromoteEmployee.UseVisualStyleBackColor = false;
            this.btnPromoteEmployee.Click += new System.EventHandler(this.btnPromoteEmployee_Click);
            // 
            // btnPromoteStudent
            // 
            this.btnPromoteStudent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPromoteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromoteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromoteStudent.Location = new System.Drawing.Point(4, 162);
            this.btnPromoteStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromoteStudent.Name = "btnPromoteStudent";
            this.btnPromoteStudent.Size = new System.Drawing.Size(373, 47);
            this.btnPromoteStudent.TabIndex = 4;
            this.btnPromoteStudent.Text = "Promote to Student";
            this.btnPromoteStudent.UseVisualStyleBackColor = false;
            this.btnPromoteStudent.Click += new System.EventHandler(this.btnPromoteStudent_Click);
            // 
            // btnSaveBinary
            // 
            this.btnSaveBinary.BackColor = System.Drawing.Color.Blue;
            this.btnSaveBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBinary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveBinary.Location = new System.Drawing.Point(4, 27);
            this.btnSaveBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveBinary.Name = "btnSaveBinary";
            this.btnSaveBinary.Size = new System.Drawing.Size(185, 47);
            this.btnSaveBinary.TabIndex = 0;
            this.btnSaveBinary.Text = "Save binary";
            this.btnSaveBinary.UseVisualStyleBackColor = false;
            this.btnSaveBinary.Click += new System.EventHandler(this.btnSaveBinary_Click);
            // 
            // DataManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1189, 588);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataManagementView";
            this.Text = "DataManagementView";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox cbEyeColor;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCreditPoint;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtMatriculation;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnXmlSave;
        private System.Windows.Forms.Button btnLoadBinary;
        private System.Windows.Forms.Button btnPromoteEmployee;
        private System.Windows.Forms.Button btnPromoteStudent;
        private System.Windows.Forms.Button btnSaveBinary;
    }
}

