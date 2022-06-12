namespace AD_DD_Project
{
    partial class Form_HistoryPenjualan
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.dgwHistoryPenjualan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoryPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(12, 461);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 32);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "BACK";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // dgwHistoryPenjualan
            // 
            this.dgwHistoryPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistoryPenjualan.Location = new System.Drawing.Point(12, 23);
            this.dgwHistoryPenjualan.Name = "dgwHistoryPenjualan";
            this.dgwHistoryPenjualan.Size = new System.Drawing.Size(978, 432);
            this.dgwHistoryPenjualan.TabIndex = 1;
            // 
            // Form_HistoryPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 505);
            this.Controls.Add(this.dgwHistoryPenjualan);
            this.Controls.Add(this.Btn_Back);
            this.Name = "Form_HistoryPenjualan";
            this.Text = "Form History Penjualan";
            this.Load += new System.EventHandler(this.Form_HistoryPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoryPenjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView dgwHistoryPenjualan;
    }
}