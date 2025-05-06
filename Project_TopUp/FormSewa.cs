using Npgsql;
using Project_SewaKamera;

namespace Project_TopUp
{
    public partial class FormSewa : Form
    {
        public FormSewa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string barang = txtbarang.Text.Trim();
            string durasi = cbxDurasi.SelectedItem?.ToString();
            DateTime tanggalSewa = dtpTanggalSewa.Value;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(barang) || string.IsNullOrEmpty(durasi))
            {
                MessageBox.Show("Mohon lengkapi semua data.");
                return;
            }

            string query = "INSERT INTO sewa (nama, barang, durasi, tanggal_sewa) " +
                           "VALUES (@nama, @barang, @durasi, @tanggal)";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("barang", barang);
                        cmd.Parameters.AddWithValue("durasi", durasi);
                        cmd.Parameters.AddWithValue("tanggal", tanggalSewa);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil disimpan!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.ToString());
            }
        }


        private void btnlihat_Click(object sender, EventArgs e)
        {
            FormDaftarSewa daftar = new FormDaftarSewa();
            daftar.Show();
            this.Hide();
        }

        private void cbxDurasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtNama.Clear();
            txtbarang.Clear();
            cbxDurasi.SelectedIndex = 0; // Atur ke pilihan pertama
            dtpTanggalSewa.Value = DateTime.Now; // Reset tanggal ke hari ini
        }

    }
}
