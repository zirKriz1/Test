namespace EquipoProgProyectoAct3.Presentacion
{
    partial class FrmReportePartidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tPartidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPartidos = new EquipoProgProyectoAct3.Presentacion.Reportes.DSPartidos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_PartidosTableAdapter = new EquipoProgProyectoAct3.Presentacion.Reportes.DSPartidosTableAdapters.T_PartidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tPartidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tPartidosBindingSource
            // 
            this.tPartidosBindingSource.DataMember = "T_Partidos";
            this.tPartidosBindingSource.DataSource = this.dSPartidos;
            // 
            // dSPartidos
            // 
            this.dSPartidos.DataSetName = "DSPartidos";
            this.dSPartidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tPartidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipoProgProyectoAct3.Presentacion.Reportes.RptPartidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // t_PartidosTableAdapter
            // 
            this.t_PartidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePartidos";
            this.Text = "FrmReportePartidos";
            this.Load += new System.EventHandler(this.FrmReportePartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tPartidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DSPartidos dSPartidos;
        private System.Windows.Forms.BindingSource tPartidosBindingSource;
        private Reportes.DSPartidosTableAdapters.T_PartidosTableAdapter t_PartidosTableAdapter;
    }
}