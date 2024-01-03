namespace ROTIKITA
{
    partial class Owner_menu
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
            this.btn_pegawai = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pegawai
            // 
            this.btn_pegawai.Location = new System.Drawing.Point(24, 41);
            this.btn_pegawai.Name = "btn_pegawai";
            this.btn_pegawai.Size = new System.Drawing.Size(159, 143);
            this.btn_pegawai.TabIndex = 0;
            this.btn_pegawai.Text = "Daftar Pegawai";
            this.btn_pegawai.UseVisualStyleBackColor = true;
            this.btn_pegawai.Click += new System.EventHandler(this.btn_pegawai_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(212, 41);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(159, 143);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(388, 41);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(159, 143);
            this.btn_history.TabIndex = 2;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // Owner_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_pegawai);
            this.Name = "Owner_menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pegawai;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_history;
    }
}