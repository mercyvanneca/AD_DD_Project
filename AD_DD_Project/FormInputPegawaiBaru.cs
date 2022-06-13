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
    public partial class FormInputPegawaiBaru : Form
    {
        public FormInputPegawaiBaru()
        {
            InitializeComponent();
        }
        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInputPegawaiBaru_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM PEGAWAI;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwDataPegawai.DataSource = dgw;
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
                sqlQuery = "insert INTO PEGAWAI (ID_PEGAWAI, ID_TOKO, NAMA_PEGAWAI, EMAIL_PEGAWAI,  TELP_PEGAWAI,  ALAMAT_PEGAWAI,  GENDER_PEGAWAI,   LVL_PEGAWAI,  PASSWORD_LOGIN) values ('" + Txb_OidPegawai.Text + "','" + Txb_OIdtoko.Text + "','" + txb_NamPegawai.Text + "','" + Txb_OEmailPegawai.Text + "','" + Txb_telpPegawai.Text + "','" + Txb_OalamatPegawai.Text + "','" + Txb_OgenderPegawai.Text + "','" + Txb_OlvlPegawai.Text + "','" + txb_OPasswordLogin.Text + "');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data pegawai baru bernama " + txb_NamPegawai.Text + " berhasil diinput.");
                     
        }
    }
}
