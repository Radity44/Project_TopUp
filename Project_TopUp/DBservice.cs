using Npgsql;
using System;

public class DatabaseHelper
{
    // Menggunakan atribut yang sudah didefinisikan
    private static readonly string dbHost = "localhost";
    private static readonly string dbDatabase = "SewaKamera";
    private static readonly string dbUsername = "postgres";
    private static readonly string dbPassword = "radity@";
    private static readonly string dbPort = "5432";

    // Koneksi dan perintah Npgsql
    private static NpgsqlConnection connection;
    private static NpgsqlCommand command;

    // Method untuk mendapatkan koneksi ke PostgreSQL
    public static NpgsqlConnection GetConnection()
    {
        // Membuat string koneksi
        string connString = $"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}";
        connection = new NpgsqlConnection(connString);
        return connection;
    }

    // Menjalankan query atau perintah ke database
    public static void ExecuteQuery(string query)
    {
        try
        {
            // Membuka koneksi
            connection.Open();
            command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
            Console.WriteLine("Query berhasil dijalankan!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
        finally
        {
            // Menutup koneksi
            connection.Close();
        }
    }
}
