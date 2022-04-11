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

namespace Pratikum11April
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sebagai data koneksi ke DBMSnya
                                                                                // IP address/ localhost, user, password
        public MySqlCommand sqlCommand; // ngirim  query dari VS ke database gk terjadi di vs
        public MySqlDataAdapter sqlAdapter; // penampung hasil 
        public string sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtTeam2 = new DataTable();
        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            
            sqlQuery = "select t.team_name as 'Nama Tim',m.manager_name as 'Nama Manager', p.player_name as 'Captain', t.team_id as 'Tim Id', t.capacity as 'Capacity', concat(t.home_stadium, ', ', t.city) as 'Stadium' from team t, manager m, player p where m.manager_id = t.manager_id and t.team_id = p.team_id and t.captain_id = p.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTimHome.DataSource = dtTeam;

            
            sqlQuery = "select t.team_name as 'Nama Tim',m.manager_name as 'Nama Manager', p.player_name as 'Captain', t.team_id as 'Tim Id', t.capacity as 'Capacity', t.home_stadium as 'Stadium' from team t, manager m, player p where m.manager_id = t.manager_id and t.team_id = p.team_id and t.captain_id = p.player_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam2);
            cBoxTimLawan.DataSource = dtTeam2;

            cBoxTimHome.DisplayMember = "Nama Tim";
            cBoxTimHome.ValueMember = "Tim Id";
            
            cBoxTimLawan.DisplayMember = "Nama Tim";
            cBoxTimLawan.ValueMember = "Tim Id";

            lblManagerTimLawan.Text = dtTeam2.Rows[0]["Nama Manager"].ToString();
            lblCaptainTimLawan.Text = dtTeam2.Rows[0]["Captain"].ToString();

            lblCapacity.Text = dtTeam.Rows[0]["Capacity"].ToString();
            lblStadium.Text = dtTeam.Rows[0]["Stadium"].ToString();

        }

        private void cBoxTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblManagerTimHome.Text = dtTeam.Rows[cBoxTimHome.SelectedIndex]["Nama Manager"].ToString();
            lblCaptainTimHome.Text = dtTeam.Rows[cBoxTimHome.SelectedIndex]["Captain"].ToString();
            lblCapacity.Text = dtTeam.Rows[cBoxTimHome.SelectedIndex]["Capacity"].ToString();
            lblStadium.Text = dtTeam.Rows[cBoxTimHome.SelectedIndex]["Stadium"].ToString();


            // sampe sini


        }

        private void cBoxTimLawan_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblManagerTimLawan.Text = dtTeam2.Rows[cBoxTimLawan.SelectedIndex]["Nama Manager"].ToString();
            lblCaptainTimLawan.Text = dtTeam2.Rows[cBoxTimLawan.SelectedIndex]["Captain"].ToString();
        }
    }
}
