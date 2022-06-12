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
    public partial class Form_HistoryPenjualan : Form
    {
        public Form_HistoryPenjualan()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void Form_HistoryPenjualan_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT N.ID_NOTA_PENJUALAN, N.ID_PEGAWAI, N.ID_PEMBELI, D.QTY_JUAL, D.HARGA_PENJUALAN, N.ID_PROMOSI, N.TGL_PENJUALAN, N.TOTAL_HARGA_PENJUALAN FROM NOTA_PENJUALAN N, DETAIL_PENJUALAN D WHERE N.ID_NOTA_PENJUALAN = D.ID_NOTA_PENJUALAN GROUP BY ID_NOTA_PENJUALAN ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwHistoryPenjualan.DataSource = dgw;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form formback = new FormLoadPenjualan();
            formback.Show();
            this.Visible = false;
        }
    }
}
