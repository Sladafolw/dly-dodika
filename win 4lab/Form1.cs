namespace win_4lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text mdiChild = new Text();
            mdiChild.MdiParent = this; mdiChild.Show();
           Translate mdiChild2 = new ();
            mdiChild2.MdiParent = this; mdiChild2.Show();
            mdiChild.translate= mdiChild2; this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void horizantalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}