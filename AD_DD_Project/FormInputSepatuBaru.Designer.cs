namespace AD_DD_Project
{
    partial class FormInputSepatuBaru
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
            this.Btn_back = new System.Windows.Forms.Button();
            this.dgwDataSepatu = new System.Windows.Forms.DataGridView();
            this.Lbl_idSepatu = new System.Windows.Forms.Label();
            this.Lbl_namaSepatu = new System.Windows.Forms.Label();
            this.Lbl_warnaSepatu = new System.Windows.Forms.Label();
            this.Lbl_UkuranSepatu = new System.Windows.Forms.Label();
            this.Lbl_stockSepatu = new System.Windows.Forms.Label();
            this.Lbl_hargaPenjualan = new System.Windows.Forms.Label();
            this.Lbl_hargaPembelian = new System.Windows.Forms.Label();
            this.Txb_Oidsepatu = new System.Windows.Forms.TextBox();
            this.Txb_OnamaSepatu = new System.Windows.Forms.TextBox();
            this.Txb_OwarnaSepatu = new System.Windows.Forms.TextBox();
            this.Txb_OukuranSepatu = new System.Windows.Forms.TextBox();
            this.Txb_OstockSepatu = new System.Windows.Forms.TextBox();
            this.Txb_OhargaPenjualan = new System.Windows.Forms.TextBox();
            this.Txb_OhargaPembelian = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_dataSepatuBaru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataSepatu)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_back
            // 
            this.Btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(31, 232);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(75, 32);
            this.Btn_back.TabIndex = 0;
            this.Btn_back.Text = "BACK";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // dgwDataSepatu
            // 
            this.dgwDataSepatu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDataSepatu.Location = new System.Drawing.Point(12, 270);
            this.dgwDataSepatu.Name = "dgwDataSepatu";
            this.dgwDataSepatu.Size = new System.Drawing.Size(776, 168);
            this.dgwDataSepatu.TabIndex = 1;
            // 
            // Lbl_idSepatu
            // 
            this.Lbl_idSepatu.AutoSize = true;
            this.Lbl_idSepatu.Location = new System.Drawing.Point(13, 61);
            this.Lbl_idSepatu.Name = "Lbl_idSepatu";
            this.Lbl_idSepatu.Size = new System.Drawing.Size(56, 13);
            this.Lbl_idSepatu.TabIndex = 2;
            this.Lbl_idSepatu.Text = "Id Sepatu ";
            // 
            // Lbl_namaSepatu
            // 
            this.Lbl_namaSepatu.AutoSize = true;
            this.Lbl_namaSepatu.Location = new System.Drawing.Point(13, 85);
            this.Lbl_namaSepatu.Name = "Lbl_namaSepatu";
            this.Lbl_namaSepatu.Size = new System.Drawing.Size(75, 13);
            this.Lbl_namaSepatu.TabIndex = 3;
            this.Lbl_namaSepatu.Text = "Nama Sepatu ";
            // 
            // Lbl_warnaSepatu
            // 
            this.Lbl_warnaSepatu.AutoSize = true;
            this.Lbl_warnaSepatu.Location = new System.Drawing.Point(13, 111);
            this.Lbl_warnaSepatu.Name = "Lbl_warnaSepatu";
            this.Lbl_warnaSepatu.Size = new System.Drawing.Size(79, 13);
            this.Lbl_warnaSepatu.TabIndex = 4;
            this.Lbl_warnaSepatu.Text = "Warna Sepatu ";
            // 
            // Lbl_UkuranSepatu
            // 
            this.Lbl_UkuranSepatu.AutoSize = true;
            this.Lbl_UkuranSepatu.Location = new System.Drawing.Point(13, 138);
            this.Lbl_UkuranSepatu.Name = "Lbl_UkuranSepatu";
            this.Lbl_UkuranSepatu.Size = new System.Drawing.Size(82, 13);
            this.Lbl_UkuranSepatu.TabIndex = 5;
            this.Lbl_UkuranSepatu.Text = "Ukuran Sepatu ";
            // 
            // Lbl_stockSepatu
            // 
            this.Lbl_stockSepatu.AutoSize = true;
            this.Lbl_stockSepatu.Location = new System.Drawing.Point(13, 162);
            this.Lbl_stockSepatu.Name = "Lbl_stockSepatu";
            this.Lbl_stockSepatu.Size = new System.Drawing.Size(75, 13);
            this.Lbl_stockSepatu.TabIndex = 6;
            this.Lbl_stockSepatu.Text = "Stock Sepatu ";
            // 
            // Lbl_hargaPenjualan
            // 
            this.Lbl_hargaPenjualan.AutoSize = true;
            this.Lbl_hargaPenjualan.Location = new System.Drawing.Point(13, 185);
            this.Lbl_hargaPenjualan.Name = "Lbl_hargaPenjualan";
            this.Lbl_hargaPenjualan.Size = new System.Drawing.Size(89, 13);
            this.Lbl_hargaPenjualan.TabIndex = 7;
            this.Lbl_hargaPenjualan.Text = "Harga Penjualan ";
            // 
            // Lbl_hargaPembelian
            // 
            this.Lbl_hargaPembelian.AutoSize = true;
            this.Lbl_hargaPembelian.Location = new System.Drawing.Point(13, 208);
            this.Lbl_hargaPembelian.Name = "Lbl_hargaPembelian";
            this.Lbl_hargaPembelian.Size = new System.Drawing.Size(94, 13);
            this.Lbl_hargaPembelian.TabIndex = 8;
            this.Lbl_hargaPembelian.Text = "Harga Pembelian  ";
            // 
            // Txb_Oidsepatu
            // 
            this.Txb_Oidsepatu.Location = new System.Drawing.Point(100, 58);
            this.Txb_Oidsepatu.Name = "Txb_Oidsepatu";
            this.Txb_Oidsepatu.Size = new System.Drawing.Size(678, 20);
            this.Txb_Oidsepatu.TabIndex = 16;
            // 
            // Txb_OnamaSepatu
            // 
            this.Txb_OnamaSepatu.Location = new System.Drawing.Point(100, 82);
            this.Txb_OnamaSepatu.Name = "Txb_OnamaSepatu";
            this.Txb_OnamaSepatu.Size = new System.Drawing.Size(678, 20);
            this.Txb_OnamaSepatu.TabIndex = 17;
            // 
            // Txb_OwarnaSepatu
            // 
            this.Txb_OwarnaSepatu.Location = new System.Drawing.Point(100, 108);
            this.Txb_OwarnaSepatu.Name = "Txb_OwarnaSepatu";
            this.Txb_OwarnaSepatu.Size = new System.Drawing.Size(678, 20);
            this.Txb_OwarnaSepatu.TabIndex = 18;
            // 
            // Txb_OukuranSepatu
            // 
            this.Txb_OukuranSepatu.Location = new System.Drawing.Point(100, 131);
            this.Txb_OukuranSepatu.Name = "Txb_OukuranSepatu";
            this.Txb_OukuranSepatu.Size = new System.Drawing.Size(678, 20);
            this.Txb_OukuranSepatu.TabIndex = 19;
            // 
            // Txb_OstockSepatu
            // 
            this.Txb_OstockSepatu.Location = new System.Drawing.Point(100, 157);
            this.Txb_OstockSepatu.Name = "Txb_OstockSepatu";
            this.Txb_OstockSepatu.Size = new System.Drawing.Size(678, 20);
            this.Txb_OstockSepatu.TabIndex = 20;
            // 
            // Txb_OhargaPenjualan
            // 
            this.Txb_OhargaPenjualan.Location = new System.Drawing.Point(100, 182);
            this.Txb_OhargaPenjualan.Name = "Txb_OhargaPenjualan";
            this.Txb_OhargaPenjualan.Size = new System.Drawing.Size(678, 20);
            this.Txb_OhargaPenjualan.TabIndex = 21;
            // 
            // Txb_OhargaPembelian
            // 
            this.Txb_OhargaPembelian.Location = new System.Drawing.Point(100, 205);
            this.Txb_OhargaPembelian.Name = "Txb_OhargaPembelian";
            this.Txb_OhargaPembelian.Size = new System.Drawing.Size(678, 20);
            this.Txb_OhargaPembelian.TabIndex = 22;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(669, 232);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 32);
            this.Btn_Save.TabIndex = 23;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_dataSepatuBaru
            // 
            this.Lbl_dataSepatuBaru.AutoSize = true;
            this.Lbl_dataSepatuBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dataSepatuBaru.Location = new System.Drawing.Point(12, 19);
            this.Lbl_dataSepatuBaru.Name = "Lbl_dataSepatuBaru";
            this.Lbl_dataSepatuBaru.Size = new System.Drawing.Size(154, 20);
            this.Lbl_dataSepatuBaru.TabIndex = 24;
            this.Lbl_dataSepatuBaru.Text = "Data Sepatu Baru";
            // 
            // FormInputSepatuBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_dataSepatuBaru);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txb_OhargaPembelian);
            this.Controls.Add(this.Txb_OhargaPenjualan);
            this.Controls.Add(this.Txb_OstockSepatu);
            this.Controls.Add(this.Txb_OukuranSepatu);
            this.Controls.Add(this.Txb_OwarnaSepatu);
            this.Controls.Add(this.Txb_OnamaSepatu);
            this.Controls.Add(this.Txb_Oidsepatu);
            this.Controls.Add(this.Lbl_hargaPembelian);
            this.Controls.Add(this.Lbl_hargaPenjualan);
            this.Controls.Add(this.Lbl_stockSepatu);
            this.Controls.Add(this.Lbl_UkuranSepatu);
            this.Controls.Add(this.Lbl_warnaSepatu);
            this.Controls.Add(this.Lbl_namaSepatu);
            this.Controls.Add(this.Lbl_idSepatu);
            this.Controls.Add(this.dgwDataSepatu);
            this.Controls.Add(this.Btn_back);
            this.Name = "FormInputSepatuBaru";
            this.Text = "FormInputSepatuBaru";
            this.Load += new System.EventHandler(this.FormInputSepatuBaru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataSepatu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.DataGridView dgwDataSepatu;
        private System.Windows.Forms.Label Lbl_idSepatu;
        private System.Windows.Forms.Label Lbl_namaSepatu;
        private System.Windows.Forms.Label Lbl_warnaSepatu;
        private System.Windows.Forms.Label Lbl_UkuranSepatu;
        private System.Windows.Forms.Label Lbl_stockSepatu;
        private System.Windows.Forms.Label Lbl_hargaPenjualan;
        private System.Windows.Forms.Label Lbl_hargaPembelian;
        private System.Windows.Forms.TextBox Txb_Oidsepatu;
        private System.Windows.Forms.TextBox Txb_OnamaSepatu;
        private System.Windows.Forms.TextBox Txb_OwarnaSepatu;
        private System.Windows.Forms.TextBox Txb_OukuranSepatu;
        private System.Windows.Forms.TextBox Txb_OstockSepatu;
        private System.Windows.Forms.TextBox Txb_OhargaPenjualan;
        private System.Windows.Forms.TextBox Txb_OhargaPembelian;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_dataSepatuBaru;
    }
}