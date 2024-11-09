using Kisallatok.Controller;
using Kisallatok.Model;
using IdGen;
using System.Linq;
using System.Drawing;

namespace Kisallatok.View
{
    public partial class AddOrModifyKisallat : Form
    {
        private KisallatokController controller;
        private Kisallat kisallat;

        public AddOrModifyKisallat(KisallatokController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadKategoriak();
            /*
            this.kisallat = kisallat ?? new Kisallat();
            if (kisallat != null)
            {
                LoadKisallatData();
            }*/
        }

        private void LoadKisallatData()
        {
            // Töltsük ki az űrlapot a meglévő kisállat adataival
            nevTextBox.Text = kisallat.Nev;
            nostenyRadioButton.Checked = kisallat.Nem == "him";
            himRadioButton.Checked = kisallat.Nem == "nosteny";
            eletkorNumericUpDown.Value = kisallat.Eletkor;
            sulyNumericUpDown.Value = kisallat.Suly;
            kategoriaComboBox.SelectedItem = kisallat.Kategoria;
        }

        private void LoadKategoriak()
        {
            kategoriaComboBox.DataSource = controller.GetKategoriak().ToList();
            kategoriaComboBox.DisplayMember = "Nev";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IdGenerator generator = new IdGenerator(0);
            long id = generator.CreateId();

            string nev = nevTextBox.Text;

            string nem = "";

            // a == true azert van ott, mert igy konnyebben tudom olvasni
            if (nostenyRadioButton.Checked == true)
            {
                nem = nostenyRadioButton.Text;
            }
            else if (himRadioButton.Checked == true)
            {
                nem = himRadioButton.Text;
            }
            else
            {
                MessageBox.Show("Nemet kötelező megadni");
                return;
            }

            int eletkor = (int)eletkorNumericUpDown.Value;

            decimal suly = (decimal)sulyNumericUpDown.Value;

            Kategoria kategoria = (Kategoria)kategoriaComboBox.SelectedItem;

            if (nev == String.Empty)
            {
                MessageBox.Show("Nevet kötelező megandi");
                return;
            }

            Kisallat kisallat = new Kisallat()
            {
                ID = id,
                Nev = nev,
                Nem = nem,
                Eletkor = eletkor,
                Suly = suly,
                Kategoria = kategoria.Nev
            };

            bool result;
            result = controller.AddKisallat(kisallat);
            if (result)
            {
                hozzaadasButton.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem sikerült elmenteni");
                DialogResult = DialogResult.Abort;
            }
            
        }

        private void megseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
