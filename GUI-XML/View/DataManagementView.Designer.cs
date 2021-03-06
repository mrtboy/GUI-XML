﻿namespace GUI_XML
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
            this.btnSortByGivenName = new System.Windows.Forms.Button();
            this.btnSortBySurName = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnCreateNewPerson = new System.Windows.Forms.Button();
            this.btnSaveNewPerson = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnXmlSave = new System.Windows.Forms.Button();
            this.btnLoadBinary = new System.Windows.Forms.Button();
            this.btnPromoteEmployee = new System.Windows.Forms.Button();
            this.btnPromoteStudent = new System.Windows.Forms.Button();
            this.btnSaveBinary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTallestPerson = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHeightAverage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCountOfBrownEyes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCountOfWoman = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCountOfMale = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelForm.Location = new System.Drawing.Point(12, 12);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(576, 454);
            this.panelForm.TabIndex = 0;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(527, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 33);
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
            this.btnPrevious.Location = new System.Drawing.Point(483, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 33);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cbEyeColor
            // 
            this.cbEyeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEyeColor.FormattingEnabled = true;
            this.cbEyeColor.Location = new System.Drawing.Point(213, 234);
            this.cbEyeColor.Name = "cbEyeColor";
            this.cbEyeColor.Size = new System.Drawing.Size(251, 32);
            this.cbEyeColor.TabIndex = 15;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(213, 189);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(251, 32);
            this.cbGender.TabIndex = 14;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(209, 413);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(0, 24);
            this.lblSalary.TabIndex = 19;
            // 
            // lblCreditPoint
            // 
            this.lblCreditPoint.AutoSize = true;
            this.lblCreditPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditPoint.Location = new System.Drawing.Point(209, 332);
            this.lblCreditPoint.Name = "lblCreditPoint";
            this.lblCreditPoint.Size = new System.Drawing.Size(0, 24);
            this.lblCreditPoint.TabIndex = 18;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(213, 367);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(251, 29);
            this.txtEmployeeNumber.TabIndex = 17;
            // 
            // txtMatriculation
            // 
            this.txtMatriculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculation.Location = new System.Drawing.Point(213, 284);
            this.txtMatriculation.Name = "txtMatriculation";
            this.txtMatriculation.Size = new System.Drawing.Size(251, 29);
            this.txtMatriculation.TabIndex = 16;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(213, 136);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(251, 29);
            this.txtHeight.TabIndex = 13;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyName.Location = new System.Drawing.Point(213, 87);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(251, 29);
            this.txtFamilyName.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(213, 52);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(251, 29);
            this.txtSurname.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(154, 13);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 24);
            this.lblType.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Employee Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Credit Points";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Matriculation Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Eye color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.Controls.Add(this.btnSortByGivenName);
            this.panelButtons.Controls.Add(this.btnSortBySurName);
            this.panelButtons.Controls.Add(this.btnDeleteUser);
            this.panelButtons.Controls.Add(this.btnCreateNewPerson);
            this.panelButtons.Controls.Add(this.btnSaveNewPerson);
            this.panelButtons.Controls.Add(this.btnLoadXml);
            this.panelButtons.Controls.Add(this.btnXmlSave);
            this.panelButtons.Controls.Add(this.btnLoadBinary);
            this.panelButtons.Controls.Add(this.btnPromoteEmployee);
            this.panelButtons.Controls.Add(this.btnPromoteStudent);
            this.panelButtons.Controls.Add(this.btnSaveBinary);
            this.panelButtons.Location = new System.Drawing.Point(594, 12);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(286, 454);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSortByGivenName
            // 
            this.btnSortByGivenName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSortByGivenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByGivenName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSortByGivenName.Location = new System.Drawing.Point(3, 296);
            this.btnSortByGivenName.Name = "btnSortByGivenName";
            this.btnSortByGivenName.Size = new System.Drawing.Size(280, 38);
            this.btnSortByGivenName.TabIndex = 13;
            this.btnSortByGivenName.Text = "Sort by Given Name";
            this.btnSortByGivenName.UseVisualStyleBackColor = false;
            this.btnSortByGivenName.Click += new System.EventHandler(this.btnSortByGivenName_Click);
            // 
            // btnSortBySurName
            // 
            this.btnSortBySurName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSortBySurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortBySurName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSortBySurName.Location = new System.Drawing.Point(3, 243);
            this.btnSortBySurName.Name = "btnSortBySurName";
            this.btnSortBySurName.Size = new System.Drawing.Size(280, 38);
            this.btnSortBySurName.TabIndex = 12;
            this.btnSortBySurName.Text = "Sort by SurName";
            this.btnSortBySurName.UseVisualStyleBackColor = false;
            this.btnSortBySurName.Click += new System.EventHandler(this.btnSortBySurName_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteUser.Location = new System.Drawing.Point(173, 367);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnCreateNewPerson
            // 
            this.btnCreateNewPerson.BackColor = System.Drawing.Color.Blue;
            this.btnCreateNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewPerson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateNewPerson.Location = new System.Drawing.Point(42, 367);
            this.btnCreateNewPerson.Name = "btnCreateNewPerson";
            this.btnCreateNewPerson.Size = new System.Drawing.Size(100, 50);
            this.btnCreateNewPerson.TabIndex = 10;
            this.btnCreateNewPerson.Text = "Add New Person";
            this.btnCreateNewPerson.UseVisualStyleBackColor = false;
            this.btnCreateNewPerson.Click += new System.EventHandler(this.btnCreateNewPerson_Click);
            // 
            // btnSaveNewPerson
            // 
            this.btnSaveNewPerson.BackColor = System.Drawing.Color.Blue;
            this.btnSaveNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewPerson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveNewPerson.Location = new System.Drawing.Point(42, 367);
            this.btnSaveNewPerson.Name = "btnSaveNewPerson";
            this.btnSaveNewPerson.Size = new System.Drawing.Size(100, 50);
            this.btnSaveNewPerson.TabIndex = 9;
            this.btnSaveNewPerson.Text = "Save";
            this.btnSaveNewPerson.UseVisualStyleBackColor = false;
            this.btnSaveNewPerson.Click += new System.EventHandler(this.btnSaveNewPerson_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.BackColor = System.Drawing.Color.Blue;
            this.btnLoadXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXml.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadXml.Location = new System.Drawing.Point(148, 66);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(135, 38);
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
            this.btnXmlSave.Location = new System.Drawing.Point(3, 66);
            this.btnXmlSave.Name = "btnXmlSave";
            this.btnXmlSave.Size = new System.Drawing.Size(139, 38);
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
            this.btnLoadBinary.Location = new System.Drawing.Point(148, 22);
            this.btnLoadBinary.Name = "btnLoadBinary";
            this.btnLoadBinary.Size = new System.Drawing.Size(135, 38);
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
            this.btnPromoteEmployee.Location = new System.Drawing.Point(3, 185);
            this.btnPromoteEmployee.Name = "btnPromoteEmployee";
            this.btnPromoteEmployee.Size = new System.Drawing.Size(280, 38);
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
            this.btnPromoteStudent.Location = new System.Drawing.Point(3, 132);
            this.btnPromoteStudent.Name = "btnPromoteStudent";
            this.btnPromoteStudent.Size = new System.Drawing.Size(280, 38);
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
            this.btnSaveBinary.Location = new System.Drawing.Point(3, 22);
            this.btnSaveBinary.Name = "btnSaveBinary";
            this.btnSaveBinary.Size = new System.Drawing.Size(139, 38);
            this.btnSaveBinary.TabIndex = 0;
            this.btnSaveBinary.Text = "Save binary";
            this.btnSaveBinary.UseVisualStyleBackColor = false;
            this.btnSaveBinary.Click += new System.EventHandler(this.btnSaveBinary_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTallestPerson);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblHeightAverage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblCountOfBrownEyes);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblCountOfWoman);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblCountOfMale);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 161);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTallestPerson
            // 
            this.lblTallestPerson.AutoSize = true;
            this.lblTallestPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallestPerson.Location = new System.Drawing.Point(176, 126);
            this.lblTallestPerson.Name = "lblTallestPerson";
            this.lblTallestPerson.Size = new System.Drawing.Size(0, 16);
            this.lblTallestPerson.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tallest Person";
            // 
            // lblHeightAverage
            // 
            this.lblHeightAverage.AutoSize = true;
            this.lblHeightAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightAverage.Location = new System.Drawing.Point(176, 98);
            this.lblHeightAverage.Name = "lblHeightAverage";
            this.lblHeightAverage.Size = new System.Drawing.Size(0, 16);
            this.lblHeightAverage.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Height average:";
            // 
            // lblCountOfBrownEyes
            // 
            this.lblCountOfBrownEyes.AutoSize = true;
            this.lblCountOfBrownEyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOfBrownEyes.Location = new System.Drawing.Point(174, 67);
            this.lblCountOfBrownEyes.Name = "lblCountOfBrownEyes";
            this.lblCountOfBrownEyes.Size = new System.Drawing.Size(0, 16);
            this.lblCountOfBrownEyes.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Count of Brown Eyes:";
            // 
            // lblCountOfWoman
            // 
            this.lblCountOfWoman.AutoSize = true;
            this.lblCountOfWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOfWoman.Location = new System.Drawing.Point(143, 40);
            this.lblCountOfWoman.Name = "lblCountOfWoman";
            this.lblCountOfWoman.Size = new System.Drawing.Size(0, 16);
            this.lblCountOfWoman.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Count of woman:";
            // 
            // lblCountOfMale
            // 
            this.lblCountOfMale.AutoSize = true;
            this.lblCountOfMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOfMale.Location = new System.Drawing.Point(143, 17);
            this.lblCountOfMale.Name = "lblCountOfMale";
            this.lblCountOfMale.Size = new System.Drawing.Size(0, 16);
            this.lblCountOfMale.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Count of males:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Blue;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilter.Location = new System.Drawing.Point(597, 639);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 38);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 639);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 171);
            this.dataGridView1.TabIndex = 13;
            // 
            // DataManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 822);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelForm);
            this.Name = "DataManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManagementView";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnSaveNewPerson;
        private System.Windows.Forms.Button btnCreateNewPerson;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCountOfWoman;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCountOfMale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCountOfBrownEyes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHeightAverage;
        private System.Windows.Forms.Label lblTallestPerson;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSortByGivenName;
        private System.Windows.Forms.Button btnSortBySurName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

