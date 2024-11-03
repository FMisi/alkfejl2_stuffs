using gyak2.Controller;
using gyak2.DAO;

namespace gyak2.View
{
    public partial class HeroesApp : Form
    {
        private HeroesController controller;
        public HeroesApp()
        {
            InitializeComponent();
            controller = new HeroesController(new HeroesMemoryDao());
        }

        private void listHeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = controller.GetHeroes();
            dataGridView.Visible = true;
        }

        private void addHeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrModifyHero addheroform = new AddOrModifyHero(controller);
            addheroform.ShowDialog();

        }
    }
}
