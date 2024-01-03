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
            this.addPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(399, 450);
            this.addPanel.TabIndex = 6;
            this.addPanel.Click += new System.EventHandler(this.addPanel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 401);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 37);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(20, 401);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 37);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(227, 348);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 37);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(20, 348);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(150, 37);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.Location = new System.Drawing.Point(20, 273);
            this.hargaTextBox.Multiline = true;
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(357, 38);
            this.hargaTextBox.TabIndex = 5;
            // 
            // addNamaLabel
            // 
            this.addNamaLabel.AutoSize = true;
            this.addNamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNamaLabel.Location = new System.Drawing.Point(8, 30);
            this.addNamaLabel.Name = "addNamaLabel";
            this.addNamaLabel.Size = new System.Drawing.Size(89, 29);
            this.addNamaLabel.TabIndex = 0;
            this.addNamaLabel.Text = "Nama :";
            // 
            // expiredTextBox
            // 
            this.expiredTextBox.Location = new System.Drawing.Point(20, 178);
            this.expiredTextBox.Multiline = true;
            this.expiredTextBox.Name = "expiredTextBox";
            this.expiredTextBox.Size = new System.Drawing.Size(357, 38);
            this.expiredTextBox.TabIndex = 4;
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(20, 76);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(357, 38);
            this.namaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expired :";
            // 
            // FormDaftarRoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.addPanel);
            this.Name = "Admin_daftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_daftar";
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

