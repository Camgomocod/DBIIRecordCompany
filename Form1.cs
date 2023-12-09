using DBIIRecordCompany.logica;

namespace DBIIRecordCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresa empresa = new Empresa();

        private void mensajeGeneral(int r)
        {
            if (r > 0)
            {
                MessageBox.Show("Persona registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Persona no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEmpresaGuardar_Click(object sender, EventArgs e)
        {
            int empresaId, r = 0;
            string empresaNombre, empresaTipo = "Subsidiaria";
            empresaId = int.Parse(txtEmpresaId.Text);
            empresaNombre = txtEmpresaNombre.Text;

            if (rbEmpresaSubsidiaria.Checked)
            {
                empresaTipo = "subsidiaria";
            }
            else if (rbEmpresaCasaMatriz.Checked)
            {
                empresaTipo = "casa matriz";
            }
            // Colocar la parte de la logica de la clase registro
            r = empresa.ingresarEmpresa(empresaId, empresaNombre, empresaTipo);
            mensajeGeneral(r);
        }
    }
}
