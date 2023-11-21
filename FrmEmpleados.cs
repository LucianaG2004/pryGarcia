using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarcia
{
    public partial class FrmEmpleados : Form
    {
        ClsRestro objBaseDatos;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarCiudad(txt1.Text, dgvGrilla1);
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarApellido(txtBuscarApellido.Text, dgvGrilla1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }
    }
}
