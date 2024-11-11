using Kisallatok.DAO;
using Kisallatok.Controller;
using Kisallatok.Model;

namespace Kisallatok.View
{
    public partial class KisallatokApp : Form
    {
        private KisallatokController controller;
        public KisallatokApp()
        {
            InitializeComponent();
            controller = new KisallatokController(new DaoAdoImpl());
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
            dataGridView.DataSource = null;
            dataGridView.DataSource = controller.GetKisallatok();
            dataGridView.Visible = true;
        }

        private void DataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var kisallat = (Kisallat)dataGridView.Rows[e.RowIndex].DataBoundItem;
                AddOrModifyKisallat modifykisallatform = new AddOrModifyKisallat(controller, kisallat);

                if (modifykisallatform.ShowDialog() == DialogResult.OK)
                {
                    dataGridView.DataSource = controller.GetKisallatok().ToList();
                }
            }
        }

        private void exportaljadAzonnal_Click(object sender, EventArgs e)
        {
            controller.ExportaljadAzonnal();
        }

        private void KisallatokApp_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Resources/myIcon.ico");
            // Eseményfigyelõ hozzáadása a sorra kattintáshoz
            dataGridView.CellClick += DataGridView_CellClick;
        }

        private void kisallatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteKisallat deletekisallatform = new DeleteKisallat(controller);
            deletekisallatform.ShowDialog();
        }

        private void kategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteKategoria deletekategoriaform = new DeleteKategoria(controller);
            deletekategoriaform.ShowDialog();
        }
    }
}
