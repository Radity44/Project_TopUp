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
    }
}
