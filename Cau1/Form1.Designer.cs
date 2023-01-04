
namespace Cau1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnoisinh = new System.Windows.Forms.TextBox();
            this.cbdonvi = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbgtnam = new System.Windows.Forms.CheckBox();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(70, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(170, 27);
            this.tbid.TabIndex = 6;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(315, 11);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(170, 27);
            this.tbname.TabIndex = 7;
            // 
            // tbnoisinh
            // 
            this.tbnoisinh.Location = new System.Drawing.Point(315, 45);
            this.tbnoisinh.Name = "tbnoisinh";
            this.tbnoisinh.Size = new System.Drawing.Size(530, 27);
            this.tbnoisinh.TabIndex = 8;
            // 
            // cbdonvi
            // 
            this.cbdonvi.FormattingEnabled = true;
            this.cbdonvi.Location = new System.Drawing.Point(70, 44);
            this.cbdonvi.Name = "cbdonvi";
            this.cbdonvi.Size = new System.Drawing.Size(170, 28);
            this.cbdonvi.TabIndex = 9;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(571, 11);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(148, 27);
            this.dtpngaysinh.TabIndex = 10;
            // 
            // cbgtnam
            // 
            this.cbgtnam.AutoSize = true;
            this.cbgtnam.Location = new System.Drawing.Point(725, 10);
            this.cbgtnam.Name = "cbgtnam";
            this.cbgtnam.Size = new System.Drawing.Size(120, 24);
            this.cbgtnam.TabIndex = 11;
            this.cbgtnam.Text = "Giới tính nam";
            this.cbgtnam.UseVisualStyleBackColor = true;
            // 
            // dgvemployee
            // 
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.Location = new System.Drawing.Point(12, 78);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.RowHeadersWidth = 51;
            this.dgvemployee.RowTemplate.Height = 29;
            this.dgvemployee.Size = new System.Drawing.Size(833, 351);
            this.dgvemployee.TabIndex = 12;
            this.dgvemployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemployee_RowEnter);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btthem.Location = new System.Drawing.Point(343, 435);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(121, 40);
            this.btthem.TabIndex = 13;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btxoa.Location = new System.Drawing.Point(470, 435);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(121, 40);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btsua.Location = new System.Drawing.Point(597, 435);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(121, 40);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btthoat.Location = new System.Drawing.Point(724, 435);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(121, 40);
            this.btthoat.TabIndex = 16;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 487);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgvemployee);
            this.Controls.Add(this.cbgtnam);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.cbdonvi);
            this.Controls.Add(this.tbnoisinh);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbnoisinh;
        private System.Windows.Forms.ComboBox cbdonvi;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.CheckBox cbgtnam;
        private System.Windows.Forms.DataGridView dgvemployee;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthoat;
    }
}

