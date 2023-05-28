namespace aplicatie_boli
{
    partial class Form2_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_username = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.button2_login = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(161, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(165, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox2_username
            // 
            this.textBox2_username.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_username.Location = new System.Drawing.Point(269, 99);
            this.textBox2_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_username.Name = "textBox2_username";
            this.textBox2_username.Size = new System.Drawing.Size(270, 24);
            this.textBox2_username.TabIndex = 2;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_password.Location = new System.Drawing.Point(269, 132);
            this.textBox2_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(270, 24);
            this.textBox2_password.TabIndex = 3;
            // 
            // button2_login
            // 
            this.button2_login.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2_login.Location = new System.Drawing.Point(334, 205);
            this.button2_login.Margin = new System.Windows.Forms.Padding(2);
            this.button2_login.Name = "button2_login";
            this.button2_login.Size = new System.Drawing.Size(97, 42);
            this.button2_login.TabIndex = 4;
            this.button2_login.Text = "LOGIN";
            this.button2_login.UseVisualStyleBackColor = true;
            this.button2_login.Click += new System.EventHandler(this.button2_login_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelLogin.Location = new System.Drawing.Point(269, 32);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(82, 25);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "LOGIN";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(569, 385);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(98, 37);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "CANCEL";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form2_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 469);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.button2_login);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox2_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2_login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form2_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_username;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Button button2_login;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonClose;
    }
}