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
            if (long.TryParse(idTextBox.Text, out long id))
            {
                bool result = controller.DeleteKisallat(id);

                if (result)
                {
                    MessageBox.Show("A kisallat sikeresen torolve lett!", "Torles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nem talalhato kisallat ezzel az ID-val.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ervenytelen ID!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
