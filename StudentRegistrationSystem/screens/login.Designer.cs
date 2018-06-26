namespace StudentRegistrationSystem.screens
{
    partial class login
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
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.signinbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(176, 134);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(277, 20);
            this.usernametext.TabIndex = 2;
            this.usernametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernametext.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(176, 200);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(277, 20);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.signinbtn.ForeColor = System.Drawing.Color.White;
            this.signinbtn.Location = new System.Drawing.Point(238, 258);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(75, 66);
            this.signinbtn.TabIndex = 4;
            this.signinbtn.Text = "Sign in";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(331, 258);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 66);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentRegistrationSystem.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 49);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}