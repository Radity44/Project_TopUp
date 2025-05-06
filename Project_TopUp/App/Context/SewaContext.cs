using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_SewaKamera.App.Core;
using Project_SewaKamera.App.Model;
using System.Data;



namespace Project_SewaKamera.App.Context
{
    public class SewaContext : DBservice
    {
        private static string table = "sewa";

        public static DataTable All()
        {
            string query = $@"select * from {table}";

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable datasewa = new DataTable();
                    datasewa.Load(reader); // Memuat data dari DataReader ke DataTable
                    return datasewa;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in Customer.Context.All(): {ex.Message}", ex);
            }
        }

        public static void AddDataSewa(M_Sewa SewaBaru)
        {
            string query = $"INSERT INTO {table} (nama, barang, durasi, tanggal_sewa) VALUES (@nama, @barang, @durasi, @tanggalsewa)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", SewaBaru.Nama),
                new NpgsqlParameter("@barang", SewaBaru.Barang),
                new NpgsqlParameter("@durasi", SewaBaru.Durasi),
                new NpgsqlParameter("@tanggalsewa", SewaBaru.TanggalSewa)
            };




            commandExecutor(query, parameters);
        }

        public static void DeleteDataSewa(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };
            commandExecutor(query, parameters);
        }

        public static void UpdateDataSewa(M_Sewa data)
        {
            string query = $@"
                UPDATE {table}
                SET nama = @nama, barang = @barang, durasi = @durasi, tanggal_sewa = @tanggalsewa
                WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", data.Id),
                new NpgsqlParameter("@nama", data.Nama),
                new NpgsqlParameter("@barang", data.Barang),
                new NpgsqlParameter("@durasi", data.Durasi),
                new NpgsqlParameter("@tanggalsewa", data.TanggalSewa)
            };

            commandExecutor(query, parameters);
        }

        public static M_Sewa GetById(int id)
        {
            using (var conn = DBservice.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nama, barang, durasi, tanggal_sewa FROM sewa WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new M_Sewa
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Nama = reader.GetString(reader.GetOrdinal("nama")),
                                Barang = reader.GetString(reader.GetOrdinal("barang")),
                                Durasi = reader.GetString(reader.GetOrdinal("durasi")),
                                TanggalSewa = reader.GetDateTime(reader.GetOrdinal("tanggal_sewa"))
                            };
                        }
                    }
                }
            }
            return null;
        }


    }
}
