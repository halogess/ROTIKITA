namespace ROTIKITA
{
    partial class Admin_bundle
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
            this.label2 = new System.Windows.Forms.Label();
            this.total_item = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.potongan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.harga_bundle = new System.Windows.Forms.NumericUpDown();
            this.keterangan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kode_bundle = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.harga_bundle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Rp";
            // 
            // total_item
            // 
            this.total_item.AutoSize = true;
            this.total_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_item.Location = new System.Drawing.Point(426, 323);
            this.total_item.Name = "total_item";
            this.total_item.Size = new System.Drawing.Size(14, 16);
            this.total_item.TabIndex = 37;
            this.total_item.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Item : ";
            // 
            // potongan
            // 
            this.potongan.AutoSize = true;
            this.potongan.ForeColor = System.Drawing.Color.Red;
            this.potongan.Location = new System.Drawing.Point(160, 248);
            this.potongan.Name = "potongan";
            this.potongan.Size = new System.Drawing.Size(13, 13);
            this.potongan.TabIndex = 35;
            this.potongan.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(133, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Rp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(37, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Potongan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Harga Bundle";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(40, 300);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(301, 38);
            this.btn_simpan.TabIndex = 31;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(721, 322);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(42, 16);
            this.total.TabIndex = 30;
            this.total.Text = "harga";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total : Rp";
            // 
            // harga_bundle
            // 
            this.harga_bundle.Location = new System.Drawing.Point(163, 217);
            this.harga_bundle.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.harga_bundle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.harga_bundle.Name = "harga_bundle";
            this.harga_bundle.Size = new System.Drawing.Size(178, 20);
            this.harga_bundle.TabIndex = 28;
            this.harga_bundle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.harga_bundle.ValueChanged += new System.EventHandler(this.harga_bundle_ValueChanged);
            // 
            // keterangan
            // 
            this.keterangan.Location = new System.Drawing.Point(136, 93);
            this.keterangan.Multiline = true;
            this.keterangan.Name = "keterangan";
            this.keterangan.Size = new System.Drawing.Size(205, 54);
            this.keterangan.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data ";
            // 
            // kode_bundle
            // 
            this.kode_bundle.AutoSize = true;
            this.kode_bundle.Location = new System.Drawing.Point(133, 61);
            this.kode_bundle.Name = "kode_bundle";
            this.kode_bundle.Size = new System.Drawing.Size(31, 13);
            this.kode_bundle.TabIndex = 24;
            this.kode_bundle.Text = "kode";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(136, 168);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(205, 20);
            this.date.TabIndex = 23;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kode ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(382, 53);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(381, 245);
            this.dgv.TabIndex = 21;
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_CellValidating);
            // 
            // Admin_bundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_item);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.potongan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.harga_bundle);
            this.Controls.Add(this.keterangan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kode_bundle);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Admin_bundle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_bundle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.harga_bundle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_item;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label potongan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown harga_bundle;
        private System.Windows.Forms.TextBox keterangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kode_bundle;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
    }

}
