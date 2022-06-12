namespace AD_DD_Project
{
    partial class FormNotaPenjualan
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
            this.Lbl_HargaSatuan = new System.Windows.Forms.Label();
            this.lbl_besPromosi = new System.Windows.Forms.Label();
            this.Lbl_NamaPegawai = new System.Windows.Forms.Label();
            this.lbl_tgl = new System.Windows.Forms.Label();
            this.lbl_Hp = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.Lbl_BesarPromosi = new System.Windows.Forms.Label();
            this.lbl_namPegawai = new System.Windows.Forms.Label();
            this.lblTanggalPenjualan = new System.Windows.Forms.Label();
            this.Lbl_notapenjualan = new System.Windows.Forms.Label();
            this.lbl_HarSatuan = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.Lbl_TotalHargaPenjualan = new System.Windows.Forms.Label();
            this.LBL_nambrang = new System.Windows.Forms.Label();
            this.lbl_namabarang = new System.Windows.Forms.Label();
            this.lbl_namaPem = new System.Windows.Forms.Label();
            this.lbl_ouputnamaPem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_HargaSatuan
            // 
            this.Lbl_HargaSatuan.AutoSize = true;
            this.Lbl_HargaSatuan.Location = new System.Drawing.Point(133, 196);
            this.Lbl_HargaSatuan.Name = "Lbl_HargaSatuan";
            this.Lbl_HargaSatuan.Size = new System.Drawing.Size(28, 13);
            this.Lbl_HargaSatuan.TabIndex = 33;
            this.Lbl_HargaSatuan.Text = "(.....)";
            // 
            // lbl_besPromosi
            // 
            this.lbl_besPromosi.AutoSize = true;
            this.lbl_besPromosi.Location = new System.Drawing.Point(44, 218);
            this.lbl_besPromosi.Name = "lbl_besPromosi";
            this.lbl_besPromosi.Size = new System.Drawing.Size(80, 13);
            this.lbl_besPromosi.TabIndex = 32;
            this.lbl_besPromosi.Text = "Besar Promosi :";
            // 
            // Lbl_NamaPegawai
            // 
            this.Lbl_NamaPegawai.AutoSize = true;
            this.Lbl_NamaPegawai.Location = new System.Drawing.Point(44, 106);
            this.Lbl_NamaPegawai.Name = "Lbl_NamaPegawai";
            this.Lbl_NamaPegawai.Size = new System.Drawing.Size(82, 13);
            this.Lbl_NamaPegawai.TabIndex = 30;
            this.Lbl_NamaPegawai.Text = "Nama Pelayan :";
            // 
            // lbl_tgl
            // 
            this.lbl_tgl.AutoSize = true;
            this.lbl_tgl.Location = new System.Drawing.Point(75, 78);
            this.lbl_tgl.Name = "lbl_tgl";
            this.lbl_tgl.Size = new System.Drawing.Size(52, 13);
            this.lbl_tgl.TabIndex = 27;
            this.lbl_tgl.Text = "Tanggal :";
            // 
            // lbl_Hp
            // 
            this.lbl_Hp.AutoSize = true;
            this.lbl_Hp.Location = new System.Drawing.Point(5, 241);
            this.lbl_Hp.Name = "lbl_Hp";
            this.lbl_Hp.Size = new System.Drawing.Size(119, 13);
            this.lbl_Hp.TabIndex = 26;
            this.lbl_Hp.Text = "Total Harga Penjualan :";
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(188, 298);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 23);
            this.btnClose2.TabIndex = 25;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnHome2
            // 
            this.btnHome2.Location = new System.Drawing.Point(51, 298);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(75, 23);
            this.btnHome2.TabIndex = 24;
            this.btnHome2.Text = "Home";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // Lbl_BesarPromosi
            // 
            this.Lbl_BesarPromosi.AutoSize = true;
            this.Lbl_BesarPromosi.Location = new System.Drawing.Point(133, 218);
            this.Lbl_BesarPromosi.Name = "Lbl_BesarPromosi";
            this.Lbl_BesarPromosi.Size = new System.Drawing.Size(28, 13);
            this.Lbl_BesarPromosi.TabIndex = 22;
            this.Lbl_BesarPromosi.Text = "(.....)";
            this.Lbl_BesarPromosi.Click += new System.EventHandler(this.lblTotalHarga_Click);
            // 
            // lbl_namPegawai
            // 
            this.lbl_namPegawai.AutoSize = true;
            this.lbl_namPegawai.Location = new System.Drawing.Point(135, 106);
            this.lbl_namPegawai.Name = "lbl_namPegawai";
            this.lbl_namPegawai.Size = new System.Drawing.Size(28, 13);
            this.lbl_namPegawai.TabIndex = 20;
            this.lbl_namPegawai.Text = "(.....)";
            this.lbl_namPegawai.Click += new System.EventHandler(this.lblIdPegawai_Click);
            // 
            // lblTanggalPenjualan
            // 
            this.lblTanggalPenjualan.AutoSize = true;
            this.lblTanggalPenjualan.Location = new System.Drawing.Point(133, 78);
            this.lblTanggalPenjualan.Name = "lblTanggalPenjualan";
            this.lblTanggalPenjualan.Size = new System.Drawing.Size(28, 13);
            this.lblTanggalPenjualan.TabIndex = 18;
            this.lblTanggalPenjualan.Text = "(.....)";
            // 
            // Lbl_notapenjualan
            // 
            this.Lbl_notapenjualan.AutoSize = true;
            this.Lbl_notapenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_notapenjualan.Location = new System.Drawing.Point(95, 31);
            this.Lbl_notapenjualan.Name = "Lbl_notapenjualan";
            this.Lbl_notapenjualan.Size = new System.Drawing.Size(161, 26);
            this.Lbl_notapenjualan.TabIndex = 17;
            this.Lbl_notapenjualan.Text = "Nota Penjualan";
            // 
            // lbl_HarSatuan
            // 
            this.lbl_HarSatuan.AutoSize = true;
            this.lbl_HarSatuan.Location = new System.Drawing.Point(46, 196);
            this.lbl_HarSatuan.Name = "lbl_HarSatuan";
            this.lbl_HarSatuan.Size = new System.Drawing.Size(79, 13);
            this.lbl_HarSatuan.TabIndex = 34;
            this.lbl_HarSatuan.Text = "Harga Satuan :";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(74, 174);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(52, 13);
            this.lbl_qty.TabIndex = 35;
            this.lbl_qty.Text = "Quantity :";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Location = new System.Drawing.Point(135, 174);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Quantity.TabIndex = 36;
            this.Lbl_Quantity.Text = "(.....)";
            // 
            // Lbl_TotalHargaPenjualan
            // 
            this.Lbl_TotalHargaPenjualan.AutoSize = true;
            this.Lbl_TotalHargaPenjualan.Location = new System.Drawing.Point(133, 241);
            this.Lbl_TotalHargaPenjualan.Name = "Lbl_TotalHargaPenjualan";
            this.Lbl_TotalHargaPenjualan.Size = new System.Drawing.Size(28, 13);
            this.Lbl_TotalHargaPenjualan.TabIndex = 37;
            this.Lbl_TotalHargaPenjualan.Text = "(.....)";
            // 
            // LBL_nambrang
            // 
            this.LBL_nambrang.AutoSize = true;
            this.LBL_nambrang.Location = new System.Drawing.Point(49, 152);
            this.LBL_nambrang.Name = "LBL_nambrang";
            this.LBL_nambrang.Size = new System.Drawing.Size(78, 13);
            this.LBL_nambrang.TabIndex = 38;
            this.LBL_nambrang.Text = "Nama Barang :";
            // 
            // lbl_namabarang
            // 
            this.lbl_namabarang.AutoSize = true;
            this.lbl_namabarang.Location = new System.Drawing.Point(135, 152);
            this.lbl_namabarang.Name = "lbl_namabarang";
            this.lbl_namabarang.Size = new System.Drawing.Size(28, 13);
            this.lbl_namabarang.TabIndex = 39;
            this.lbl_namabarang.Text = "(.....)";
            // 
            // lbl_namaPem
            // 
            this.lbl_namaPem.AutoSize = true;
            this.lbl_namaPem.Location = new System.Drawing.Point(46, 130);
            this.lbl_namaPem.Name = "lbl_namaPem";
            this.lbl_namaPem.Size = new System.Drawing.Size(81, 13);
            this.lbl_namaPem.TabIndex = 40;
            this.lbl_namaPem.Text = "Nama Pembeli :";
            // 
            // lbl_ouputnamaPem
            // 
            this.lbl_ouputnamaPem.AutoSize = true;
            this.lbl_ouputnamaPem.Location = new System.Drawing.Point(135, 130);
            this.lbl_ouputnamaPem.Name = "lbl_ouputnamaPem";
            this.lbl_ouputnamaPem.Size = new System.Drawing.Size(28, 13);
            this.lbl_ouputnamaPem.TabIndex = 41;
            this.lbl_ouputnamaPem.Text = "(.....)";
            // 
            // FormNotaPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 341);
            this.Controls.Add(this.lbl_ouputnamaPem);
            this.Controls.Add(this.lbl_namaPem);
            this.Controls.Add(this.lbl_namabarang);
            this.Controls.Add(this.LBL_nambrang);
            this.Controls.Add(this.Lbl_TotalHargaPenjualan);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_HarSatuan);
            this.Controls.Add(this.Lbl_HargaSatuan);
            this.Controls.Add(this.lbl_besPromosi);
            this.Controls.Add(this.Lbl_NamaPegawai);
            this.Controls.Add(this.lbl_tgl);
            this.Controls.Add(this.lbl_Hp);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnHome2);
            this.Controls.Add(this.Lbl_BesarPromosi);
            this.Controls.Add(this.lbl_namPegawai);
            this.Controls.Add(this.lblTanggalPenjualan);
            this.Controls.Add(this.Lbl_notapenjualan);
            this.Name = "FormNotaPenjualan";
            this.Text = "Nota Penjualan";
            this.Load += new System.EventHandler(this.FormNotaPenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_HargaSatuan;
        private System.Windows.Forms.Label lbl_besPromosi;
        private System.Windows.Forms.Label Lbl_NamaPegawai;
        private System.Windows.Forms.Label lbl_tgl;
        private System.Windows.Forms.Label lbl_Hp;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Label Lbl_BesarPromosi;
        private System.Windows.Forms.Label lbl_namPegawai;
        private System.Windows.Forms.Label lblTanggalPenjualan;
        private System.Windows.Forms.Label Lbl_notapenjualan;
        private System.Windows.Forms.Label lbl_HarSatuan;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Label Lbl_TotalHargaPenjualan;
        private System.Windows.Forms.Label LBL_nambrang;
        private System.Windows.Forms.Label lbl_namabarang;
        private System.Windows.Forms.Label lbl_namaPem;
        private System.Windows.Forms.Label lbl_ouputnamaPem;
    }
}