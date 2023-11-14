using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    public partial class JugadorContrato : Form
    {
        public JugadorContrato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que queres Volver, volveras a la página de inicio?", "Volver", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que queres salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void JugadorContrato_Load(object sender, EventArgs e)
        {

        }
    }
}
