using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            txtNombre = new TextBox();
            btnVolver = new Button();
            btnConfirmar = new Button();
            cboCiudad = new ComboBox();
            btnSalir = new Button();
            cboCategoria = new ComboBox();
            label6 = new Label();
            lblnombree = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Columnid = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnEstadio = new DataGridViewTextBoxColumn();
            txtEstadio = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 39);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(15, 354);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(245, 354);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(142, 45);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button2_Click;
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(367, 39);
            cboCiudad.Margin = new Padding(3, 2, 3, 2);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(156, 23);
            cboCiudad.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(471, 354);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 45);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(107, 91);
            cboCategoria.Margin = new Padding(3, 2, 3, 2);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(156, 23);
            cboCategoria.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 91);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 26;
            label6.Text = "Categoria:";
            // 
            // lblnombree
            // 
            lblnombree.AutoSize = true;
            lblnombree.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombree.Location = new Point(12, 39);
            lblnombree.Margin = new Padding(4, 0, 4, 0);
            lblnombree.Name = "lblnombree";
            lblnombree.Size = new Size(77, 21);
            lblnombree.TabIndex = 23;
            lblnombree.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(288, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 21;
            label8.Text = "Estadio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(290, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 17;
            label9.Text = "Ciudad:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Columnid, ColumnNombre, ColumnEstadio });
            dataGridView1.Location = new Point(27, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 181);
            dataGridView1.TabIndex = 27;
            // 
            // Columnid
            // 
            Columnid.HeaderText = "ID";
            Columnid.Name = "Columnid";
            Columnid.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Club";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 200;
            // 
            // ColumnEstadio
            // 
            ColumnEstadio.HeaderText = "Estadio";
            ColumnEstadio.Name = "ColumnEstadio";
            ColumnEstadio.ReadOnly = true;
            ColumnEstadio.Width = 200;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(365, 91);
            txtEstadio.Margin = new Padding(3, 2, 3, 2);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(156, 23);
            txtEstadio.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(938, 410);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(lblnombree);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(cboCategoria);
            Controls.Add(txtEstadio);
            Controls.Add(btnSalir);
            Controls.Add(cboCiudad);
            Controls.Add(btnConfirmar);
            Controls.Add(btnVolver);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Equipos";
            Text = "Equipos";
            Load += Equipos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Button btnVolver;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private ComboBox cboCiudad;
        private Label label3;
        private Button btnSalir;
        private Label label4;
        private Label label5;
        private ComboBox cboCategoria;
        private Label label6;
        private Label lblnombree;
        private TextBox textexperiencia;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox txtnombreentrenador;
        private ComboBox cboLocal;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Columnid;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnEstadio;
        private TextBox txtEstadio;
        private PictureBox pictureBox1;
    }
}