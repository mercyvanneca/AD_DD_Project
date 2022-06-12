using System;
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
    public partial class FormLoadPenjualan : Form
    {
        public FormLoadPenjualan()
        {
            InitializeComponent();
        }


        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Sepatu = new DataTable();
        DataTable Member = new DataTable();
        DataTable Promosi = new DataTable();
        DataTable dtSepatuYangDijual = new DataTable();
        DataTable masukdatabase3 = new DataTable();
        DataTable masukdatabase4 = new DataTable();
        DataTable totalhargapenjualan = new DataTable();
        DataTable carimember = new DataTable();
        DataTable caridiskon = new DataTable();




        public static int Quantity;
        public static string hargatotal3;
        public static string hargatotal4;
        public static int indexidnotasekarang2 = 0;
        public static string idpembeli;
        public static string idpegawai;
        public static int hargatotal2;
        public static string IDNotaPenjualan;
        public static string namasepatu2;
        public static string member;
        public static string namapegawai;
        public static string besarpromosi;
        public static string namapembeli;
        public static int TotalJual;
        public static string HargaSatuan;
        public static int TotalHargaPenjualan;


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void FormLoadPenjualan_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT ID_SEPATU, NAMA_SEPATU, HARGA_PENJUALAN FROM SEPATU; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Sepatu);


            sqlQuery = "SELECT ID_PEMBELI, NAMA_PEMBELI FROM MEMBER;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Member);

            sqlQuery = "SELECT BESAR_PROMO, ID_PROMOSI FROM PROMOSI_DISKON; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Promosi);
            CB_DiskonP.DataSource = Promosi;
            CB_DiskonP.DisplayMember = "BESAR_PROMO";
            CB_DiskonP.ValueMember = "ID_PROMOSI";
            CB_DiskonP.SelectedIndex = -1;


        }

        public void IsiData(int Posisi)
        {
            tBoxIDSepatu.Text = Sepatu.Rows[0].ToString();
            tBoxIDMember.Text = Member.Rows[3].ToString();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {

            int posisiIndex = tBoxIDSepatu.Text.IndexOf("ID_SEPATU");
            Lbl_HS.Text = Sepatu.Rows[0]["HARGA_PENJUALAN"].ToString();

            int HargaJual = Convert.ToInt32(Lbl_HS.Text);
            Quantity = Convert.ToInt32(numQuantity.Value);
            TotalJual = HargaJual * Quantity;
            Lbl_HSDiskon.Text = TotalJual.ToString();

            hargatotal3 = Lbl_HS.Text;
           

            //UNTUK PEMOTONGAN TOTAL HARGA PENJUALAN  KHUSUS MEMBER DAN TIDAK MEMBER
            if (CheckMembership.Checked == true)
            {
                if (CB_DiskonP.SelectedItem.ToString() == "50%")
                {
                    int TotalHargaJual = TotalJual - (TotalJual * 10 / 100);
                    int TotalHargaJual1 =TotalHargaJual - (TotalHargaJual * 50 / 100);
                    Lbl_totalharga.Text = TotalHargaJual1.ToString();
                    hargatotal4 = Lbl_totalharga.Text;
                    TotalHargaPenjualan = Convert.ToInt32(hargatotal4);
                }
                else if (CB_DiskonP.SelectedItem.ToString() == "25%")
                {
                    int TotalHargaJual = TotalJual - (TotalJual * 10 / 100);
                    int TotalHargaJual1 = TotalHargaJual - (TotalHargaJual * 25 / 100);
                    Lbl_totalharga.Text = TotalHargaJual1.ToString();
                    hargatotal4 = Lbl_totalharga.Text;
                    TotalHargaPenjualan = Convert.ToInt32(hargatotal4);
                }

            }
            else
            {
                if (CB_DiskonP.SelectedItem.ToString() == "50%")
                {
                    int TotalHargaJual = TotalJual - (TotalJual * 50 / 100);
                    Lbl_totalharga.Text = TotalHargaJual.ToString();
                    hargatotal4 = Lbl_totalharga.Text;
                    TotalHargaPenjualan = Convert.ToInt32(hargatotal4);

                }
                else if (CB_DiskonP.SelectedItem.ToString() == "25%")
                {
                    int TotalHargaJual = TotalJual - (TotalJual * 25 / 100);
                    Lbl_totalharga.Text = TotalHargaJual.ToString();
                    hargatotal4 = Lbl_totalharga.Text;
                    TotalHargaPenjualan = Convert.ToInt32(hargatotal4);
                }
            }
        }

        private void CB_DiskonP_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQuantity.Enabled = true;
        }

        private void CheckMembership_CheckedChanged(object sender, EventArgs e)
        {
        

            if (CheckMembership.Checked == true)
            {
                tBoxIDMember.Enabled = true;
            }
            else
            {
                tBoxIDMember.Enabled = false;
            }

        
        }

        private void Lbl_totalharga_Click(object sender, EventArgs e)
        {

        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            Form formhistory = new Form_HistoryPenjualan();
            formhistory.Show();
            this.Visible = false;
        }

        private void tBoxIDMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_cetakpenjualan_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT ID_SEPATU, STOCK_SEPATU, NAMA_SEPATU FROM SEPATU WHERE ID_SEPATU = '" + tBoxIDSepatu.Text + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSepatuYangDijual);
            int stokSekarang2 = Convert.ToInt16(dtSepatuYangDijual.Rows[0]["STOCK_SEPATU"]);
            int totalStok = stokSekarang2 - Convert.ToInt16(numQuantity.Value);
            namasepatu2 = dtSepatuYangDijual.Rows[0][2].ToString();
            


            sqlConnect.Open();
            sqlQuery = "UPDATE SEPATU SET STOCK_SEPATU = " + totalStok.ToString() + " WHERE ID_SEPATU = '" + tBoxIDSepatu.Text + "' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            //ISI DATA TABLE NOTA_PENJUALAN
            sqlQuery = "select ID_NOTA_PENJUALAN, ID_PEGAWAI, ID_PROMOSI, TGL_PENJUALAN, TOTAL_HARGA_PENJUALAN from NOTA_PENJUALAN; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase3);
            indexidnotasekarang2 = masukdatabase3.Rows.Count + 1;
            int index = indexidnotasekarang2;
            int idnotajualsekarang2 = masukdatabase3.Rows.Count + 1;
            string idnotajualtambah = "NJ00" + idnotajualsekarang2.ToString();

            sqlQuery = "select ID_PEGAWAI, NAMA_PEGAWAI FROM PEGAWAI WHERE NAMA_PEGAWAI = '" + FormLogin.namaPegawai + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase4);
            idpegawai = masukdatabase4.Rows[0][0].ToString();


            if (CheckMembership.Checked == true)
            {

                sqlQuery = "SELECT ID_PEMBELI, NAMA_PEMBELI FROM MEMBER WHERE ID_PEMBELI = '" + tBoxIDMember.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(carimember);
                namapembeli = carimember.Rows[0][1].ToString();
                idpembeli = carimember.Rows[0][0].ToString();


            }

            sqlQuery = "select ID_SEPATU, HARGA_PENJUALAN FROM SEPATU WHERE ID_SEPATU = '" + tBoxIDSepatu.Text + "'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(totalhargapenjualan);
            hargatotal2 = Convert.ToInt32(totalhargapenjualan.Rows[0][1].ToString());
            HargaSatuan = totalhargapenjualan.Rows[0][1].ToString();



            sqlConnect.Open();
            sqlQuery = "insert into NOTA_PENJUALAN (ID_NOTA_PENJUALAN, ID_PEGAWAI, ID_PEMBELI, ID_PROMOSI, TGL_PENJUALAN,TOTAL_HARGA_PENJUALAN) VALUES ('" + idnotajualtambah + "','" + idpegawai + "', '" + idpembeli + "', '" + CB_DiskonP.SelectedValue.ToString() + "', curdate(), '"+ TotalHargaPenjualan + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            IDNotaPenjualan = tBoxIDMember.Text;
            sqlConnect.Close();

            //ISI DATA TABLE DETAIL_PENJUALAN
            sqlConnect.Open();
            sqlQuery = "insert into DETAIL_PENJUALAN (ID_SEPATU, ID_NOTA_PENJUALAN, QTY_JUAL, HARGA_PENJUALAN,TGL_PENJUALAN) VALUES ('" + tBoxIDSepatu.Text + "','" + idnotajualtambah + "','" + numQuantity.Value + "','" + Lbl_HS.Text + "',curdate());";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            

            Form formcetaknota = new FormNotaPenjualan();
            formcetaknota.Show();
            this.Visible = false;


        }

        private void CB_DiskonP_SelectedValueChanged(object sender, EventArgs e)
        {
          
           
        }

        private void Btn_totalHarga_Click(object sender, EventArgs e)
        {
            string diskon;
            double persendiskon;
            double sebelumdiskon;
            double hargasebenarnya;

            diskon = CB_DiskonP.Text.ToString();
            besarpromosi = diskon;
            diskon = diskon.Substring(0, 2);
          

            persendiskon = Convert.ToDouble(diskon) / 100;
            sebelumdiskon = Convert.ToDouble(Lbl_HSDiskon.Text);
            hargasebenarnya = sebelumdiskon - (sebelumdiskon * persendiskon);
            Lbl_totalharga.Text = hargasebenarnya.ToString();
            TotalHargaPenjualan = Convert.ToInt32(Lbl_totalharga.Text);
        }
    }
    
}
