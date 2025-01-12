﻿using FontAwesome.Sharp;

namespace TrungTamNgoaiNgu.GUI.GiaoDienPhongThi
{
    partial class Gui_PhongThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.phongThiGridView = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnLapDS = new FontAwesome.Sharp.IconButton();
            this.btnDanhSach = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxKhoaThi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongThiGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(1257, 754);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(11, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 684);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.phongThiGridView);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 88);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1235, 596);
            this.panel7.TabIndex = 3;
            // 
            // phongThiGridView
            // 
            this.phongThiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phongThiGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.phongThiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongThiGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phongThiGridView.Location = new System.Drawing.Point(0, 0);
            this.phongThiGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phongThiGridView.Name = "phongThiGridView";
            this.phongThiGridView.ReadOnly = true;
            this.phongThiGridView.RowHeadersWidth = 51;
            this.phongThiGridView.RowTemplate.Height = 24;
            this.phongThiGridView.Size = new System.Drawing.Size(1235, 596);
            this.phongThiGridView.TabIndex = 0;
            this.phongThiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khoaThiGridView_CellClick);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1235, 20);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTimKiem);
            this.panel5.Controls.Add(this.btnTimKiem);
            this.panel5.Controls.Add(this.btnLamMoi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1235, 48);
            this.panel5.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(0, 0);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(881, 48);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 1;
            this.btnTimKiem.Location = new System.Drawing.Point(881, 0);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(191, 48);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLamMoi.IconColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 1;
            this.btnLamMoi.Location = new System.Drawing.Point(1072, 0);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(163, 48);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1235, 20);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnLapDS);
            this.panel2.Controls.Add(this.btnDanhSach);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbxKhoaThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(11, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 1;
            this.btnThem.Location = new System.Drawing.Point(493, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 50);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "THÊM PHÒNG THI";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 1;
            this.btnXoa.Location = new System.Drawing.Point(657, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 50);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "XÓA PHÒNG THI";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLapDS
            // 
            this.btnLapDS.BackColor = System.Drawing.Color.Transparent;
            this.btnLapDS.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLapDS.FlatAppearance.BorderSize = 0;
            this.btnLapDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapDS.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapDS.ForeColor = System.Drawing.Color.Black;
            this.btnLapDS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLapDS.IconColor = System.Drawing.Color.Black;
            this.btnLapDS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLapDS.IconSize = 1;
            this.btnLapDS.Location = new System.Drawing.Point(823, 0);
            this.btnLapDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapDS.Name = "btnLapDS";
            this.btnLapDS.Size = new System.Drawing.Size(217, 50);
            this.btnLapDS.TabIndex = 13;
            this.btnLapDS.Text = "LẬP DANH SÁCH DỰ THI";
            this.btnLapDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapDS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapDS.UseVisualStyleBackColor = false;
            this.btnLapDS.Click += new System.EventHandler(this.btnLapDS_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDanhSach.FlatAppearance.BorderSize = 0;
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.Black;
            this.btnDanhSach.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDanhSach.IconColor = System.Drawing.Color.Black;
            this.btnDanhSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhSach.IconSize = 1;
            this.btnDanhSach.Location = new System.Drawing.Point(1040, 0);
            this.btnDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(195, 50);
            this.btnDanhSach.TabIndex = 12;
            this.btnDanhSach.Text = "DANH SÁCH THÍ SINH";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "KHÓA THI";
            // 
            // cbxKhoaThi
            // 
            this.cbxKhoaThi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxKhoaThi.FormattingEnabled = true;
            this.cbxKhoaThi.Location = new System.Drawing.Point(96, 10);
            this.cbxKhoaThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKhoaThi.Name = "cbxKhoaThi";
            this.cbxKhoaThi.Size = new System.Drawing.Size(274, 27);
            this.cbxKhoaThi.TabIndex = 0;
            this.cbxKhoaThi.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaThi_SelectedIndexChanged);
            this.cbxKhoaThi.DropDownClosed += new System.EventHandler(this.cbxKhoaThi_DropDownClosed);
            // 
            // Gui_PhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 754);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gui_PhongThi";
            this.Text = "Gui_GiaTour";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongThiGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView phongThiGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbxKhoaThi;
        private System.Windows.Forms.Label label4;
        private IconButton btnThem;
        private IconButton btnXoa;
        private IconButton btnLapDS;
        private IconButton btnDanhSach;
    }
}