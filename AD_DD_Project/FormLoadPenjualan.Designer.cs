namespace AD_DD_Project
{
    partial class FormLoadPenjualan
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
            this.Btn_cetakpenjualan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_DiskonP = new System.Windows.Forms.ComboBox();
            this.Lbl_totalharga = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxIDSepatu = new System.Windows.Forms.TextBox();
            this.tBoxIDMember = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckMembership = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_HS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_HSDiskon = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.Btn_totalHarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_cetakpenjualan
            // 
            this.Btn_cetakpenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cetakpenjualan.Location = new System.Drawing.Point(273, 456);
            this.Btn_cetakpenjualan.Name = "Btn_cetakpenjualan";
            this.Btn_cetakpenjualan.Size = new System.Drawing.Size(75, 36);
            this.Btn_cetakpenjualan.TabIndex = 28;
            this.Btn_cetakpenjualan.Text = "Cetak";
            this.Btn_cetakpenjualan.UseVisualStyleBackColor = true;
            this.Btn_cetakpenjualan.Click += new System.EventHandler(this.Btn_cetakpenjualan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Penjualan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diskon";
            // 
            // CB_DiskonP
            // 
            this.CB_DiskonP.FormattingEnabled = true;
            this.CB_DiskonP.Location = new System.Drawing.Point(148, 216);
            this.CB_DiskonP.Name = "CB_DiskonP";
            this.CB_DiskonP.Size = new System.Drawing.Size(175, 21);
            this.CB_DiskonP.TabIndex = 29;
            this.CB_DiskonP.SelectedIndexChanged += new System.EventHandler(this.CB_DiskonP_SelectedIndexChanged);
            this.CB_DiskonP.SelectedValueChanged += new System.EventHandler(this.CB_DiskonP_SelectedValueChanged);
            // 
            // Lbl_totalharga
            // 
            this.Lbl_totalharga.AutoSize = true;
            this.Lbl_totalharga.Location = new System.Drawing.Point(145, 316);
            this.Lbl_totalharga.Name = "Lbl_totalharga";
            this.Lbl_totalharga.Size = new System.Drawing.Size(148, 13);
            this.Lbl_totalharga.TabIndex = 30;
            this.Lbl_totalharga.Text = ">-------------------------------------------<";
            this.Lbl_totalharga.Click += new System.EventHandler(this.Lbl_totalharga_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID Sepatu";
            // 
            // tBoxIDSepatu
            // 
            this.tBoxIDSepatu.Location = new System.Drawing.Point(148, 91);
            this.tBoxIDSepatu.Name = "tBoxIDSepatu";
            this.tBoxIDSepatu.Size = new System.Drawing.Size(175, 20);
            this.tBoxIDSepatu.TabIndex = 32;
            // 
            // tBoxIDMember
            // 
            this.tBoxIDMember.Location = new System.Drawing.Point(148, 140);
            this.tBoxIDMember.Name = "tBoxIDMember";
            this.tBoxIDMember.Size = new System.Drawing.Size(175, 20);
            this.tBoxIDMember.TabIndex = 34;
            this.tBoxIDMember.TextChanged += new System.EventHandler(this.tBoxIDMember_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID Member";
            // 
            // CheckMembership
            // 
            this.CheckMembership.AutoSize = true;
            this.CheckMembership.Location = new System.Drawing.Point(219, 117);
            this.CheckMembership.Name = "CheckMembership";
            this.CheckMembership.Size = new System.Drawing.Size(116, 17);
            this.CheckMembership.TabIndex = 35;
            this.CheckMembership.Text = "Punya Membership";
            this.CheckMembership.UseVisualStyleBackColor = true;
            this.CheckMembership.CheckedChanged += new System.EventHandler(this.CheckMembership_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(148, 176);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(175, 20);
            this.numQuantity.TabIndex = 38;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quantity";
            // 
            // Lbl_HS
            // 
            this.Lbl_HS.AutoSize = true;
            this.Lbl_HS.Location = new System.Drawing.Point(145, 253);
            this.Lbl_HS.Name = "Lbl_HS";
            this.Lbl_HS.Size = new System.Drawing.Size(148, 13);
            this.Lbl_HS.TabIndex = 40;
            this.Lbl_HS.Text = ">-------------------------------------------<";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Harga Satuan";
            // 
            // Lbl_HSDiskon
            // 
            this.Lbl_HSDiskon.AutoSize = true;
            this.Lbl_HSDiskon.Location = new System.Drawing.Point(145, 284);
            this.Lbl_HSDiskon.Name = "Lbl_HSDiskon";
            this.Lbl_HSDiskon.Size = new System.Drawing.Size(148, 13);
            this.Lbl_HSDiskon.TabIndex = 42;
            this.Lbl_HSDiskon.Text = ">-------------------------------------------<";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Harga Sebelum Diskon";
            // 
            // btn_History
            // 
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Location = new System.Drawing.Point(148, 456);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 36);
            this.btn_History.TabIndex = 43;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // Btn_totalHarga
            // 
            this.Btn_totalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_totalHarga.Location = new System.Drawing.Point(114, 369);
            this.Btn_totalHarga.Name = "Btn_totalHarga";
            this.Btn_totalHarga.Size = new System.Drawing.Size(145, 36);
            this.Btn_totalHarga.TabIndex = 44;
            this.Btn_totalHarga.Text = "Total Harga";
            this.Btn_totalHarga.UseVisualStyleBackColor = true;
            this.Btn_totalHarga.Click += new System.EventHandler(this.Btn_totalHarga_Click);
            // 
            // FormLoadPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 578);
            this.Controls.Add(this.Btn_totalHarga);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.Lbl_HSDiskon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbl_HS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CheckMembership);
            this.Controls.Add(this.tBoxIDMember);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxIDSepatu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_totalharga);
            this.Controls.Add(this.CB_DiskonP);
            this.Controls.Add(this.Btn_cetakpenjualan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormLoadPenjualan";
            this.Text = "FormLoadPenjualan";
            this.Load += new System.EventHandler(this.FormLoadPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_cetakpenjualan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_DiskonP;
        private System.Windows.Forms.Label Lbl_totalharga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxIDSepatu;
        private System.Windows.Forms.TextBox tBoxIDMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckMembership;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_HS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_HSDiskon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button Btn_totalHarga;
    }
}