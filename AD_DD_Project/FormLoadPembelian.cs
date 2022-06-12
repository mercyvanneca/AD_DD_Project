﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AD_DD_Project
{
    public partial class FormLoadPembelian : Form
    {
        public FormLoadPembelian()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Supplier = new DataTable();
        DataTable Sepatu = new DataTable();
        DataTable dtSepatuYangDibeli = new DataTable();
        DataTable masukdatabase = new DataTable();
        DataTable masukdatabase2 = new DataTable();
        DataTable masukdatabase3 = new DataTable();

        public static int indexidnotasekarang = 0;
        public static int Quantity;
        public static string statuslunasbelum;
        public static string supplier;
        public static string hargasatuan;
        public static string hargatotal;
        public static string hargatotal2;
        public static string idsepatu;
        public static string idpegawai;
        public static string tglpembelian;
        public static string namasepatu;

        private void FormLoadPembelian_Load(object sender, EventArgs e)
        {
            sqlQuery = "select ID_SUPPLIER, NAMA_SUPPLIER FROM SUPPLIER;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Supplier);
            cBoxSupplier.DataSource = Supplier;
            cBoxSupplier.DisplayMember = "NAMA_SUPPLIER";
            cBoxSupplier.ValueMember = "ID_SUPPLIER";

            sqlQuery = "select ID_SEPATU,CONCAT(NAMA_SEPATU,' Uk. ' ,UKURAN_SEPATU) as `NAMA_SEPATU` ,  STOCK_SEPATU, HARGA_PEMBELIAN FROM SEPATU;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Sepatu);
            cBoxIDSepatu.DataSource = Sepatu;

            cBoxIDSepatu.DisplayMember = "NAMA_SEPATU";
            cBoxIDSepatu.ValueMember = "ID_SEPATU";


        }

        public void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            int posisiIndex = cBoxIDSepatu.SelectedIndex;
            lblHargaSatuan.Text = Sepatu.Rows[posisiIndex]["HARGA_PEMBELIAN"].ToString();

            int HargaBeli = Convert.ToInt32(lblHargaSatuan.Text);
            Quantity = Convert.ToInt32(numQuantity.Value);
            int TotalBeli = HargaBeli * Quantity;
            lblTotalHarga.Text = TotalBeli.ToString();

            hargatotal2 = lblHargaSatuan.Text;
            hargatotal = lblTotalHarga.Text;

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (rBtnLunas.Checked)
            {
                statuslunasbelum = "Lunas";
            }
            else if (rBtnBelumLunas.Checked)
            {
                statuslunasbelum = "Belum Lunas";
            }
            //menunjukan penambahan stok sepatu secara otomatis
            sqlQuery = "SELECT ID_SEPATU, STOCK_SEPATU FROM SEPATU WHERE ID_SEPATU = '" + cBoxIDSepatu.SelectedValue.ToString() + "'";
            sqlCommand =   new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSepatuYangDibeli);
            int stokSekarang = Convert.ToInt16(dtSepatuYangDibeli.Rows[0][1]);
            int totalStok = stokSekarang + Convert.ToInt16(numQuantity.Value);

            sqlConnect.Open();
            sqlQuery = "UPDATE SEPATU SET STOCK_SEPATU = " + totalStok.ToString() + " WHERE ID_SEPATU = '"+cBoxIDSepatu.SelectedValue.ToString()+"' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();


            //ISI DATA TABLE NOTA_PEMBELIAN

            //ini untuk upddate idnotapembeli
            sqlQuery = "select ID_NOTA_PEMBELIAN, ID_SUPPLIER, ID_PEGAWAI, TGL_PEMBELIAN,TOTAL_HARGA_PEMBELIAN,STATUS_PEMBELIAN from NOTA_PEMBELIAN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase);
            indexidnotasekarang = masukdatabase.Rows.Count - 1;
            int index = indexidnotasekarang;
            int idnotabelisekarang2 = masukdatabase.Rows.Count + 1;
            string idnotabelitambah = "NB00" + idnotabelisekarang2.ToString();

            //idsepatu berdasarkan combobox id sepatu yang di pilih
            sqlQuery = "select ID_SEPATU, NAMA_SEPATU from SEPATU WHERE ID_SEPATU = '" + cBoxIDSepatu.SelectedValue + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase2);
            idsepatu = masukdatabase2.Rows[0][0].ToString();

            sqlQuery = "SELECT ID_PEGAWAI, NAMA_PEGAWAI FROM PEGAWAI WHERE NAMA_PEGAWAI = '" + FormLogin.namaPegawai + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase3);
            idpegawai = masukdatabase3.Rows[0][0].ToString();

            sqlConnect.Open();
            sqlQuery = "insert into NOTA_PEMBELIAN (ID_NOTA_PEMBELIAN, ID_SUPPLIER, ID_PEGAWAI, TGL_PEMBELIAN,TOTAL_HARGA_PEMBELIAN,STATUS_PEMBELIAN) VALUES ('" + idnotabelitambah + "','" + idsepatu + "','" + idpegawai + "',curdate(),'" + hargatotal + "','" + statuslunasbelum + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            supplier = cBoxSupplier.Text;
            sqlConnect.Close();

            //ISI DATA TABLE DETAIL_PEMBELIAN
            sqlConnect.Open();
            sqlQuery = "insert into DETAIL_PEMBELIAN (ID_SEPATU, ID_NOTA_PEMBELIAN, QTY_PEMBELIAN, HARGA_PEMBELIAN,TGL_PEMBELIAN) VALUES ('" + idsepatu + "','" + idnotabelitambah + "','" + numQuantity.Value + "','" + hargatotal2 + "',curdate());";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            
            namasepatu = cBoxIDSepatu.Text;
            Form formcetaknota = new FormNotaPembelian();
            formcetaknota.Show();
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form formhistory = new FormHistoryPembelian();
            formhistory.Show();
            this.Visible = false;
        }
    }
}
