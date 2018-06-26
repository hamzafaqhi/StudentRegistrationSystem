namespace StudentRegistrationSystem.screens
{
    partial class AssignCourses
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
            this.cmb_crs = new System.Windows.Forms.ComboBox();
            this.cmb_tch = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.asgn_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asgn_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_crs
            // 
            this.cmb_crs.FormattingEnabled = true;
            this.cmb_crs.Location = new System.Drawing.Point(241, 105);
            this.cmb_crs.Name = "cmb_crs";
            this.cmb_crs.Size = new System.Drawing.Size(222, 21);
            this.cmb_crs.TabIndex = 0;
            // 
            // cmb_tch
            // 
            this.cmb_tch.FormattingEnabled = true;
            this.cmb_tch.Location = new System.Drawing.Point(241, 167);
            this.cmb_tch.Name = "cmb_tch";
            this.cmb_tch.Size = new System.Drawing.Size(222, 21);
            this.cmb_tch.TabIndex = 1;
            // 
            // cmb_class
            // 
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(241, 226);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(222, 21);
            this.cmb_class.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teacher name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class name:";
            // 
            // asgn_dgv
            // 
            this.asgn_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asgn_dgv.Location = new System.Drawing.Point(6, 273);
            this.asgn_dgv.Name = "asgn_dgv";
            this.asgn_dgv.Size = new System.Drawing.Size(683, 115);
            this.asgn_dgv.TabIndex = 6;
            this.asgn_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asgn_dgv_CellClick);
            this.asgn_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asgn_dgv_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AssignCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 435);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.asgn_dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_class);
            this.Controls.Add(this.cmb_tch);
            this.Controls.Add(this.cmb_crs);
            this.MaximizeBox = false;
            this.Name = "AssignCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignCourses";
            this.Load += new System.EventHandler(this.AssignCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asgn_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_crs;
        private System.Windows.Forms.ComboBox cmb_tch;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView asgn_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}