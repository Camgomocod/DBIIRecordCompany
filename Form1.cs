

using BdRecordCompany.OracleConection;
using System.Data;

namespace DBIIRecordCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

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
            r = cn.insertRCompany(empresaId, empresaNombre, empresaTipo);
            generalMessage(r);
        }

        private void generalMessage(int r)
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

        private void btnProductorGuardarR_Click(object sender, EventArgs e)
        {
            int profCard, r = 0;
            string artisticName, yearsExp, categoryExp;

            profCard = int.Parse(txtProductorTarjeta.Text);
            artisticName = txtProductorNombre.Text;
            yearsExp = cbxProductorAniosExp.SelectedItem?.ToString() ?? "";
            categoryExp = cbxProductorClasificacion.SelectedItem?.ToString() ?? "";

            r = cn.insertMProducer(profCard, artisticName, yearsExp, categoryExp);
            generalMessage(r);
        }

        private void btnVincualacionGuardar_Click(object sender, EventArgs e)
        {
            int profCard, rcCod, r = 0;
            string startDate, finalDate;

            rcCod = int.Parse(txtVinculacionIdentificacion.Text);
            profCard = int.Parse(txtVinculacionTarjetaProfesional.Text);
            startDate = dtpVinculacionFechaIni.Value.ToString();
            finalDate = dtpVinculacionFechaFin.Value.ToString();

            r = cn.insertWork(rcCod, profCard, startDate, finalDate);
            generalMessage(r);
        }

        private void btnVinculacionBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsResult = new DataSet();
            
            DateTime selectDate = dtpBuscarVincFecha.Value;
            dsResult = cn.GetRecordsByStartDate(selectDate);

            if(dsResult.Tables.Count == 0 || dsResult.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No se encontraron registros para la fecha {selectDate.ToString("yyy-MM-dd")}");
                return;
            }

            dvgConsultaVinculacion.DataSource = dsResult;
            dvgConsultaVinculacion.DataMember = "dataResult";
        }   

        private void btnConsultaContrato_Click(object sender, EventArgs e)
        {
            
            int numContracts;
            
            numContracts = cn.getActiveContracts();
            if(numContracts < 0) {
                MessageBox.Show($"No se encontraron contratos vigenetes ! ");
                return;
            }

            lbConsultaContratoNum.Text = cn.getActiveContracts().ToString();
        }
    }
}
