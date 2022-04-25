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
                                                                                // IP address/ server(localhost), user, password,database
        public MySqlCommand sqlCommand; // ngirim  query dari VS ke database gk terjadi di vs
        public MySqlDataAdapter sqlAdapter; // penampung hasil query
        public string sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtTeam2 = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtMatchTanggal = new DataTable();



        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {

            sqlQuery = "select t.team_name as 'Nama Tim',m.manager_name as 'Nama Manager', p.player_name as 'Captain', t.team_id as 'Tim Id', t.capacity as 'Capacity', concat(t.home_stadium, ', ', t.city) as 'Stadium' " +
                "from team t, manager m, player p where m.manager_id = t.manager_id and t.team_id = p.team_id and t.captain_id = p.player_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTimHome.DataSource = dtTeam;
            cBoxTimHome.DisplayMember = "Nama Tim";
            cBoxTimHome.ValueMember = "Tim Id";

            sqlQuery = "select t.team_name as 'Nama Tim',m.manager_name as 'Nama Manager', p.player_name as 'Captain', t.team_id as 'Tim Id', t.capacity as 'Capacity', t.home_stadium as 'Stadium'  " +
                "from team t, manager m, player p where m.manager_id = t.manager_id and t.team_id = p.team_id and t.captain_id = p.player_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam2);
            cBoxTimLawan.DataSource = dtTeam2;
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
        }

        private void cBoxTimLawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblManagerTimLawan.Text = dtTeam2.Rows[cBoxTimLawan.SelectedIndex]["Nama Manager"].ToString();
            lblCaptainTimLawan.Text = dtTeam2.Rows[cBoxTimLawan.SelectedIndex]["Captain"].ToString();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            sqlQuery = "select d.minute, if(d.team_id = m.team_home, p.player_name, '') as 'Player Name 1' , if(d.type = 'CY', 'Yellow Card', if(d.type = 'CR','Red Card', if(d.type = 'GO', 'Goal', if(d.type = 'GP','Goal Penalty', if(d.type = 'GW','Own Goal', if(d.type = 'PM' , 'Penalty Miss',' ')))))) as 'Type 1',  if(d.team_id = m.team_away, p2.player_name,'') AS 'Player Name 2', if(d2.type = 'CY', 'Yellow Card', if(d2.type = 'CR','Red Card', if(d2.type = 'GO', 'Goal', if(d2.type = 'GP','Goal Penalty', if(d2.type = 'GW','Own Goal', if(d2.type = 'PM' , 'Penalty Miss','')))))) as 'Type 2' from dmatch d, `match` m, player p, player p2, dmatch d2, `match` m2 where d.match_id = m.match_id and p.player_id = d.player_id and d2.match_id = m2.match_id and p2.player_id = d2.player_id and m.team_home = '" + cBoxTimHome.SelectedValue.ToString() + "' and m.team_away = '" +cBoxTimLawan.SelectedValue.ToString()+"' and m2.team_home = '" + cBoxTimHome.SelectedValue.ToString() + "' and m2.team_away = '"+ cBoxTimLawan.SelectedValue.ToString() + "' group by d.minute; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgv_tanding.DataSource = dtMatch;
            

            sqlQuery = "select date_format(match_date, '%d %M %Y') as 'Tanggal', concat(goal_home, '-', goal_away) as 'Skor' from `match` where team_home ='"+ cBoxTimHome.SelectedValue.ToString() +"' and team_away = '"+cBoxTimLawan.SelectedValue.ToString() +"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchTanggal);
            lbl_tanggal.Text = dtMatchTanggal.Rows[0]["Tanggal"].ToString();
            lbl_skor.Text = dtMatchTanggal.Rows[0]["Skor"].ToString();
        }
    }
}
