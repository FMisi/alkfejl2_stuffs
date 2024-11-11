using IdGen;
using Kisallatok.Model;
using System.Data.SQLite;
using System.Text;

namespace Kisallatok.DAO
{
    internal class DaoAdoImpl : Dao
    {
        private const string CONN_STRING = @"Data Source=../../../../DB/kisallatok.db;";

        public bool AddKategoria(Kategoria kategoria)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = "INSERT INTO Kategoriak (Nev) VALUES (@Nev)";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Nev", kategoria.Nev);

            return command.ExecuteNonQuery() > 0;
        }

        public bool AddKisallat(Kisallat kisallat)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = @"INSERT INTO Kisallatok (ID, Nev, Nem, Eletkor, Suly, Kategoria)
                         VALUES (@ID, @Nev, @Nem, @Eletkor, @Suly, @Kategoria)";
            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@ID", kisallat.ID);
            command.Parameters.AddWithValue("@Nev", kisallat.Nev);
            command.Parameters.AddWithValue("@Nem", kisallat.Nem);
            command.Parameters.AddWithValue("@Eletkor", kisallat.Eletkor);
            command.Parameters.AddWithValue("@Suly", kisallat.Suly);
            command.Parameters.AddWithValue("@Kategoria", kisallat.Kategoria);

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ret = false;
            }

            return ret;
        }

        public IEnumerable<Kategoria> GetKategoriak()
        {
            List<Kategoria> kategoriak = new List<Kategoria>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = "SELECT Nev FROM Kategoriak";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                kategoriak.Add(new Kategoria
                {
                    Nev = reader.GetString(reader.GetOrdinal("Nev"))
                });
            }

            return kategoriak;
        }

        public Kisallat? GetKisallat(long kisallatID)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = "SELECT * FROM Kisallatok WHERE ID = @ID";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", kisallatID);

            using SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Kisallat
                {
                    ID = reader.GetInt64(reader.GetOrdinal("ID")),
                    Nev = reader.GetString(reader.GetOrdinal("Nev")),
                    Nem = reader.GetString(reader.GetOrdinal("Nem")),
                    Eletkor = reader.GetInt32(reader.GetOrdinal("Eletkor")),
                    Suly = reader.GetDecimal(reader.GetOrdinal("Suly")),
                    Kategoria = reader.GetString(reader.GetOrdinal("Kategoria"))
                };
            }

            return null;
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            List<Kisallat> kisallatok = new List<Kisallat>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Kisallatok";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                kisallatok.Add(new Kisallat
                {
                    ID = reader.GetInt64(reader.GetOrdinal("ID")),
                    Nev = reader.GetString(reader.GetOrdinal("Nev")),
                    Nem = reader.GetString(reader.GetOrdinal("Nem")),
                    Eletkor = reader.GetInt32(reader.GetOrdinal("Eletkor")),
                    Suly = reader.GetDecimal(reader.GetOrdinal("Suly")),
                    Kategoria = reader.GetString(reader.GetOrdinal("Kategoria"))
                });
            }

            return kisallatok;
        }

        public int KisallatokCount()
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = "SELECT COUNT(*) FROM Kisallatok";
            using SQLiteCommand command = new SQLiteCommand(query, connection);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool ModifyKisallat(Kisallat kisallat)
        {
            MessageBox.Show("ModifyKisallat meghivva");

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = @"UPDATE Kisallatok 
                         SET Nev = @Nev, Nem = @Nem, Eletkor = @Eletkor, Suly = @Suly, Kategoria = @Kategoria
                         WHERE ID=@ID";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", kisallat.ID);
            command.Parameters.AddWithValue("@Nev", kisallat.Nev);
            command.Parameters.AddWithValue("@Nem", kisallat.Nem);
            command.Parameters.AddWithValue("@Eletkor", kisallat.Eletkor);
            command.Parameters.AddWithValue("@Suly", kisallat.Suly);
            command.Parameters.AddWithValue("@Kategoria", kisallat.Kategoria);

            bool ret = true;
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Kisallat ID {kisallat.ID} sikeresen modositva!");
                    return ret;
                }
                else
                {
                    MessageBox.Show($"Nem tortent modositas, az ID {kisallat.ID} nem talalhato.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a modositas soran: {ex.Message}");
                return false;
            }
        }

        public bool ExportaljadAzonnal()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Mentes .txt fajlba";
                saveFileDialog.DefaultExt = "txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // A kisallatok adatainak lekerese az adatbebol
                        IEnumerable<Kisallat> kisallatok = GetKisallatok();

                        // A kisallatok kiiratasa tetszoleges .txt fajlba
                        using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                        {
                            foreach (Kisallat kisallat in kisallatok)
                            {
                                writer.WriteLine($"ID: {kisallat.ID}");
                                writer.WriteLine($"Nev: {kisallat.Nev}");
                                writer.WriteLine($"Nem: {kisallat.Nem}");
                                writer.WriteLine($"Eletkor: {kisallat.Eletkor}");
                                writer.WriteLine($"Suly: {kisallat.Suly}");
                                writer.WriteLine($"Kategoria: {kisallat.Kategoria}");
                                writer.WriteLine(new string('-', 30)); // Elvalaszto vonal
                            }
                        }

                        MessageBox.Show("A kisallatok sikeresen mentve lettek!", "Rendben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba tortent a mentes soran: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return false;
        }

        public bool DeleteKisallat(long id)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = @"DELETE FROM Kisallatok WHERE ID = @ID";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

            bool ret = true;
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Kisallat a(z) {id} ID-val sikeresen torolve!");
                    return ret;
                }
                else
                {
                    MessageBox.Show($"Nem tortent torles, a(z) {id} ID-val nem talalhato.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a modositas soran: {ex.Message}");
                return false;
            }
        }

        public bool HasAnimalsInKategoria(string kategoriaNev)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = "SELECT COUNT(*) FROM Kisallatok WHERE Kategoria = @Kategoria";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Kategoria", kategoriaNev);

            int count = Convert.ToInt32(command.ExecuteScalar());

            bool ret = true;
            if (count <= 0)
            {
                return false;
            }

            return ret; // Ha van
        }

        public bool DeleteKategoria(string kategoriaNev)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            string query = @"DELETE FROM Kategoriak WHERE Nev = @Kategoria";
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Kategoria", kategoriaNev);

            bool ret = true;
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{kategoriaNev} Kategoria sikeresen torolve!");
                    return ret;
                }
                else
                {
                    MessageBox.Show($"Nem tortent torles, a(z) {kategoriaNev} Kategoria nem talalhato.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a modositas soran: {ex.Message}");
                return false;
            }
        }
    }
}
