namespace _05hoadonbanmaytinh
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btt_them = new System.Windows.Forms.Button();
            this.btt_sua = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_dong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_mahoadon = new System.Windows.Forms.TextBox();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.tb_tenmay = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.ngayban = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 209);
            this.dataGridView1.TabIndex = 1;
            // 
            // btt_them
            // 
            this.btt_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_them.Location = new System.Drawing.Point(115, 408);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(75, 23);
            this.btt_them.TabIndex = 2;
            this.btt_them.Text = "Thêm";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // btt_sua
            // 
            this.btt_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_sua.Location = new System.Drawing.Point(252, 408);
            this.btt_sua.Name = "btt_sua";
            this.btt_sua.Size = new System.Drawing.Size(75, 23);
            this.btt_sua.TabIndex = 3;
            this.btt_sua.Text = "Sửa";
            this.btt_sua.UseVisualStyleBackColor = true;
            this.btt_sua.Click += new System.EventHandler(this.btt_sua_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_xoa.Location = new System.Drawing.Point(384, 408);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(75, 23);
            this.btt_xoa.TabIndex = 4;
            this.btt_xoa.Text = "Xóa";
            this.btt_xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btt_xoa.UseVisualStyleBackColor = true;
            // 
            // btt_dong
            // 
            this.btt_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_dong.Location = new System.Drawing.Point(495, 408);
            this.btt_dong.Name = "btt_dong";
            this.btt_dong.Size = new System.Drawing.Size(75, 23);
            this.btt_dong.TabIndex = 5;
            this.btt_dong.Text = "Đóng";
            this.btt_dong.UseVisualStyleBackColor = true;
            this.btt_dong.Click += new System.EventHandler(this.btt_dong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã HD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên KH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày bán";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên máy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng";
            // 
            // tb_mahoadon
            // 
            this.tb_mahoadon.Location = new System.Drawing.Point(405, 8);
            this.tb_mahoadon.Name = "tb_mahoadon";
            this.tb_mahoadon.Size = new System.Drawing.Size(165, 22);
            this.tb_mahoadon.TabIndex = 13;
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Location = new System.Drawing.Point(405, 47);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(221, 22);
            this.tb_tenKH.TabIndex = 14;
            // 
            // tb_tenmay
            // 
            this.tb_tenmay.Location = new System.Drawing.Point(405, 116);
            this.tb_tenmay.Name = "tb_tenmay";
            this.tb_tenmay.Size = new System.Drawing.Size(221, 22);
            this.tb_tenmay.TabIndex = 15;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(87, 148);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(165, 22);
            this.tb_dongia.TabIndex = 16;
            this.tb_dongia.Leave += new System.EventHandler(this.tb_dongia_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(87, 117);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Để bàn";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(186, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Xách tay";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // num_soluong
            // 
            this.num_soluong.Location = new System.Drawing.Point(405, 149);
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(82, 22);
            this.num_soluong.TabIndex = 19;
            // 
            // ngayban
            // 
            this.ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayban.Location = new System.Drawing.Point(405, 80);
            this.ngayban.Name = "ngayban";
            this.ngayban.Size = new System.Drawing.Size(165, 22);
            this.ngayban.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.btt_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 443);
            this.Controls.Add(this.ngayban);
            this.Controls.Add(this.num_soluong);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_dongia);
            this.Controls.Add(this.tb_tenmay);
            this.Controls.Add(this.tb_tenKH);
            this.Controls.Add(this.tb_mahoadon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_dong);
            this.Controls.Add(this.btt_xoa);
            this.Controls.Add(this.btt_sua);
            this.Controls.Add(this.btt_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán máy tính(hoangthiphuonng)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.Button btt_sua;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_dong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_mahoadon;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.TextBox tb_tenmay;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.DateTimePicker ngayban;
    }
}

