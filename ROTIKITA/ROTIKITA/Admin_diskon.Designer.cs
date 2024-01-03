namespace ROTIKITA
{
    partial class Admin_diskon
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
            this.btn_diskon = new System.Windows.Forms.Button();
            this.btn_bundle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_diskon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.diskon_nama = new System.Windows.Forms.Label();
            this.diskon_num = new System.Windows.Forms.NumericUpDown();
            this.diskon_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diskon_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.diskon_keterangan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel_diskon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskon_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dgv_roti.GridColor = System.Drawing.Color.Black;
            this.dgv_roti.Location = new System.Drawing.Point(32, 75);
            this.dgv_roti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_roti.Name = "dgv_roti";
            this.dgv_roti.RowHeadersVisible = false;
            this.dgv_roti.RowHeadersWidth = 62;
            this.dgv_roti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_roti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_roti.Size = new System.Drawing.Size(802, 335);
            this.dgv_roti.TabIndex = 0;
            this.dgv_roti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roti_CellContentClick);
            // 
            // btn_diskon
            // 
            this.btn_diskon.BackColor = System.Drawing.Color.Black;
            this.btn_diskon.ForeColor = System.Drawing.Color.White;
            this.btn_diskon.Location = new System.Drawing.Point(32, 420);
            this.btn_diskon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_diskon.Name = "btn_diskon";
            this.btn_diskon.Size = new System.Drawing.Size(398, 54);
            this.btn_diskon.TabIndex = 2;
            this.btn_diskon.Text = "Tambah Diskon";
            this.btn_diskon.UseVisualStyleBackColor = false;
            this.btn_diskon.Click += new System.EventHandler(this.btn_diskon_Click);
            // 
            // btn_bundle
            // 
            this.btn_bundle.BackColor = System.Drawing.Color.Black;
            this.btn_bundle.ForeColor = System.Drawing.Color.White;
            this.btn_bundle.Location = new System.Drawing.Point(436, 420);
            this.btn_bundle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_bundle.Name = "btn_bundle";
            this.btn_bundle.Size = new System.Drawing.Size(398, 54);
            this.btn_bundle.TabIndex = 3;
            this.btn_bundle.Text = "Tambah Bundle";
            this.btn_bundle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_roti);
            this.groupBox1.Controls.Add(this.btn_bundle);
            this.groupBox1.Controls.Add(this.btn_diskon);
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(864, 500);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tambah";
            // 
            // dgv_diskon
            // 
            this.dgv_diskon.AllowUserToAddRows = false;
            this.dgv_diskon.AllowUserToDeleteRows = false;
            this.dgv_diskon.AllowUserToResizeColumns = false;
            this.dgv_diskon.AllowUserToResizeRows = false;
            this.dgv_diskon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diskon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_diskon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diskon.GridColor = System.Drawing.Color.Black;
            this.dgv_diskon.Location = new System.Drawing.Point(40, 649);
            this.dgv_diskon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_diskon.Name = "dgv_diskon";
            this.dgv_diskon.RowHeadersVisible = false;
            this.dgv_diskon.RowHeadersWidth = 62;
            this.dgv_diskon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_diskon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diskon.Size = new System.Drawing.Size(1456, 396);
            this.dgv_diskon.TabIndex = 1;
            this.dgv_diskon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diskon_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 609);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diskon Aktif";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(24, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ubah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(213, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // diskon_nama
            // 
            this.diskon_nama.AutoSize = true;
            this.diskon_nama.Location = new System.Drawing.Point(117, 32);
            this.diskon_nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diskon_nama.Name = "diskon_nama";
            this.diskon_nama.Size = new System.Drawing.Size(49, 20);
            this.diskon_nama.TabIndex = 6;
            this.diskon_nama.Text = "nama";
            // 
            // diskon_num
            // 
            this.diskon_num.Location = new System.Drawing.Point(122, 69);
            this.diskon_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diskon_num.Name = "diskon_num";
            this.diskon_num.Size = new System.Drawing.Size(156, 26);
            this.diskon_num.TabIndex = 7;
            this.diskon_num.ValueChanged += new System.EventHandler(this.diskon_num_ValueChanged);
            // 
            // diskon_cb
            // 
            this.diskon_cb.FormattingEnabled = true;
            this.diskon_cb.Items.AddRange(new object[] {
            "%",
            "Rupiah"});
            this.diskon_cb.Location = new System.Drawing.Point(286, 68);
            this.diskon_cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diskon_cb.Name = "diskon_cb";
            this.diskon_cb.Size = new System.Drawing.Size(104, 28);
            this.diskon_cb.TabIndex = 8;
            this.diskon_cb.SelectedIndexChanged += new System.EventHandler(this.diskon_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Diskon";
            // 
            // diskon_date
            // 
            this.diskon_date.Location = new System.Drawing.Point(122, 115);
            this.diskon_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diskon_date.Name = "diskon_date";
            this.diskon_date.Size = new System.Drawing.Size(270, 26);
            this.diskon_date.TabIndex = 10;
            this.diskon_date.ValueChanged += new System.EventHandler(this.diskon_date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mulai";
            // 
            // diskon_keterangan
            // 
            this.diskon_keterangan.Location = new System.Drawing.Point(122, 160);
            this.diskon_keterangan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diskon_keterangan.Multiline = true;
            this.diskon_keterangan.Name = "diskon_keterangan";
            this.diskon_keterangan.Size = new System.Drawing.Size(271, 90);
            this.diskon_keterangan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Keterangan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Roti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel_diskon);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.diskon_num);
            this.groupBox2.Controls.Add(this.diskon_nama);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.diskon_cb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.diskon_keterangan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.diskon_date);
            this.groupBox2.Location = new System.Drawing.Point(1551, 640);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(411, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_cancel_diskon
            // 
            this.btn_cancel_diskon.BackColor = System.Drawing.Color.Black;
            this.btn_cancel_diskon.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_diskon.Location = new System.Drawing.Point(24, 323);
            this.btn_cancel_diskon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel_diskon.Name = "btn_cancel_diskon";
            this.btn_cancel_diskon.Size = new System.Drawing.Size(370, 54);
            this.btn_cancel_diskon.TabIndex = 6;
            this.btn_cancel_diskon.Text = "Cancel";
            this.btn_cancel_diskon.UseVisualStyleBackColor = false;
            this.btn_cancel_diskon.Click += new System.EventHandler(this.btn_cancel_diskon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1012, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bundle Aktif";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(1018, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 398);
            this.dataGridView1.TabIndex = 7;
            // 
            // Admin_diskon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(2032, 1063);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_diskon);
            this.Name = "Admin_diskon";
            this.Text = "FormDiskon";
            this.Load += new System.EventHandler(this.FormDiskon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskon_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_roti;
        private System.Windows.Forms.Button btn_diskon;
        private System.Windows.Forms.Button btn_bundle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_diskon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label diskon_nama;
        private System.Windows.Forms.NumericUpDown diskon_num;
        private System.Windows.Forms.ComboBox diskon_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker diskon_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diskon_keterangan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel_diskon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}