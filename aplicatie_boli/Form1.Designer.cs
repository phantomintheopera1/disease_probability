namespace aplicatie_boli
{
    partial class Form1
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
            System.Diagnostics.PerformanceCounter performanceCounter1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1_login = new System.Windows.Forms.Button();
            this.button1_register = new System.Windows.Forms.Button();
            performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(441, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISEASE PROBABILITY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1_login
            // 
            this.button1_login.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_login.Location = new System.Drawing.Point(448, 293);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(130, 56);
            this.button1_login.TabIndex = 1;
            this.button1_login.Text = "LOGIN";
            this.button1_login.UseVisualStyleBackColor = true;
            // 
            // button1_register
            // 
            this.button1_register.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_register.Location = new System.Drawing.Point(718, 293);
            this.button1_register.Name = "button1_register";
            this.button1_register.Size = new System.Drawing.Size(130, 56);
            this.button1_register.TabIndex = 2;
            this.button1_register.Text = "REGISTER";
            this.button1_register.UseVisualStyleBackColor = true;
            this.button1_register.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 673);
            this.Controls.Add(this.button1_register);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DISEASE PROBABILITY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Button button1_register;
    }
}

