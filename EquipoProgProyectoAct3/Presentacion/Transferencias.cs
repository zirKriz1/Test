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
    public partial class Transferencias : Form
    {
        public Transferencias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que queres salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void Transferencias_Load(object sender, EventArgs e)
        {

        }
    }
}
