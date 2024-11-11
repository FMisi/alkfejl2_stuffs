using Kisallatok.Controller;

namespace Kisallatok.View
{
    public partial class DeleteKisallat : Form
    {
        private KisallatokController controller;

        public DeleteKisallat(KisallatokController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            string kisallatNev = nevTextBox.Text;

            if (!string.IsNullOrWhiteSpace(kisallatNev))
            {
                bool result = controller.DeleteKisallat(kisallatNev);

                if (result)
                {
                    MessageBox.Show("A kisallat sikeresen torolve lett!", "Torles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nem talalhato kisallat ezzel a nevvel.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kerlek add meg a kisallat nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
