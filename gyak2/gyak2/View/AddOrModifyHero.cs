using gyak2.Controller;
using gyak2.Model;

namespace gyak2.View
{
    public partial class AddOrModifyHero : Form
    {
        private HeroesController controller;

        public AddOrModifyHero(HeroesController controller)
        {
            this.controller = controller;
            InitializeComponent();
            powerComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string heroName = heroNameTextBox.Text;
            string power = powerComboBox.SelectedItem.ToString();
            int age = (int)ageNumericUpDown.Value;

            if(name == String.Empty)
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
            result = controller.AddHero(hero);
            if (result)
            {
                addButton.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem sikerült elmenteni");
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
