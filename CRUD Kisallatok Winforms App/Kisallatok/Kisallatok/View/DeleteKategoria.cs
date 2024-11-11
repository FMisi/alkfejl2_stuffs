using Kisallatok.Controller;

namespace Kisallatok.View
{
    public partial class DeleteKategoria : Form
    {
        private KisallatokController controller;

        public DeleteKategoria(KisallatokController controller)
        {
            InitializeComponent();
            this.controller = controller;
            LoadKategoriak();
        }

        private void LoadKategoriak()
        {
            // A ComboBox betölti a kategóriák listáját a Controller-ből
            kategoriaComboBox.DataSource = controller.GetKategoriak().ToList();
            kategoriaComboBox.DisplayMember = "Nev"; // A kategória nevét jelenítjük meg
            kategoriaComboBox.ValueMember = "Nev"; // A kategória nevét használjuk az azonosításhoz
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            string? kategoriaNev = kategoriaComboBox.SelectedValue as string;

            if (string.IsNullOrEmpty(kategoriaNev))
            {
                MessageBox.Show("Kerem, valasszon egy kategoriat a torleshez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasAnimalsInCategory = controller.HasAnimalsInKategoria(kategoriaNev);

            if (hasAnimalsInCategory)
            {
                DialogResult result = MessageBox.Show("Ez a kategoria kisallatokat tartalmaz. Torles elott kerjuk, tavolitsa el a hozzaarrendelt kisallatokat!",
                                                      "Figyelmeztetes",
                                                      MessageBoxButtons.OKCancel,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            bool resultDelete = controller.DeleteKategoria(kategoriaNev);

            if (resultDelete)
            {
                MessageBox.Show("A kategoria sikeresen torolve lett!", "Torles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem talalhato kategoria ezzel a nevvel.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
