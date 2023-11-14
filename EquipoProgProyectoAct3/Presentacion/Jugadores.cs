using EquipoProgProyecto.Clases;
using EquipoProgProyecto.Datos;
using EquipoProgProyecto.Servicios;
using EquipoProgProyecto.Servicios.Interfaz;
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
    public partial class JugadoresFrm : Form
    {

        IServicio ServicioDatos = null;
        Jugador Jugador = null;
        public JugadoresFrm(FabricaServicio fabrica)
        {
            InitializeComponent();
            ServicioDatos = fabrica.CrearServicio();


        }

        private void Jugadores_Load_1(object sender, EventArgs e)
        {
            CargarComboClubes();
            CargarComboPaises();
            CargarComboPosiciones();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que queres salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
        private void CargarComboClubes()
        {
            List<Club> list = ServicioDatos.GetClub();
            cboClub.DataSource = list;
            cboClub.ValueMember = "IDClub";
            cboClub.DisplayMember = "NombreClub";
            cboClub.SelectedIndex = -1;
        }
        private void CargarComboPaises()
        {
            List<Pais> list = ServicioDatos.GetPais();
            cboPais.DataSource = list;
            cboPais.ValueMember = "id_pais";
            cboPais.DisplayMember = "nombrePais";
            cboPais.SelectedIndex = -1;
        }
        private void CargarComboPosiciones()
        {
            List<Posicion> list = ServicioDatos.GetPosicion();
            cboPosicion.DataSource = list;
            cboPosicion.ValueMember = "IDPosicion";
            cboPosicion.DisplayMember = "NombrePosicion";
            cboPosicion.SelectedIndex = -1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtaltura.Text))
            {
                MessageBox.Show("Debe ingresar una altura", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtpeso.Text))
            {
                MessageBox.Show("Debe ingresar un peso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtapellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtcamiseta.Text))
            {
                MessageBox.Show("Debe ingresar un numero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dateTimePicker1.Value.Day != DateTime.Now.Day)
            {
                MessageBox.Show("Debe ingresar una fecha que esté acorde", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboClub.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar un club", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboPais.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar un pais", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboPosicion.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar una posicion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // SE CUIDA DE QUE EL USUARIO NO INGRESE EL MISMO COMPONENTE

            Pais p = (Pais)cboPais.SelectedItem;
            Posicion po = (Posicion)cboPosicion.SelectedItem;
            Club c = (Club)cboClub.SelectedItem;
            string nombre = txtNombre.Text;
            string apellido = txtapellido.Text;
            int numero = Int32.Parse(txtcamiseta.Text);
            DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text);
            double altura = double.Parse(txtaltura.Text);
            double peso = double.Parse(txtpeso.Text);
            Jugador jugador = new Jugador(numero, p, po, c, nombre, apellido, fecha, altura, peso);

        }
    }
}
