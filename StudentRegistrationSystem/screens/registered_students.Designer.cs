namespace StudentRegistrationSystem.screens
{
    partial class registered_students
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.std_dgv = new System.Windows.Forms.DataGridView();
            this.btnrgd_update = new System.Windows.Forms.Button();
            this.btnrgd_delete = new System.Windows.Forms.Button();
            this.btnrgd_back = new System.Windows.Forms.Button();
            this.btnrgd_new = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.std_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.DodgerBlue;
            this.paneltop.Controls.Add(this.label15);
            this.paneltop.Location = new System.Drawing.Point(0, 64);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1284, 58);
            this.paneltop.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(261, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(677, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "BAHRIA UNIVERSITY (KARACHI CAMPUS)";
            // 
            // std_dgv
            // 
            this.std_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.std_dgv.Location = new System.Drawing.Point(0, 128);
            this.std_dgv.Name = "std_dgv";
            this.std_dgv.Size = new System.Drawing.Size(912, 533);
            this.std_dgv.TabIndex = 32;
            this.std_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.std_dgv_CellClick);
            this.std_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.std_dgv_CellContentClick);
            // 
            // btnrgd_update
            // 
            this.btnrgd_update.Location = new System.Drawing.Point(1115, 302);
            this.btnrgd_update.Name = "btnrgd_update";
            this.btnrgd_update.Size = new System.Drawing.Size(123, 50);
            this.btnrgd_update.TabIndex = 33;
            this.btnrgd_update.Text = "Update";
            this.btnrgd_update.UseVisualStyleBackColor = true;
            this.btnrgd_update.Click += new System.EventHandler(this.btnrgd_update_Click);
            // 
            // btnrgd_delete
            // 
            this.btnrgd_delete.Location = new System.Drawing.Point(949, 413);
            this.btnrgd_delete.Name = "btnrgd_delete";
            this.btnrgd_delete.Size = new System.Drawing.Size(123, 50);
            this.btnrgd_delete.TabIndex = 34;
            this.btnrgd_delete.Text = "Delete";
            this.btnrgd_delete.UseVisualStyleBackColor = true;
            this.btnrgd_delete.Click += new System.EventHandler(this.btnrgd_delete_Click);
            // 
            // btnrgd_back
            // 
            this.btnrgd_back.Location = new System.Drawing.Point(1115, 413);
            this.btnrgd_back.Name = "btnrgd_back";
            this.btnrgd_back.Size = new System.Drawing.Size(123, 50);
            this.btnrgd_back.TabIndex = 35;
            this.btnrgd_back.Text = "Back";
            this.btnrgd_back.UseVisualStyleBackColor = true;
            this.btnrgd_back.Click += new System.EventHandler(this.btnrgd_back_Click);
            // 
            // btnrgd_new
            // 
            this.btnrgd_new.Location = new System.Drawing.Point(949, 302);
            this.btnrgd_new.Name = "btnrgd_new";
            this.btnrgd_new.Size = new System.Drawing.Size(123, 50);
            this.btnrgd_new.TabIndex = 36;
            this.btnrgd_new.Text = "New";
            this.btnrgd_new.UseVisualStyleBackColor = true;
            this.btnrgd_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // registered_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 662);
            this.Controls.Add(this.btnrgd_new);
            this.Controls.Add(this.btnrgd_back);
            this.Controls.Add(this.btnrgd_delete);
            this.Controls.Add(this.btnrgd_update);
            this.Controls.Add(this.std_dgv);
            this.Controls.Add(this.paneltop);
            this.MaximizeBox = false;
            this.Name = "registered_students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.registered_students_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.std_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView std_dgv;
        private System.Windows.Forms.Button btnrgd_update;
        private System.Windows.Forms.Button btnrgd_delete;
        private System.Windows.Forms.Button btnrgd_back;
        private System.Windows.Forms.Button btnrgd_new;
    }
}