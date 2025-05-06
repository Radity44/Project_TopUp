using Npgsql;
using System;
using System.Collections.Generic;

namespace Project_TopUp
{
    public class Sewa
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Barang { get; set; }
        public string Durasi { get; set; }
        public DateTime TanggalSewa { get; set; }
    }

    public static class SewaRepository
    {
        private static string connString = "Host=localhost;Port=5432;Username=postgres;Password=n0uN545.;Database=PBO_BarberMate";

        public static void InsertSewa(Sewa data)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO sewa (nama, barang, durasi, tanggal_sewa) VALUES (@nama, @barang, @durasi, @tanggal)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", data.Nama);
                    cmd.Parameters.AddWithValue("barang", data.Barang);
                    cmd.Parameters.AddWithValue("durasi", data.Durasi);
                    cmd.Parameters.AddWithValue("tanggal", data.TanggalSewa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Sewa> GetAll()
        {
            var list = new List<Sewa>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM sewa";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Sewa
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nama = reader["nama"].ToString(),
                            Barang = reader["barang"].ToString(),
                            Durasi = reader["durasi"].ToString(),
                            TanggalSewa = Convert.ToDateTime(reader["tanggal_sewa"])
                        });
                    }
                }
            }
            return list;
        }

        // Buat juga UpdateSewa(...) dan DeleteSewa(int id) sesuai kebutuhan
    }
}
