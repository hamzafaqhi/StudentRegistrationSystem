namespace StudentRegistrationSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelslide = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.coursesassignbtn = new System.Windows.Forms.Button();
            this.coursesbtn = new System.Windows.Forms.Button();
            this.classbtn = new System.Windows.Forms.Button();
            this.btn_teach_reg = new System.Windows.Forms.Button();
            this.btn_std_reg = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelslide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.coursesassignbtn);
            this.panel2.Controls.Add(this.coursesbtn);
            this.panel2.Controls.Add(this.classbtn);
            this.panel2.Controls.Add(this.btn_teach_reg);
            this.panel2.Controls.Add(this.btn_std_reg);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 631);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelslide.Controls.Add(this.label8);
            this.panelslide.Controls.Add(this.label7);
            this.panelslide.Controls.Add(this.label6);
            this.panelslide.Controls.Add(this.label5);
            this.panelslide.Controls.Add(this.label4);
            this.panelslide.Controls.Add(this.label3);
            this.panelslide.Controls.Add(this.label2);
            this.panelslide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelslide.Location = new System.Drawing.Point(74, 75);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(388, 631);
            this.panelslide.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAHRIA UNIVERSITY KARACHI CAMPUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "REGISTER STUDENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "REGISTER TEACHERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "REGISTER CLASS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "REGISTER COURSES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "ASSIGN COURSES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "LOG OUT";
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp3;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(-1, 575);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 56);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // coursesassignbtn
            // 
            this.coursesassignbtn.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp_net_resizeimage__7_;
            this.coursesassignbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coursesassignbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursesassignbtn.Location = new System.Drawing.Point(-1, 455);
            this.coursesassignbtn.Name = "coursesassignbtn";
            this.coursesassignbtn.Size = new System.Drawing.Size(74, 56);
            this.coursesassignbtn.TabIndex = 4;
            this.coursesassignbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coursesassignbtn.UseVisualStyleBackColor = true;
            this.coursesassignbtn.Click += new System.EventHandler(this.coursesassignbtn_Click);
            // 
            // coursesbtn
            // 
            this.coursesbtn.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp_net_resizeimage__6_;
            this.coursesbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coursesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursesbtn.Location = new System.Drawing.Point(-1, 376);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(74, 56);
            this.coursesbtn.TabIndex = 3;
            this.coursesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.Click += new System.EventHandler(this.coursesbtn_Click);
            // 
            // classbtn
            // 
            this.classbtn.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp_net_resizeimage__5_;
            this.classbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classbtn.Location = new System.Drawing.Point(0, 298);
            this.classbtn.Name = "classbtn";
            this.classbtn.Size = new System.Drawing.Size(74, 56);
            this.classbtn.TabIndex = 2;
            this.classbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classbtn.UseVisualStyleBackColor = true;
            // 
            // btn_teach_reg
            // 
            this.btn_teach_reg.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp_net_resizeimage__4_;
            this.btn_teach_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teach_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teach_reg.Location = new System.Drawing.Point(0, 219);
            this.btn_teach_reg.Name = "btn_teach_reg";
            this.btn_teach_reg.Size = new System.Drawing.Size(75, 54);
            this.btn_teach_reg.TabIndex = 1;
            this.btn_teach_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teach_reg.UseVisualStyleBackColor = true;
            this.btn_teach_reg.Click += new System.EventHandler(this.btn_teach_reg_Click);
            // 
            // btn_std_reg
            // 
            this.btn_std_reg.BackgroundImage = global::StudentRegistrationSystem.Properties.Resources.Webp_net_resizeimage__3_;
            this.btn_std_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_std_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_std_reg.Location = new System.Drawing.Point(0, 136);
            this.btn_std_reg.Name = "btn_std_reg";
            this.btn_std_reg.Size = new System.Drawing.Size(74, 56);
            this.btn_std_reg.TabIndex = 0;
            this.btn_std_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_std_reg.UseVisualStyleBackColor = true;
            this.btn_std_reg.Click += new System.EventHandler(this.btn_std_reg_Click);
            // 
            // menu
            // 
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = global::StudentRegistrationSystem.Properties.Resources.Webp1;
            this.menu.Location = new System.Drawing.Point(-1, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 67);
            this.menu.TabIndex = 0;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentRegistrationSystem.Properties.Resources.bahria;
            this.pictureBox1.Location = new System.Drawing.Point(454, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(843, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentRegistrationSystem.Properties.Resources.Webp4;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 706);
            this.Controls.Add(this.panelslide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelslide.ResumeLayout(false);
            this.panelslide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_std_reg;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_teach_reg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Button classbtn;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button coursesassignbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

