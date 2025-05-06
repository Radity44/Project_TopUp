using Npgsql;
using Project_SewaKamera;
using Project_SewaKamera.App.Core;
using Project_SewaKamera.App.Model;
using Project_SewaKamera.App.Context;

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
            cbxDurasi.SelectedIndex = -1; // default tidak ada yang dipilih
            dtpTanggalSewa.MinDate = DateTime.Today; // hindari pilih tanggal lalu
            //CheckInputValidity();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            //CheckInputValidity();
        }

        //private void CheckInputValidity()
        //{
        //    bool isNamaValid = !string.IsNullOrWhiteSpace(txtNama.Text);
        //    bool isBarangValid = !string.IsNullOrWhiteSpace(txtbarang.Text);
        //    bool isDurasiValid = !string.IsNullOrWhiteSpace(cbxDurasi.Text);
        //    bool isTanggalValid = dtpTanggalSewa.Value.Date >= DateTime.Today;

        //    btnSimpan.Enabled = isNamaValid && isBarangValid && isDurasiValid && isTanggalValid;

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtNama.Text)
                        && !string.IsNullOrWhiteSpace(txtbarang.Text)
                        && cbxDurasi.SelectedIndex != -1;

            // Validasi tanggal sewa tidak boleh sebelum hari ini
            if (dtpTanggalSewa.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Tanggal sewa tidak boleh di masa lalu.");
                return false;
            }

            return isValid;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon lengkapi semua data.");
                return;
            }

            var dataSewa = new M_Sewa
            {
                Nama = txtNama.Text.Trim(),
                Barang = txtbarang.Text.Trim(),
                Durasi = cbxDurasi.SelectedItem.ToString(),
                TanggalSewa = dtpTanggalSewa.Value
            };

            try
            {
                SewaContext.AddDataSewa(dataSewa);
                MessageBox.Show("Data berhasil disimpan!");

                FormDaftarSewa formDaftar = new FormDaftarSewa();
                formDaftar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " + ex.Message);
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
            //CheckInputValidity();
        }

        private void txtbarang_TextChanged(object sender, EventArgs e)
        {
            //CheckInputValidity();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //CheckInputValidity();
        }

        private void FormSewa_Load(object sender, EventArgs e)
        {
            cbxDurasi.SelectedIndex = -1; // default tidak ada yang dipilih
            dtpTanggalSewa.MinDate = DateTime.Today; // hindari pilih tanggal lalu
            //CheckInputValidity();
        }

    }
}
