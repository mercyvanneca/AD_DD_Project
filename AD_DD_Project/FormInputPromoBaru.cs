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
    public partial class FormInputPromoBaru : Form
    {
        public FormInputPromoBaru()
        {
            InitializeComponent();
        }
        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInputPromoBaru_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM PROMOSI_DISKON;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwDataPromosi.DataSource = dgw;
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
            sqlQuery = "insert INTO PROMOSI_DISKON (ID_PROMOSI, TGL_PROMOSI_DIBUKA, AKHIR_PROMOSI, BESAR_PROMO) values ('" + Txb_OidPromosi.Text + "','" + Txb_Otgl_PromosiDiBuka.Text + "','" + Txb_OAkhirPromosi.Text + "','" + Txb_OBesarPromo.Text + "');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data promo baru dengan ID: " + Txb_OidPromosi.Text + " berhasil diinput.");
            
        }
    }
}
