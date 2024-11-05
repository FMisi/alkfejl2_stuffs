using Kisallatok.Controller;
using Kisallatok.Model;

namespace Kisallatok.View
{
    public partial class AddOrModifyKisallat : Form
    {
        private KisallatokController controller;

        public AddOrModifyKisallat(KisallatokController controller)
        {
            this.controller = controller;
            InitializeComponent();
            // valamiComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

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
            /*
            string power = powerComboBox.SelectedItem.ToString();

            int age = (int)ageNumericUpDown.Value;

            if (nev == String.Empty)
            {
                MessageBox.Show("Nevet kötelező megandi");
                return;
            }

            Hero hero = new Hero()
            {
                Name = name,
                HeroName = heroName,
                Power = power,
                Age = age

            };

            bool result;
            result = controller.Add(hero);
            if (result)
            {
                hozzaadasButton.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem sikerült elmenteni");
                DialogResult = DialogResult.Abort;
            }
            */
        }

        private void megseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
