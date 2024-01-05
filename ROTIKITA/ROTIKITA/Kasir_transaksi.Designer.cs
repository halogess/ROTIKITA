namespace ROTIKITA
{
    partial class Kasir_transaksi
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
            this.nama_roti_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRotiGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.kodeRotiLabel = new System.Windows.Forms.Label();
            this.namaJenisRoti = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tanggalExpiredLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.hargaLabel = new System.Windows.Forms.Label();
            this.qtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.keranjangDataGridView = new System.Windows.Forms.DataGridView();
            this.KodeRoti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.jumlahItemLabel = new System.Windows.Forms.Label();
            this.totalHargaLabel = new System.Windows.Forms.Label();
            this.butButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.diskonDataGridView = new System.Windows.Forms.DataGridView();
            this.KodeRoti_Diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaRoti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potongan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listRotiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nama_roti_label
            // 
            this.nama_roti_label.AutoSize = true;
            this.nama_roti_label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_roti_label.Location = new System.Drawing.Point(69, 408);
            this.nama_roti_label.Name = "nama_roti_label";
            this.nama_roti_label.Size = new System.Drawing.Size(195, 36);
            this.nama_roti_label.TabIndex = 7;
            this.nama_roti_label.Text = "NAMAROTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kode Roti";
            // 
            // listRotiGridView
            // 
            this.listRotiGridView.AllowUserToAddRows = false;
            this.listRotiGridView.AllowUserToDeleteRows = false;
            this.listRotiGridView.AllowUserToResizeColumns = false;
            this.listRotiGridView.AllowUserToResizeRows = false;
            this.listRotiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listRotiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRotiGridView.GridColor = System.Drawing.Color.Black;
            this.listRotiGridView.Location = new System.Drawing.Point(75, 81);
            this.listRotiGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRotiGridView.Name = "listRotiGridView";
            this.listRotiGridView.ReadOnly = true;
            this.listRotiGridView.RowHeadersVisible = false;
            this.listRotiGridView.RowHeadersWidth = 51;
            this.listRotiGridView.RowTemplate.Height = 24;
            this.listRotiGridView.Size = new System.Drawing.Size(577, 291);
            this.listRotiGridView.TabIndex = 17;
            this.listRotiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listRotiGridView_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "DAFTAR ROTI";
            // 
            // kodeRotiLabel
            // 
            this.kodeRotiLabel.AutoSize = true;
            this.kodeRotiLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeRotiLabel.Location = new System.Drawing.Point(298, 462);
            this.kodeRotiLabel.Name = "kodeRotiLabel";
            this.kodeRotiLabel.Size = new System.Drawing.Size(0, 23);
            this.kodeRotiLabel.TabIndex = 19;
            // 
            // namaJenisRoti
            // 
            this.namaJenisRoti.AutoSize = true;
            this.namaJenisRoti.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaJenisRoti.Location = new System.Drawing.Point(298, 509);
            this.namaJenisRoti.Name = "namaJenisRoti";
            this.namaJenisRoti.Size = new System.Drawing.Size(0, 23);
            this.namaJenisRoti.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(71, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Jenis Roti";
            // 
            // tanggalExpiredLabel
            // 
            this.tanggalExpiredLabel.AutoSize = true;
            this.tanggalExpiredLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalExpiredLabel.Location = new System.Drawing.Point(298, 559);
            this.tanggalExpiredLabel.Name = "tanggalExpiredLabel";
            this.tanggalExpiredLabel.Size = new System.Drawing.Size(0, 23);
            this.tanggalExpiredLabel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Expired at";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(74, 651);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 23);
            this.label19.TabIndex = 33;
            this.label19.Text = "Harga";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(275, 651);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 23);
            this.label20.TabIndex = 35;
            this.label20.Text = ":";
            // 
            // hargaLabel
            // 
            this.hargaLabel.AutoSize = true;
            this.hargaLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaLabel.Location = new System.Drawing.Point(298, 651);
            this.hargaLabel.Name = "hargaLabel";
            this.hargaLabel.Size = new System.Drawing.Size(0, 23);
            this.hargaLabel.TabIndex = 34;
            // 
            // qtyNumericUpDown
            // 
            this.qtyNumericUpDown.Location = new System.Drawing.Point(302, 609);
            this.qtyNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qtyNumericUpDown.Name = "qtyNumericUpDown";
            this.qtyNumericUpDown.Size = new System.Drawing.Size(73, 26);
            this.qtyNumericUpDown.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Qty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(275, 609);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = ":";
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.Black;
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(130, 745);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(84, 72);
            this.addToCartButton.TabIndex = 16;
            this.addToCartButton.Text = "Add Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // keranjangDataGridView
            // 
            this.keranjangDataGridView.AllowUserToAddRows = false;
            this.keranjangDataGridView.AllowUserToDeleteRows = false;
            this.keranjangDataGridView.AllowUserToResizeColumns = false;
            this.keranjangDataGridView.AllowUserToResizeRows = false;
            this.keranjangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.keranjangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keranjangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeRoti,
            this.Name,
            this.Price,
            this.Quantity,
            this.Expiration,
            this.Subtotal});
            this.keranjangDataGridView.GridColor = System.Drawing.Color.Black;
            this.keranjangDataGridView.Location = new System.Drawing.Point(838, 81);
            this.keranjangDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.keranjangDataGridView.Name = "keranjangDataGridView";
            this.keranjangDataGridView.ReadOnly = true;
            this.keranjangDataGridView.RowHeadersVisible = false;
            this.keranjangDataGridView.RowHeadersWidth = 51;
            this.keranjangDataGridView.RowTemplate.Height = 24;
            this.keranjangDataGridView.Size = new System.Drawing.Size(582, 291);
            this.keranjangDataGridView.TabIndex = 0;
            this.keranjangDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KodeRoti
            // 
            this.KodeRoti.HeaderText = "Kode Roti";
            this.KodeRoti.MinimumWidth = 8;
            this.KodeRoti.Name = "KodeRoti";
            this.KodeRoti.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nama";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Expiration
            // 
            this.Expiration.HeaderText = "Expiration";
            this.Expiration.MinimumWidth = 8;
            this.Expiration.Name = "Expiration";
            this.Expiration.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1028, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "KERANJANG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label15
            // 
            this.label15.AllowDrop = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(491, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "Jumlah item ";
            // 
            // jumlahItemLabel
            // 
            this.jumlahItemLabel.AutoSize = true;
            this.jumlahItemLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahItemLabel.Location = new System.Drawing.Point(628, 443);
            this.jumlahItemLabel.Name = "jumlahItemLabel";
            this.jumlahItemLabel.Size = new System.Drawing.Size(21, 23);
            this.jumlahItemLabel.TabIndex = 30;
            this.jumlahItemLabel.Text = "0";
            // 
            // totalHargaLabel
            // 
            this.totalHargaLabel.AutoSize = true;
            this.totalHargaLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHargaLabel.Location = new System.Drawing.Point(628, 509);
            this.totalHargaLabel.Name = "totalHargaLabel";
            this.totalHargaLabel.Size = new System.Drawing.Size(21, 24);
            this.totalHargaLabel.TabIndex = 32;
            this.totalHargaLabel.Text = "0";
            // 
            // butButton
            // 
            this.butButton.BackColor = System.Drawing.Color.Black;
            this.butButton.ForeColor = System.Drawing.Color.White;
            this.butButton.Location = new System.Drawing.Point(343, 745);
            this.butButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butButton.Name = "butButton";
            this.butButton.Size = new System.Drawing.Size(84, 72);
            this.butButton.TabIndex = 36;
            this.butButton.Text = "Buy";
            this.butButton.UseVisualStyleBackColor = false;
            this.butButton.Click += new System.EventHandler(this.butButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(491, 508);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 24);
            this.label17.TabIndex = 31;
            this.label17.Text = "TOTAL";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(546, 745);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 72);
            this.button3.TabIndex = 40;
            this.button3.Text = "Struk";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // diskonDataGridView
            // 
            this.diskonDataGridView.AllowUserToAddRows = false;
            this.diskonDataGridView.AllowUserToDeleteRows = false;
            this.diskonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diskonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diskonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeRoti_Diskon,
            this.NamaRoti,
            this.Potongan,
            this.Quantity_Diskon,
            this.Total_Diskon});
            this.diskonDataGridView.GridColor = System.Drawing.Color.Black;
            this.diskonDataGridView.Location = new System.Drawing.Point(838, 492);
            this.diskonDataGridView.Name = "diskonDataGridView";
            this.diskonDataGridView.ReadOnly = true;
            this.diskonDataGridView.RowHeadersVisible = false;
            this.diskonDataGridView.RowHeadersWidth = 62;
            this.diskonDataGridView.RowTemplate.Height = 28;
            this.diskonDataGridView.Size = new System.Drawing.Size(582, 325);
            this.diskonDataGridView.TabIndex = 41;
            // 
            // KodeRoti_Diskon
            // 
            this.KodeRoti_Diskon.HeaderText = "Kode Roti";
            this.KodeRoti_Diskon.MinimumWidth = 8;
            this.KodeRoti_Diskon.Name = "KodeRoti_Diskon";
            this.KodeRoti_Diskon.ReadOnly = true;
            // 
            // NamaRoti
            // 
            this.NamaRoti.HeaderText = "Nama Roti";
            this.NamaRoti.MinimumWidth = 8;
            this.NamaRoti.Name = "NamaRoti";
            this.NamaRoti.ReadOnly = true;
            // 
            // Potongan
            // 
            this.Potongan.HeaderText = "Potongan";
            this.Potongan.MinimumWidth = 8;
            this.Potongan.Name = "Potongan";
            this.Potongan.ReadOnly = true;
            // 
            // Quantity_Diskon
            // 
            this.Quantity_Diskon.HeaderText = "Quantity";
            this.Quantity_Diskon.MinimumWidth = 8;
            this.Quantity_Diskon.Name = "Quantity_Diskon";
            this.Quantity_Diskon.ReadOnly = true;
            // 
            // Total_Diskon
            // 
            this.Total_Diskon.HeaderText = "Total";
            this.Total_Diskon.MinimumWidth = 8;
            this.Total_Diskon.Name = "Total_Diskon";
            this.Total_Diskon.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1063, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 43;
            this.label1.Text = "DISKON";
            // 
            // Kasir_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1506, 837);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diskonDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.hargaLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.totalHargaLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.jumlahItemLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tanggalExpiredLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namaJenisRoti);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.kodeRotiLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listRotiGridView);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.qtyNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nama_roti_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keranjangDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listRotiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keranjangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nama_roti_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listRotiGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label kodeRotiLabel;
        private System.Windows.Forms.Label namaJenisRoti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tanggalExpiredLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label hargaLabel;
        private System.Windows.Forms.NumericUpDown qtyNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.DataGridView keranjangDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label jumlahItemLabel;
        private System.Windows.Forms.Label totalHargaLabel;
        private System.Windows.Forms.Button butButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeRoti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridView diskonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeRoti_Diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaRoti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potongan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Diskon;
    }

}