namespace ROTIKITA
{
    partial class Admin_buang
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
            this.dgv_roti = new System.Windows.Forms.DataGridView();
            this.dgv_buang = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_roti
            // 
            this.dgv_roti.AllowUserToAddRows = false;
            this.dgv_roti.AllowUserToDeleteRows = false;
            this.dgv_roti.AllowUserToResizeColumns = false;
            this.dgv_roti.AllowUserToResizeRows = false;
            this.dgv_roti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_roti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_roti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roti.Location = new System.Drawing.Point(24, 90);
            this.dgv_roti.Name = "dgv_roti";
            this.dgv_roti.RowHeadersVisible = false;
            this.dgv_roti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_roti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_roti.Size = new System.Drawing.Size(779, 235);
            this.dgv_roti.TabIndex = 22;
            // 
            // dgv_buang
            // 
            this.dgv_buang.AllowUserToAddRows = false;
            this.dgv_buang.AllowUserToDeleteRows = false;
            this.dgv_buang.AllowUserToResizeColumns = false;
            this.dgv_buang.AllowUserToResizeRows = false;
            this.dgv_buang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_buang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_buang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buang.Location = new System.Drawing.Point(24, 381);
            this.dgv_buang.Name = "dgv_buang";
            this.dgv_buang.RowHeadersVisible = false;
            this.dgv_buang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_buang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buang.Size = new System.Drawing.Size(948, 201);
            this.dgv_buang.TabIndex = 23;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.LightCoral;
            this.btn_hapus.Location = new System.Drawing.Point(825, 90);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(147, 235);
            this.btn_hapus.TabIndex = 24;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Riwayat Pembuangan Roti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buang Roti Expired";
            // 
            // Admin_buang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.dgv_buang);
            this.Controls.Add(this.dgv_roti);
            this.Name = "Admin_buang";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Admin_buang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_roti;
        private System.Windows.Forms.DataGridView dgv_buang;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}