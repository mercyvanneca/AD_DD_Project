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
    public partial class FormNotaPenjualan : Form
    {
        public FormNotaPenjualan()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        DataTable dtpromosi = new DataTable();
        private void FormNotaPenjualan_Load(object sender, EventArgs e)
        {
            

            lblTanggalPenjualan.Text = DateTime.Now.ToString();
            lbl_namPegawai.Text = FormLogin.namaPegawai.ToString();
            lbl_ouputnamaPem.Text = FormLoadPenjualan.namapembeli.ToString();
            lbl_namabarang.Text = FormLoadPenjualan.namasepatu2.ToString();
            Lbl_Quantity.Text = FormLoadPenjualan.Quantity.ToString();
            Lbl_BesarPromosi.Text = FormLoadPenjualan.besarpromosi.ToString();
            Lbl_HargaSatuan.Text = FormLoadPenjualan.HargaSatuan.ToString();
            Lbl_TotalHargaPenjualan.Text = FormLoadPenjualan.TotalHargaPenjualan.ToString();


        }

        private void lblIdPegawai_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
