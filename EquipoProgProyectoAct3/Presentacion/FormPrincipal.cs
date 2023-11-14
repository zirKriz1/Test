using EquipoProgProyecto.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EquipoProgProyecto;
using EquipoProgProyecto.Datos;
using EquipoProgProyecto.Servicios;
using EquipoProgProyectoAct3.Presentacion;

namespace EquipoProgProyecto
{
    public partial class FormPrincipal : Form
    {
        FabricaServicio fabrica = null;
        public FormPrincipal(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica= fabrica;
        }


        private void nuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipos ente = new Equipos();
            ente.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compromiso comp = new Compromiso();
            comp.ShowDialog();
        }

        private void agregarEstadísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas jug = new Estadisticas();
            jug.ShowDialog();
        }

        private void actualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Jugadores consjug = new Consultar_Jugadores();
            consjug.ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transferencias trans = new Transferencias();
            trans.ShowDialog();
        }

        private void inscribirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que queres salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas est = new Estadisticas();
            est.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new JugadoresFrm(fabrica).ShowDialog();
        }

        private void partidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportePartidos reporte = new FrmReportePartidos();
            reporte.ShowDialog();
        }
    }
}
