namespace prySilvaER4
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            dgvRegistro.Rows.Add("Julio");
            dgvRegistro.Rows.Add("Esteban");
            dgvRegistro.Rows.Add("Javier");
            dgvRegistro.Rows.Add("Gonzalo");
            dgvRegistro.Rows.Add("Alberto");


        }
    }
}
