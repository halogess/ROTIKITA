namespace ROTIKITA
{
    partial class Admin_menu
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
            this.btn_daftar = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_diskon = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_buang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_daftar
            // 
            this.btn_daftar.Location = new System.Drawing.Point(12, 70);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Size = new System.Drawing.Size(133, 120);
            this.btn_daftar.TabIndex = 0;
            this.btn_daftar.Text = "Daftar Roti";
            this.btn_daftar.UseVisualStyleBackColor = true;
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(160, 70);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(133, 120);
            this.btn_tambah.TabIndex = 1;
            this.btn_tambah.Text = "Tambah Roti";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_diskon
            // 
            this.btn_diskon.Location = new System.Drawing.Point(438, 70);
            this.btn_diskon.Name = "btn_diskon";
            this.btn_diskon.Size = new System.Drawing.Size(133, 120);
            this.btn_diskon.TabIndex = 2;
            this.btn_diskon.Text = "Diskon";
            this.btn_diskon.UseVisualStyleBackColor = true;
            this.btn_diskon.Click += new System.EventHandler(this.btn_diskon_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(577, 70);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(133, 120);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_buang
            // 
            this.btn_buang.Location = new System.Drawing.Point(299, 70);
            this.btn_buang.Name = "btn_buang";
            this.btn_buang.Size = new System.Drawing.Size(133, 120);
            this.btn_buang.TabIndex = 4;
            this.btn_buang.Text = "Buang Roti";
            this.btn_buang.UseVisualStyleBackColor = true;
            this.btn_buang.Click += new System.EventHandler(this.btn_buang_Click);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buang);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_diskon);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_daftar);
            this.Name = "Admin_menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_diskon;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_buang;
    }
}