namespace Bai02.Custom
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(427, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(417, 16);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(91, 24);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "5.000.000đ";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(143, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(221, 69);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "giày siêu đẹp";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelDelete.Location = new System.Drawing.Point(45, 92);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(38, 20);
            this.labelDelete.TabIndex = 8;
            this.labelDelete.Text = "Xóa";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(146, 83);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(47, 20);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Size:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tạm tính:";
            // 
            // label_tong
            // 
            this.label_tong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tong.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tong.Location = new System.Drawing.Point(417, 78);
            this.label_tong.Name = "label_tong";
            this.label_tong.Size = new System.Drawing.Size(91, 24);
            this.label_tong.TabIndex = 13;
            this.label_tong.Text = "5.000.000đ";
            this.label_tong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.label_tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(532, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tong;
    }
}
