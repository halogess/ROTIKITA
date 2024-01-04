namespace ROTIKITA
{
    partial class Kasir_menu
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
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.Location = new System.Drawing.Point(84, 76);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Size = new System.Drawing.Size(187, 135);
            this.btn_transaksi.TabIndex = 0;
            this.btn_transaksi.Text = "Transaksi";
            this.btn_transaksi.UseVisualStyleBackColor = true;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(301, 76);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(197, 135);
            this.btn_history.TabIndex = 1;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // Kasir_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_transaksi);
            this.Name = "Kasir_menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kasir_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Button btn_history;
    }
}