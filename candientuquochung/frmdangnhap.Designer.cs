namespace candientuquochung
{
    partial class frmdangnhap
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
            this.components = new System.ComponentModel.Container();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.cbbtaikhoan = new System.Windows.Forms.ComboBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logodangnhap = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(33, 338);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(537, 48);
            this.txtmatkhau.TabIndex = 14;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(29, 305);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(133, 31);
            this.lblmatkhau.TabIndex = 13;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaikhoan.Location = new System.Drawing.Point(27, 225);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(142, 31);
            this.lbltaikhoan.TabIndex = 11;
            this.lbltaikhoan.Text = "Tài khoản";
            this.lbltaikhoan.Click += new System.EventHandler(this.lbltaikhoan_Click);
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldangnhap.Location = new System.Drawing.Point(189, 11);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(213, 40);
            this.lbldangnhap.TabIndex = 8;
            this.lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // cbbtaikhoan
            // 
            this.cbbtaikhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbtaikhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbtaikhoan.FormattingEnabled = true;
            this.cbbtaikhoan.Items.AddRange(new object[] {
            "Hoàng Văn Mạnh",
            "Lê Phú Huy",
            "Mông Thanh Hải",
            "Nông Đức Thắng",
            "Nguyễn Đăng Đức Thắng",
            "Nguyễn Thành Giang",
            "Võ Hồng Quân"});
            this.cbbtaikhoan.Location = new System.Drawing.Point(33, 266);
            this.cbbtaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtaikhoan.Name = "cbbtaikhoan";
            this.cbbtaikhoan.Size = new System.Drawing.Size(537, 24);
            this.cbbtaikhoan.Sorted = true;
            this.cbbtaikhoan.TabIndex = 15;
            this.cbbtaikhoan.Text = "t";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(33, 406);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(184, 52);
            this.btndangnhap.TabIndex = 16;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnketthuc.Location = new System.Drawing.Point(391, 406);
            this.btnketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(189, 52);
            this.btnketthuc.TabIndex = 17;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::candientuquochung.Properties.Resources.can1;
            this.pictureBox1.Location = new System.Drawing.Point(87, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // logodangnhap
            // 
            this.logodangnhap.AutoSize = true;
            this.logodangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.logodangnhap.Image = global::candientuquochung.Properties.Resources.logo;
            this.logodangnhap.Location = new System.Drawing.Point(65, 130);
            this.logodangnhap.Name = "logodangnhap";
            this.logodangnhap.Size = new System.Drawing.Size(0, 17);
            this.logodangnhap.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(657, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.cbbtaikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.logodangnhap);
            this.Controls.Add(this.lbldangnhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label logodangnhap;
        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.ComboBox cbbtaikhoan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}