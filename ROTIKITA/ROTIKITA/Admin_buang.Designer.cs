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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgv_roti.Location = new System.Drawing.Point(24, 48);
            this.dgv_roti.Name = "dgv_roti";
            this.dgv_roti.RowHeadersVisible = false;
            this.dgv_roti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_roti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_roti.Size = new System.Drawing.Size(656, 245);
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
            this.dgv_buang.Location = new System.Drawing.Point(24, 345);
            this.dgv_buang.Name = "dgv_buang";
            this.dgv_buang.RowHeadersVisible = false;
            this.dgv_buang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_buang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buang.Size = new System.Drawing.Size(826, 237);
            this.dgv_buang.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(703, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 245);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // Admin_buang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}