using Kisallatok.DAO;
using Kisallatok.Controller;

namespace Kisallatok.View
{
    public partial class KisallatokApp : Form
    {
        private KisallatokController controller;
        public KisallatokApp()
        {
            InitializeComponent();
            controller = new KisallatokController(new DaoImpl());
        }

        private void kisallatAdd_Click(object sender, EventArgs e)
        {
            AddOrModifyKisallat addkisallatform = new AddOrModifyKisallat(controller);
            addkisallatform.ShowDialog();
        }

        private void kategoriaAdd_Click(object sender, EventArgs e)
        {
            AddKategoria addkategoriaform = new AddKategoria(controller);
            addkategoriaform.ShowDialog();
        }

        private void listKisallat_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;  // Frissítjük az adatforrást
            dataGridView.DataSource = controller.GetKisallatok();
            dataGridView.Visible = true;
        }
    }
}
