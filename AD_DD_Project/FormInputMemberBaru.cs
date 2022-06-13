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
    public partial class FormInputMemberBaru : Form
    {
        public FormInputMemberBaru()
        {
            InitializeComponent();
        }
        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;


        private void Lbl_tglLahirPembeli_Click(object sender, EventArgs e)
        {

        }

        private void FormInputMemberBaru_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM MEMBER;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwDataMember.DataSource = dgw;
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
                sqlQuery = "insert INTO MEMBER (ID_PEMBELI, NAMA_PEMBELI, EMAIL_PEMBELI,  TELP_PEMBELI,  ALAMAT_PEMBELI,  GENDER_PEMBELI,   KOTA_PEMBELI,  TGL_LAHIR_PEMBELI) values ('" + Txb_OidPembeli.Text + "','" + Txb_OnamaPembeli.Text + "','" + Txb_OemailPembeli.Text + "','" + Txb_OtelpPembeli.Text + "', '" + Txb_OalamatPembeli.Text + "','" + Txb_OgenderPembeli.Text + "','" + Txb_OkotaPembeli.Text + "',,'" + txb_OtglLahirPembeli.Text + "');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data member baru bernama " + Txb_OnamaPembeli.Text + " berhasil diinput.");
            

        }
    }
}
