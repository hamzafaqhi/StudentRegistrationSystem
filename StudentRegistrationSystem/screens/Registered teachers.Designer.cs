namespace StudentRegistrationSystem.screens
{
    partial class Registered_teachers
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
            this.tchdata = new System.Windows.Forms.DataGridView();
            this.paneltop = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btntch_new = new System.Windows.Forms.Button();
            this.btntch_back = new System.Windows.Forms.Button();
            this.btntch_delete = new System.Windows.Forms.Button();
            this.btntc_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tchdata)).BeginInit();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tchdata
            // 
            this.tchdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tchdata.Location = new System.Drawing.Point(-1, 128);
            this.tchdata.Name = "tchdata";
            this.tchdata.Size = new System.Drawing.Size(912, 533);
            this.tchdata.TabIndex = 33;
            this.tchdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.tchdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.DodgerBlue;
            this.paneltop.Controls.Add(this.label15);
            this.paneltop.Location = new System.Drawing.Point(-1, 64);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1286, 58);
            this.paneltop.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(294, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(677, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "BAHRIA UNIVERSITY (KARACHI CAMPUS)";
            // 
            // btntch_new
            // 
            this.btntch_new.Location = new System.Drawing.Point(951, 281);
            this.btntch_new.Name = "btntch_new";
            this.btntch_new.Size = new System.Drawing.Size(123, 50);
            this.btntch_new.TabIndex = 40;
            this.btntch_new.Text = "New";
            this.btntch_new.UseVisualStyleBackColor = true;
            this.btntch_new.Click += new System.EventHandler(this.btntch_new_Click);
            // 
            // btntch_back
            // 
            this.btntch_back.Location = new System.Drawing.Point(1117, 476);
            this.btntch_back.Name = "btntch_back";
            this.btntch_back.Size = new System.Drawing.Size(123, 50);
            this.btntch_back.TabIndex = 39;
            this.btntch_back.Text = "Back";
            this.btntch_back.UseVisualStyleBackColor = true;
            this.btntch_back.Click += new System.EventHandler(this.btntch_back_Click);
            // 
            // btntch_delete
            // 
            this.btntch_delete.Location = new System.Drawing.Point(951, 476);
            this.btntch_delete.Name = "btntch_delete";
            this.btntch_delete.Size = new System.Drawing.Size(123, 50);
            this.btntch_delete.TabIndex = 38;
            this.btntch_delete.Text = "Delete";
            this.btntch_delete.UseVisualStyleBackColor = true;
            this.btntch_delete.Click += new System.EventHandler(this.btntch_delete_Click);
            // 
            // btntc_update
            // 
            this.btntc_update.Location = new System.Drawing.Point(1117, 281);
            this.btntc_update.Name = "btntc_update";
            this.btntc_update.Size = new System.Drawing.Size(123, 50);
            this.btntc_update.TabIndex = 37;
            this.btntc_update.Text = "Update";
            this.btntc_update.UseVisualStyleBackColor = true;
            this.btntc_update.Click += new System.EventHandler(this.Clear);
            // 
            // Registered_teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 662);
            this.Controls.Add(this.btntch_new);
            this.Controls.Add(this.btntch_back);
            this.Controls.Add(this.btntch_delete);
            this.Controls.Add(this.btntc_update);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.tchdata);
            this.Name = "Registered_teachers";
            this.Load += new System.EventHandler(this.Registered_teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tchdata)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tchdata;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btntch_new;
        private System.Windows.Forms.Button btntch_back;
        private System.Windows.Forms.Button btntch_delete;
        private System.Windows.Forms.Button btntc_update;
    }
}