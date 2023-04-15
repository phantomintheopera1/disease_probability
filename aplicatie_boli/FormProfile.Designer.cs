namespace aplicatie_boli
{
    partial class FormProfile
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelMedical = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonChangeUsername = new System.Windows.Forms.Button();
            this.buttonChangeFullName = new System.Windows.Forms.Button();
            this.buttonChangeBirthDate = new System.Windows.Forms.Button();
            this.buttonChangeMedicalHistory = new System.Windows.Forms.Button();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdateUsername = new System.Windows.Forms.Button();
            this.buttonUpdateName = new System.Windows.Forms.Button();
            this.maskedTextBoxNewBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonUpdateBirthDate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonUpdateMedicalHistory = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUsername.Location = new System.Drawing.Point(23, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(132, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelName.Location = new System.Drawing.Point(22, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Full name: ";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.BackColor = System.Drawing.Color.Transparent;
            this.labelBirth.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBirth.Location = new System.Drawing.Point(22, 137);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(131, 29);
            this.labelBirth.TabIndex = 2;
            this.labelBirth.Text = "Birth date: ";
            // 
            // labelMedical
            // 
            this.labelMedical.AutoSize = true;
            this.labelMedical.BackColor = System.Drawing.Color.Transparent;
            this.labelMedical.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedical.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMedical.Location = new System.Drawing.Point(23, 186);
            this.labelMedical.Name = "labelMedical";
            this.labelMedical.Size = new System.Drawing.Size(190, 29);
            this.labelMedical.TabIndex = 3;
            this.labelMedical.Text = "Medical history: ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(28, 330);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 51);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit data";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonChangeUsername
            // 
            this.buttonChangeUsername.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeUsername.Enabled = false;
            this.buttonChangeUsername.Location = new System.Drawing.Point(161, 45);
            this.buttonChangeUsername.Name = "buttonChangeUsername";
            this.buttonChangeUsername.Size = new System.Drawing.Size(101, 29);
            this.buttonChangeUsername.TabIndex = 5;
            this.buttonChangeUsername.UseVisualStyleBackColor = false;
            this.buttonChangeUsername.Visible = false;
            this.buttonChangeUsername.Click += new System.EventHandler(this.buttonChangeUsername_Click);
            // 
            // buttonChangeFullName
            // 
            this.buttonChangeFullName.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeFullName.Enabled = false;
            this.buttonChangeFullName.Location = new System.Drawing.Point(161, 92);
            this.buttonChangeFullName.Name = "buttonChangeFullName";
            this.buttonChangeFullName.Size = new System.Drawing.Size(101, 29);
            this.buttonChangeFullName.TabIndex = 6;
            this.buttonChangeFullName.UseVisualStyleBackColor = false;
            this.buttonChangeFullName.Visible = false;
            this.buttonChangeFullName.Click += new System.EventHandler(this.buttonChangeFullName_Click);
            // 
            // buttonChangeBirthDate
            // 
            this.buttonChangeBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeBirthDate.Enabled = false;
            this.buttonChangeBirthDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonChangeBirthDate.Location = new System.Drawing.Point(161, 137);
            this.buttonChangeBirthDate.Name = "buttonChangeBirthDate";
            this.buttonChangeBirthDate.Size = new System.Drawing.Size(101, 29);
            this.buttonChangeBirthDate.TabIndex = 7;
            this.buttonChangeBirthDate.UseVisualStyleBackColor = false;
            this.buttonChangeBirthDate.Visible = false;
            this.buttonChangeBirthDate.Click += new System.EventHandler(this.buttonChangeBirthDate_Click);
            // 
            // buttonChangeMedicalHistory
            // 
            this.buttonChangeMedicalHistory.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeMedicalHistory.Enabled = false;
            this.buttonChangeMedicalHistory.Location = new System.Drawing.Point(208, 186);
            this.buttonChangeMedicalHistory.Name = "buttonChangeMedicalHistory";
            this.buttonChangeMedicalHistory.Size = new System.Drawing.Size(101, 29);
            this.buttonChangeMedicalHistory.TabIndex = 8;
            this.buttonChangeMedicalHistory.UseVisualStyleBackColor = false;
            this.buttonChangeMedicalHistory.Visible = false;
            this.buttonChangeMedicalHistory.Click += new System.EventHandler(this.buttonChangeMedicalHistory_Click);
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewHistory.Location = new System.Drawing.Point(292, 326);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(174, 59);
            this.buttonViewHistory.TabIndex = 9;
            this.buttonViewHistory.Text = "View history of probabilities";
            this.buttonViewHistory.UseVisualStyleBackColor = true;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(635, 326);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 59);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start application";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewUsername.Location = new System.Drawing.Point(302, 45);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(164, 29);
            this.textBoxNewUsername.TabIndex = 11;
            this.textBoxNewUsername.Visible = false;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(440, 89);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(164, 29);
            this.textBoxNewName.TabIndex = 12;
            this.textBoxNewName.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First name",
            "Last name",
            "Both"});
            this.comboBox1.Location = new System.Drawing.Point(302, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonUpdateUsername
            // 
            this.buttonUpdateUsername.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUsername.Location = new System.Drawing.Point(488, 44);
            this.buttonUpdateUsername.Name = "buttonUpdateUsername";
            this.buttonUpdateUsername.Size = new System.Drawing.Size(192, 29);
            this.buttonUpdateUsername.TabIndex = 16;
            this.buttonUpdateUsername.Text = "Update username";
            this.buttonUpdateUsername.UseVisualStyleBackColor = true;
            this.buttonUpdateUsername.Visible = false;
            this.buttonUpdateUsername.Click += new System.EventHandler(this.buttonUpdateUsername_Click);
            // 
            // buttonUpdateName
            // 
            this.buttonUpdateName.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateName.Location = new System.Drawing.Point(611, 89);
            this.buttonUpdateName.Name = "buttonUpdateName";
            this.buttonUpdateName.Size = new System.Drawing.Size(164, 32);
            this.buttonUpdateName.TabIndex = 17;
            this.buttonUpdateName.Text = "Update name";
            this.buttonUpdateName.UseVisualStyleBackColor = true;
            this.buttonUpdateName.Visible = false;
            this.buttonUpdateName.Click += new System.EventHandler(this.buttonUpdateName_Click);
            // 
            // maskedTextBoxNewBirthDate
            // 
            this.maskedTextBoxNewBirthDate.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNewBirthDate.Location = new System.Drawing.Point(302, 137);
            this.maskedTextBoxNewBirthDate.Mask = "00/00/0000";
            this.maskedTextBoxNewBirthDate.Name = "maskedTextBoxNewBirthDate";
            this.maskedTextBoxNewBirthDate.Size = new System.Drawing.Size(101, 29);
            this.maskedTextBoxNewBirthDate.TabIndex = 18;
            this.maskedTextBoxNewBirthDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxNewBirthDate.Visible = false;
            // 
            // buttonUpdateBirthDate
            // 
            this.buttonUpdateBirthDate.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateBirthDate.Location = new System.Drawing.Point(427, 137);
            this.buttonUpdateBirthDate.Name = "buttonUpdateBirthDate";
            this.buttonUpdateBirthDate.Size = new System.Drawing.Size(164, 32);
            this.buttonUpdateBirthDate.TabIndex = 19;
            this.buttonUpdateBirthDate.Text = "Update birth date";
            this.buttonUpdateBirthDate.UseVisualStyleBackColor = true;
            this.buttonUpdateBirthDate.Visible = false;
            this.buttonUpdateBirthDate.Click += new System.EventHandler(this.buttonUpdateBirthDate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(349, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 96);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // buttonUpdateMedicalHistory
            // 
            this.buttonUpdateMedicalHistory.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMedicalHistory.Location = new System.Drawing.Point(624, 216);
            this.buttonUpdateMedicalHistory.Name = "buttonUpdateMedicalHistory";
            this.buttonUpdateMedicalHistory.Size = new System.Drawing.Size(164, 57);
            this.buttonUpdateMedicalHistory.TabIndex = 21;
            this.buttonUpdateMedicalHistory.Text = "Update medical history";
            this.buttonUpdateMedicalHistory.UseVisualStyleBackColor = true;
            this.buttonUpdateMedicalHistory.Visible = false;
            this.buttonUpdateMedicalHistory.Click += new System.EventHandler(this.buttonUpdateMedicalHistory_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(472, 288);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(146, 42);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(696, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Close app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::aplicatie_boli.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdateMedicalHistory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonUpdateBirthDate);
            this.Controls.Add(this.maskedTextBoxNewBirthDate);
            this.Controls.Add(this.buttonUpdateName);
            this.Controls.Add(this.buttonUpdateUsername);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonViewHistory);
            this.Controls.Add(this.buttonChangeMedicalHistory);
            this.Controls.Add(this.buttonChangeBirthDate);
            this.Controls.Add(this.buttonChangeFullName);
            this.Controls.Add(this.buttonChangeUsername);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelMedical);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelMedical;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonChangeUsername;
        private System.Windows.Forms.Button buttonChangeFullName;
        private System.Windows.Forms.Button buttonChangeBirthDate;
        private System.Windows.Forms.Button buttonChangeMedicalHistory;
        private System.Windows.Forms.Button buttonViewHistory;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUpdateUsername;
        private System.Windows.Forms.Button buttonUpdateName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNewBirthDate;
        private System.Windows.Forms.Button buttonUpdateBirthDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonUpdateMedicalHistory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
    }
}