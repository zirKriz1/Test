using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoProgProyectoAct3.Presentacion
{
    public partial class FrmReportePartidos : Form
    {
        public FrmReportePartidos()
        {
            InitializeComponent();
        }

        private void FrmReportePartidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPartidos.T_Partidos' Puede moverla o quitarla según sea necesario.
            this.t_PartidosTableAdapter.Fill(this.dSPartidos.T_Partidos);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
