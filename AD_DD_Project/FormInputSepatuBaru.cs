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
    public partial class FormInputSepatuBaru : Form
    {
        public FormInputSepatuBaru()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInputSepatuBaru_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM SEPATU;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwDataSepatu.DataSource = dgw;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "insert INTO SEPATU (ID_SEPATU, NAMA_SEPATU, WARNA_SEPATU, UKURAN_SEPATU, STOCK_SEPATU, HARGA_PENJUALAN, HARGA_PEMBELIAN) values ('" + Txb_Oidsepatu.Text + "','" + Txb_OnamaSepatu.Text + "','" + Txb_OwarnaSepatu.Text + "','" + Txb_OukuranSepatu.Text + "', '" + Txb_OstockSepatu.Text + "','" + Txb_OhargaPenjualan.Text + "','" + Txb_OhargaPembelian.Text + "');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data sepatu baru bernama " + Txb_OnamaSepatu.Text + " berhasil diinput.");
        }
    }
}
