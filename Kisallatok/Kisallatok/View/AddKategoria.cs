using Kisallatok.Controller;
using Kisallatok.Model;

namespace Kisallatok.View
{
    public partial class AddKategoria : Form
    {
        private KisallatokController controller;

        public AddKategoria(KisallatokController controller)
        {
            this.controller = controller;
            InitializeComponent();
            // valamiComboBox.SelectedIndex = 0;
        }

        

        private void hozzaadasButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;

            Kategoria kategoria = new Kategoria()
            {
                Nev = nev,
            };

            bool result;
            result = controller.AddKategoria(kategoria);
            if (result == true)
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
