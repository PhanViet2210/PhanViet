namespace BANHANG
{
    partial class frmTimKiemKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dfcdfcd = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.txtNhap);
            this.panel1.Controls.Add(this.bntTimKiem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 203);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.dfcdfcd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 53);
            this.panel3.TabIndex = 41;
            // 
            // dfcdfcd
            // 
            this.dfcdfcd.AutoSize = true;
            this.dfcdfcd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.dfcdfcd.ForeColor = System.Drawing.Color.White;
            this.dfcdfcd.Location = new System.Drawing.Point(448, 11);
            this.dfcdfcd.Name = "dfcdfcd";
            this.dfcdfcd.Size = new System.Drawing.Size(268, 30);
            this.dfcdfcd.TabIndex = 2;
            this.dfcdfcd.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton1.Location = new System.Drawing.Point(334, 88);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 25);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã khách hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNhap.Location = new System.Drawing.Point(464, 139);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(319, 29);
            this.txtNhap.TabIndex = 28;
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bntTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.Image = global::BANHANG.Properties.Resources.Search_icon;
            this.bntTimKiem.Location = new System.Drawing.Point(795, 135);
            this.bntTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(36, 36);
            this.bntTimKiem.TabIndex = 20;
            this.bntTimKiem.UseVisualStyleBackColor = false;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(345, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhập thông tin";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton2.Location = new System.Drawing.Point(528, 88);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 25);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên khách hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton3.Location = new System.Drawing.Point(726, 88);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 25);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Số điện thoại";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(190, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 276);
            this.dataGridView1.TabIndex = 32;
            // 
            // bntDong
            // 
            this.bntDong.BackColor = System.Drawing.Color.Brown;
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDong.ForeColor = System.Drawing.Color.White;
            this.bntDong.Location = new System.Drawing.Point(572, 585);
            this.bntDong.Margin = new System.Windows.Forms.Padding(2);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(80, 38);
            this.bntDong.TabIndex = 23;
            this.bntDong.Text = "ĐÓNG";
            this.bntDong.UseVisualStyleBackColor = false;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // frmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 709);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemKhachHang";
            this.Text = "TimKiemKhachHang";
            this.Load += new System.EventHandler(this.frmTimKiemKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntDong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label dfcdfcd;
    }
}