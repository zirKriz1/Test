using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class JugadoresFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadoresFrm));
            txtcamiseta = new TextBox();
            txtaltura = new TextBox();
            txtpeso = new TextBox();
            txtapellido = new TextBox();
            cboClub = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnEquipo = new DataGridViewTextBoxColumn();
            ColumnPosicion = new DataGridViewTextBoxColumn();
            ColumnAcciones = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl = new Label();
            label10 = new Label();
            cboPosicion = new ComboBox();
            cboPais = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtNombre = new TextBox();
            btnConsultar = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            cboConsultarJugador = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtcamiseta
            // 
            txtcamiseta.Location = new Point(339, 93);
            txtcamiseta.Margin = new Padding(3, 2, 3, 2);
            txtcamiseta.Name = "txtcamiseta";
            txtcamiseta.Size = new Size(133, 23);
            txtcamiseta.TabIndex = 69;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(316, 49);
            txtaltura.Margin = new Padding(3, 2, 3, 2);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(133, 23);
            txtaltura.TabIndex = 68;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(305, 134);
            txtpeso.Margin = new Padding(3, 2, 3, 2);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(133, 23);
            txtpeso.TabIndex = 67;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(100, 49);
            txtapellido.Margin = new Padding(3, 2, 3, 2);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(133, 23);
            txtapellido.TabIndex = 66;
            // 
            // cboClub
            // 
            cboClub.BackColor = SystemColors.Info;
            cboClub.FormattingEnabled = true;
            cboClub.Location = new Point(68, 136);
            cboClub.Margin = new Padding(3, 2, 3, 2);
            cboClub.Name = "cboClub";
            cboClub.Size = new Size(133, 23);
            cboClub.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(248, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 64;
            label3.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(248, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 63;
            label2.Text = "Altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 62;
            label1.Text = "Camiseta:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnNombre, ColumnApellido, ColumnEquipo, ColumnPosicion, ColumnAcciones });
            dataGridView1.Location = new Point(14, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 173);
            dataGridView1.TabIndex = 61;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Visible = false;
            ColumnID.Width = 50;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre ";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 150;
            // 
            // ColumnApellido
            // 
            ColumnApellido.HeaderText = "Apellido";
            ColumnApellido.Name = "ColumnApellido";
            ColumnApellido.ReadOnly = true;
            ColumnApellido.Width = 150;
            // 
            // ColumnEquipo
            // 
            ColumnEquipo.HeaderText = "Equipo";
            ColumnEquipo.Name = "ColumnEquipo";
            ColumnEquipo.ReadOnly = true;
            ColumnEquipo.Width = 150;
            // 
            // ColumnPosicion
            // 
            ColumnPosicion.HeaderText = "Posicion";
            ColumnPosicion.Name = "ColumnPosicion";
            ColumnPosicion.ReadOnly = true;
            ColumnPosicion.Width = 150;
            // 
            // ColumnAcciones
            // 
            ColumnAcciones.HeaderText = "Acciones";
            ColumnAcciones.Name = "ColumnAcciones";
            ColumnAcciones.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(615, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 47);
            btnCancelar.TabIndex = 60;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(433, 415);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(141, 47);
            btnConfirmar.TabIndex = 59;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.Location = new Point(248, 175);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 25);
            btnAgregar.TabIndex = 58;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(558, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(16, 138);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 56;
            label11.Text = "Club:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 51);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 55;
            label7.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 179);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 54;
            label8.Text = "Pais:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(248, 12);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 21);
            label9.TabIndex = 53;
            label9.Text = "Fecha Nacimiento:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(16, 12);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(77, 21);
            lbl.TabIndex = 52;
            lbl.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 93);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 21);
            label10.TabIndex = 51;
            label10.Text = "Posicion:";
            // 
            // cboPosicion
            // 
            cboPosicion.BackColor = SystemColors.Info;
            cboPosicion.FormattingEnabled = true;
            cboPosicion.Location = new Point(100, 91);
            cboPosicion.Margin = new Padding(3, 2, 3, 2);
            cboPosicion.Name = "cboPosicion";
            cboPosicion.Size = new Size(133, 23);
            cboPosicion.TabIndex = 50;
            // 
            // cboPais
            // 
            cboPais.BackColor = SystemColors.Info;
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(68, 177);
            cboPais.Margin = new Padding(3, 2, 3, 2);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(133, 23);
            cboPais.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(407, 12);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 10);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 47;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.Control;
            btnConsultar.Location = new Point(662, 179);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(92, 25);
            btnConsultar.TabIndex = 70;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(199, 415);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(141, 47);
            btnBorrar.TabIndex = 71;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(16, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(141, 47);
            btnEditar.TabIndex = 72;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // cboConsultarJugador
            // 
            cboConsultarJugador.BackColor = SystemColors.Info;
            cboConsultarJugador.FormattingEnabled = true;
            cboConsultarJugador.Location = new Point(523, 181);
            cboConsultarJugador.Margin = new Padding(3, 2, 3, 2);
            cboConsultarJugador.Name = "cboConsultarJugador";
            cboConsultarJugador.Size = new Size(133, 23);
            cboConsultarJugador.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(360, 183);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 73;
            label4.Text = "Consultar por Club:";
            // 
            // JugadoresFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 474);
            Controls.Add(cboConsultarJugador);
            Controls.Add(label4);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnConsultar);
            Controls.Add(txtcamiseta);
            Controls.Add(txtaltura);
            Controls.Add(txtpeso);
            Controls.Add(txtapellido);
            Controls.Add(cboClub);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lbl);
            Controls.Add(label10);
            Controls.Add(cboPosicion);
            Controls.Add(cboPais);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNombre);
            Name = "JugadoresFrm";
            Text = "Jugadores";
            Load += Jugadores_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtcamiseta;
        private TextBox txtaltura;
        private TextBox txtpeso;
        private TextBox txtapellido;
        private ComboBox cboClub;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnEquipo;
        private DataGridViewTextBoxColumn ColumnPosicion;
        private DataGridViewTextBoxColumn ColumnAcciones;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnAgregar;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl;
        private Label label10;
        private ComboBox cboPosicion;
        private ComboBox cboPais;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNombre;
        private Button btnConsultar;
        private Button btnBorrar;
        private Button btnEditar;
        private ComboBox cboConsultarJugador;
        private Label label4;
    }
}