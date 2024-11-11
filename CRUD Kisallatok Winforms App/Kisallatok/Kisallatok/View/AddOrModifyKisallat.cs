using Kisallatok.Controller;
using Kisallatok.Model;
using IdGen;

namespace Kisallatok.View
{
    public partial class AddOrModifyKisallat : Form
    {
        private KisallatokController controller;
        private Kisallat? kisallat;
        private readonly bool isModification = false;
        private readonly long kisallatID;

        public AddOrModifyKisallat(KisallatokController controller)
        {
            this.controller = controller;
            this.kisallat = new Kisallat();
            InitializeComponent();
            LoadKategoriak();
        }
        public AddOrModifyKisallat(KisallatokController controller, Kisallat kisallat) : this (controller)
        {
            isModification = true;
            this.kisallat = kisallat;
            kisallatID = kisallat.ID;

            LoadKisallatData();

            hozzaadasButton.Text = "Modositas";
        }


        private void LoadKisallatData()
        {
            // Töltsük ki az űrlapot a meglévő kisállat adataival
            if (kisallat != null)
            {
                nevTextBox.Text = kisallat.Nev;
                nostenyRadioButton.Checked = kisallat.Nem == "nosteny";
                himRadioButton.Checked = kisallat.Nem == "him";
                eletkorNumericUpDown.Value = kisallat.Eletkor;
                sulyNumericUpDown.Value = kisallat.Suly;
                kategoriaComboBox.SelectedItem = kisallat.Kategoria;
            }
            else
            {
                MessageBox.Show("A kisallatt erteke null.");
                return;
            }
        }

        private void LoadKategoriak()
        {
            kategoriaComboBox.DataSource = controller.GetKategoriak().ToList();
            kategoriaComboBox.DisplayMember = "Nev";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;

            string nem = "";

            if (nev == String.Empty)
            {
                MessageBox.Show("Nevet kotelezo megadni");
                return;
            }

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
                MessageBox.Show("Nemet kotelezo megadni");
                return;
            }


            decimal suly = (decimal)sulyNumericUpDown.Value;
            if (suly.Equals((decimal)0.0))
            {
                MessageBox.Show("Sulyt kotelezo megadni");
                return;
            }

            Kategoria? kategoria = kategoriaComboBox.SelectedItem as Kategoria;
            if (kategoria == null)
            {
                MessageBox.Show("Kategoriat kotelezo megadni");
                return;
            }

            int eletkor = (int)eletkorNumericUpDown.Value;

            IdGenerator generator = new IdGenerator(0);

            long id = generator.CreateId();

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

            if (isModification == true)
            {
                kisallat.ID = kisallatID;
                result = controller.ModifyKisallat(kisallat);
            }
            else
            {
                result = controller.AddKisallat(kisallat);
            }

            if (result)
            {
                hozzaadasButton.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem sikerult elmenteni");
                DialogResult = DialogResult.Abort;
            }
        }

        private void megseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrModifyKisallat_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Resources/myIcon.ico");
        }
    }
}
