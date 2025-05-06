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
using Project_SewaKamera.App.Core;
using Project_SewaKamera.App.Model;
using Project_SewaKamera.App.Context;

namespace Project_SewaKamera
{

    public partial class FormDaftarSewa : Form
    {
        private int selectedId = -1;
        public FormDaftarSewa()
        {
            InitializeComponent();
            this.Load += FormDaftarSewa_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                DataGridViewRow row = daftarSewa.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSewa formSewa = new FormSewa();
            formSewa.Show();
        }

        private void FormDaftarSewa_Load(object sender, EventArgs e)
        {
            LoadDaftarSewa();
            daftarSewa.CellClick += daftarSewa_CellClick;
        }

        private void LoadDaftarSewa()
        {
            try
            {
                daftarSewa.AllowUserToAddRows = false;
                DataTable CustomerData = SewaContext.All();
                if (CustomerData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data customer");
                    return;
                }
                daftarSewa.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                daftarSewa.Columns.Add(nomorColumn);

                daftarSewa.DataSource = CustomerData;

                if (daftarSewa.Columns["Id"] != null)
                    daftarSewa.Columns["Id"].Visible = false;
                if (daftarSewa.Columns["Nama"] != null)
                    daftarSewa.Columns["Nama"].HeaderText = "Nama";
                if (daftarSewa.Columns["Barang"] != null)
                    daftarSewa.Columns["Barang"].HeaderText = "Jenis Kamera";
                if (daftarSewa.Columns["Durasi"] != null)
                    daftarSewa.Columns["Durasi"].HeaderText = "Durasi";
                if (daftarSewa.Columns["TanggalSewa"] != null)
                    daftarSewa.Columns["TanggalSewa"].HeaderText = "Tanggal Sewa";


                for (int i = 0; i < daftarSewa.Rows.Count; i++)
                {
                    daftarSewa.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Customer: {ex.Message}\n{ex.StackTrace}");
            }
            //try
            //{
            //    using (var conn = DBservice.GetConnection())
            //    {
            //        conn.Open();
            //        string query = "SELECT nama, barang, durasi, tanggal_sewa FROM sewa";
            //        using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
            //        using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
            //        {
            //            DataTable dt = new DataTable();
            //            adapter.Fill(dt);
            //            dataGridView1.DataSource = dt;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Gagal memuat data: " + ex.Message);
            //}
        }

        private void daftarSewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = daftarSewa.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }



        private void FormDaftarSewa_Load_1(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Silakan pilih data yang akan diubah.");
                return;
            }

            MessageBox.Show("Edit ID: " + selectedId);

            FormSewa formEdit = new FormSewa(selectedId); // kirim ID ke FormSewa
            formEdit.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            if (selectedId == -1)
            {
                MessageBox.Show("Silakan pilih data yang akan dihapus.");
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    SewaContext.DeleteDataSewa(selectedId);
                    LoadDaftarSewa(); // Refresh data
                    MessageBox.Show("Data berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message);
                }
            }
        }
    }
}
