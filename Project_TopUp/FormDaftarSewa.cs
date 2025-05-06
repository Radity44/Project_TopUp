using Project_TopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SewaKamera
{
    public partial class FormDaftarSewa : Form
    {
        public FormDaftarSewa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSewa formSewa = new FormSewa();
            formSewa.Show();
        }

        private void FormDaftarSewa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT nama, barang, durasi, tanggal_sewa FROM sewa";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }
    }
}
