using Npgsql;
using System.Data;
using System.Reflection;

namespace ResponsiJunProBFR
{
    public partial class Form1 : Form
    {

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();

        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=postgres";

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            dgvData.DataSource = null;
            sql = "select * from karyawan";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvData.DataSource = dt;
            conn.Close();
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "insert into karyawan (id_karyawan, nama, id_dep) values (" + tbID.Text + ",'" + tbNamaKaryawan.Text + "'," + tbDepKaryawan.Text + ")";
                cmd = new NpgsqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("_id_karyawan", tbID.Text);
                //cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                //cmd.Parameters.AddWithValue("_id_dep", tbDepKaryawan.Text);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                MessageBox.Show(sql);
                conn.Close();
            } catch
            {
                //lupa cara show exception 
            }
            
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //tidak jadi dipakai
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbID.Text = r.Cells["_id_karyawan"].Value.ToString();
        }
    }
}