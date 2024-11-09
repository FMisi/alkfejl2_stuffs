using Kisallatok.Model;
using System.Text;

namespace Kisallatok.DAO
{
    public class DaoImpl : Dao
    {
        private IList<Kisallat> kisallatok = new List<Kisallat>();

        private IList<Kategoria> kategoriak = new List<Kategoria>();

        public bool AddKategoria(Kategoria kategoria)
        {
            if (kategoria == null) { return false; }

            // ha nem akarok ugyanolyan nevut hozzaadni:
            if (kategoriak.Any(x => x.Nev == kategoria.Nev)) { return false; }

            kategoriak.Add(kategoria);
            return true;
        }

        public bool AddKisallat(Kisallat kisallat)
        {
            if (kisallat == null) { return false; }

            // ha nem akarok ugyanolyan nevut hozzaadni:
            // if (kisallatok.Any(x => x.Nev == kisallat.Nev)) { return false; }

            kisallatok.Add(kisallat);
            return true;
        }

        public IEnumerable<Kategoria> GetKategoriak()
        {
            return kategoriak;
        }

        public Kisallat GetKisallat(long kisallatID)
        {
            return kisallatok.FirstOrDefault(x => x.ID == kisallatID);
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            return kisallatok;
        }

        public int KisallatokCount()
        {
            return kisallatok.Count;
        }

        public bool ModifyKisallat(Kisallat kisallat)
        {
            int storedIndex = kisallatok.IndexOf(kisallatok.FirstOrDefault(x => x.ID == kisallat.ID));

            if (storedIndex == -1) { return false; }

            kisallatok[storedIndex] = kisallat;

            return true;
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
                        // A kisallatok adatainak kiirasa a kivalasztott fajlba
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

                        MessageBox.Show("A kisállatok sikeresen mentve lettek!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return true;
        }
    }
}
