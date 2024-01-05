namespace ROTIKITA
{
    partial class Admin_tambah
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
            this.jenisRotiGriwView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addNamaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.addRotiButton = new System.Windows.Forms.Button();
            this.labelJenisRoti = new System.Windows.Forms.Label();
            this.listRotiGridView = new System.Windows.Forms.DataGridView();
            this.labelRotiAda = new System.Windows.Forms.Label();
            this.editRotiButton = new System.Windows.Forms.Button();
            this.jenisRotiLabel = new System.Windows.Forms.Label();
            this.labelKodeRoti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBJenisRoti = new System.Windows.Forms.Label();
            this.TBKodeRoti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRotiGriwView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRotiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jenisRotiGriwView
            // 
            this.jenisRotiGriwView.AllowUserToAddRows = false;
            this.jenisRotiGriwView.AllowUserToDeleteRows = false;
            this.jenisRotiGriwView.AllowUserToResizeColumns = false;
            this.jenisRotiGriwView.AllowUserToResizeRows = false;
            this.jenisRotiGriwView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jenisRotiGriwView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jenisRotiGriwView.GridColor = System.Drawing.Color.Black;
            this.jenisRotiGriwView.Location = new System.Drawing.Point(20, 46);
            this.jenisRotiGriwView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jenisRotiGriwView.Name = "jenisRotiGriwView";
            this.jenisRotiGriwView.ReadOnly = true;
            this.jenisRotiGriwView.RowHeadersVisible = false;
            this.jenisRotiGriwView.RowHeadersWidth = 62;
            this.jenisRotiGriwView.RowTemplate.Height = 28;
            this.jenisRotiGriwView.Size = new System.Drawing.Size(766, 218);
            this.jenisRotiGriwView.TabIndex = 0;
            this.jenisRotiGriwView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jenisRotiGriwView_CellClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 401);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 37);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(20, 401);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 37);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(227, 348);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 37);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(20, 348);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(150, 37);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 276);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(357, 38);
            this.textBox3.TabIndex = 5;
            // 
            // addNamaLabel
            // 
            this.addNamaLabel.AutoSize = true;
            this.addNamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNamaLabel.Location = new System.Drawing.Point(11, 30);
            this.addNamaLabel.Name = "addNamaLabel";
            this.addNamaLabel.Size = new System.Drawing.Size(68, 29);
            this.addNamaLabel.TabIndex = 0;
            this.addNamaLabel.Text = "Roti :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Roti :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(103, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(274, 26);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qty :";
            // 
            // qtyNumericUpDown
            // 
            this.qtyNumericUpDown.Location = new System.Drawing.Point(140, 398);
            this.qtyNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.qtyNumericUpDown.Name = "qtyNumericUpDown";
            this.qtyNumericUpDown.Size = new System.Drawing.Size(172, 26);
            this.qtyNumericUpDown.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "pcs";
            // 
            // addRotiButton
            // 
            this.addRotiButton.BackColor = System.Drawing.Color.Black;
            this.addRotiButton.ForeColor = System.Drawing.Color.White;
            this.addRotiButton.Location = new System.Drawing.Point(458, 278);
            this.addRotiButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addRotiButton.Name = "addRotiButton";
            this.addRotiButton.Size = new System.Drawing.Size(324, 42);
            this.addRotiButton.TabIndex = 16;
            this.addRotiButton.Text = "Add Roti";
            this.addRotiButton.UseVisualStyleBackColor = false;
            this.addRotiButton.Click += new System.EventHandler(this.addRotiButton_Click);
            // 
            // labelJenisRoti
            // 
            this.labelJenisRoti.AutoSize = true;
            this.labelJenisRoti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisRoti.Location = new System.Drawing.Point(21, 9);
            this.labelJenisRoti.Name = "labelJenisRoti";
            this.labelJenisRoti.Size = new System.Drawing.Size(128, 26);
            this.labelJenisRoti.TabIndex = 17;
            this.labelJenisRoti.Text = "Jenis Roti :";
            // 
            // listRotiGridView
            // 
            this.listRotiGridView.AllowUserToAddRows = false;
            this.listRotiGridView.AllowUserToDeleteRows = false;
            this.listRotiGridView.AllowUserToResizeColumns = false;
            this.listRotiGridView.AllowUserToResizeRows = false;
            this.listRotiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listRotiGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listRotiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRotiGridView.GridColor = System.Drawing.Color.Black;
            this.listRotiGridView.Location = new System.Drawing.Point(856, 38);
            this.listRotiGridView.Name = "listRotiGridView";
            this.listRotiGridView.ReadOnly = true;
            this.listRotiGridView.RowHeadersVisible = false;
            this.listRotiGridView.RowHeadersWidth = 62;
            this.listRotiGridView.RowTemplate.Height = 28;
            this.listRotiGridView.Size = new System.Drawing.Size(712, 405);
            this.listRotiGridView.TabIndex = 18;
            this.listRotiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listRotiGridView_CellClick);
            // 
            // labelRotiAda
            // 
            this.labelRotiAda.AutoSize = true;
            this.labelRotiAda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotiAda.Location = new System.Drawing.Point(850, 9);
            this.labelRotiAda.Name = "labelRotiAda";
            this.labelRotiAda.Size = new System.Drawing.Size(116, 26);
            this.labelRotiAda.TabIndex = 19;
            this.labelRotiAda.Text = "List Roti :";
            // 
            // editRotiButton
            // 
            this.editRotiButton.BackColor = System.Drawing.Color.Black;
            this.editRotiButton.ForeColor = System.Drawing.Color.White;
            this.editRotiButton.Location = new System.Drawing.Point(458, 335);
            this.editRotiButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.editRotiButton.Name = "editRotiButton";
            this.editRotiButton.Size = new System.Drawing.Size(324, 42);
            this.editRotiButton.TabIndex = 20;
            this.editRotiButton.Text = "Edit Roti";
            this.editRotiButton.UseVisualStyleBackColor = false;
            this.editRotiButton.Click += new System.EventHandler(this.editRotiButton_Click);
            // 
            // jenisRotiLabel
            // 
            this.jenisRotiLabel.AutoSize = true;
            this.jenisRotiLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisRotiLabel.Location = new System.Drawing.Point(15, 297);
            this.jenisRotiLabel.Name = "jenisRotiLabel";
            this.jenisRotiLabel.Size = new System.Drawing.Size(106, 23);
            this.jenisRotiLabel.TabIndex = 21;
            this.jenisRotiLabel.Text = "Jenis Roti :";
            // 
            // labelKodeRoti
            // 
            this.labelKodeRoti.AutoSize = true;
            this.labelKodeRoti.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeRoti.Location = new System.Drawing.Point(15, 345);
            this.labelKodeRoti.Name = "labelKodeRoti";
            this.labelKodeRoti.Size = new System.Drawing.Size(107, 23);
            this.labelKodeRoti.TabIndex = 23;
            this.labelKodeRoti.Text = "Kode Roti :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBJenisRoti
            // 
            this.TBJenisRoti.AutoSize = true;
            this.TBJenisRoti.Location = new System.Drawing.Point(136, 300);
            this.TBJenisRoti.Name = "TBJenisRoti";
            this.TBJenisRoti.Size = new System.Drawing.Size(0, 20);
            this.TBJenisRoti.TabIndex = 26;
            // 
            // TBKodeRoti
            // 
            this.TBKodeRoti.AutoSize = true;
            this.TBKodeRoti.Location = new System.Drawing.Point(136, 347);
            this.TBKodeRoti.Name = "TBKodeRoti";
            this.TBKodeRoti.Size = new System.Drawing.Size(0, 20);
            this.TBKodeRoti.TabIndex = 27;
            // 
            // Admin_tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 458);
            this.Controls.Add(this.TBKodeRoti);
            this.Controls.Add(this.TBJenisRoti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelKodeRoti);
            this.Controls.Add(this.jenisRotiLabel);
            this.Controls.Add(this.editRotiButton);
            this.Controls.Add(this.labelRotiAda);
            this.Controls.Add(this.listRotiGridView);
            this.Controls.Add(this.labelJenisRoti);
            this.Controls.Add(this.addRotiButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtyNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jenisRotiGriwView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_tambah";
            this.Text = "FormTambahRoti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTambahRoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jenisRotiGriwView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRotiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jenisRotiGriwView;
        private RoundedPanel addPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label addNamaLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown qtyNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRotiButton;
        private System.Windows.Forms.Label labelJenisRoti;
        private System.Windows.Forms.DataGridView listRotiGridView;
        private System.Windows.Forms.Label labelRotiAda;
        private System.Windows.Forms.Button editRotiButton;
        private System.Windows.Forms.Label jenisRotiLabel;
        private System.Windows.Forms.Label labelKodeRoti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TBJenisRoti;
        private System.Windows.Forms.Label TBKodeRoti;
    }
}