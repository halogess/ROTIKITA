namespace ROTIKITA
{
    partial class Admin_daftar
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
            this.addPanel = new ROTIKITA.RoundedPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.addNamaLabel = new System.Windows.Forms.Label();
            this.expiredTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addPanel.BackColor = System.Drawing.Color.Silver;
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPanel.Controls.Add(this.clearButton);
            this.addPanel.Controls.Add(this.deleteButton);
            this.addPanel.Controls.Add(this.updateButton);
            this.addPanel.Controls.Add(this.insertButton);
            this.addPanel.Controls.Add(this.hargaTextBox);
            this.addPanel.Controls.Add(this.addNamaLabel);
            this.addPanel.Controls.Add(this.expiredTextBox);
            this.addPanel.Controls.Add(this.namaTextBox);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(267, 299);
            this.addPanel.TabIndex = 6;
            this.addPanel.Click += new System.EventHandler(this.addPanel_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Black;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(151, 261);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 24);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Black;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(13, 261);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 24);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Black;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(151, 226);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 24);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Black;
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(13, 226);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 24);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.Location = new System.Drawing.Point(13, 177);
            this.hargaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hargaTextBox.Multiline = true;
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(239, 26);
            this.hargaTextBox.TabIndex = 5;
            // 
            // addNamaLabel
            // 
            this.addNamaLabel.AutoSize = true;
            this.addNamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNamaLabel.Location = new System.Drawing.Point(5, 20);
            this.addNamaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNamaLabel.Name = "addNamaLabel";
            this.addNamaLabel.Size = new System.Drawing.Size(59, 20);
            this.addNamaLabel.TabIndex = 0;
            this.addNamaLabel.Text = "Nama :";
            // 
            // expiredTextBox
            // 
            this.expiredTextBox.Location = new System.Drawing.Point(13, 116);
            this.expiredTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expiredTextBox.Multiline = true;
            this.expiredTextBox.Name = "expiredTextBox";
            this.expiredTextBox.Size = new System.Drawing.Size(239, 26);
            this.expiredTextBox.TabIndex = 4;
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(13, 49);
            this.namaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(239, 26);
            this.namaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expired :";
            // 
            // Admin_daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(775, 298);
            this.Controls.Add(this.addPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_daftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_daftar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDaftarRoti_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FormDaftarRoti_Scroll);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addNamaLabel;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expiredTextBox;
        private System.Windows.Forms.TextBox hargaTextBox;
        private RoundedPanel addPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
    }

}

