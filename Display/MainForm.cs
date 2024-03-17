namespace Display
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeChangeToTheCatalog_Click(object sender, EventArgs e)
        {
            ImproveOurCatalog improveOurCatalog = new ImproveOurCatalog();
            improveOurCatalog.Show();
        }

        private void btnCatalogNavigaton_Click(object sender, EventArgs e)
        {
            BookCatalogForm bookCatalogForm = new BookCatalogForm();
            bookCatalogForm.Show();
        }
    }
}