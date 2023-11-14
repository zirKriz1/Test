using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Consultar_Jugadores
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnEquipo = new DataGridViewTextBoxColumn();
            ColumnPosicion = new DataGridViewTextBoxColumn();
            ColumnNumero = new DataGridViewTextBoxColumn();
            btnConfirmar = new Button();
            label9 = new Label();
            lbl = new Label();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnNombre, ColumnEquipo, ColumnPosicion, ColumnNumero });
            dataGridView1.Location = new Point(24, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 150);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Visible = false;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre Completo";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 200;
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
            // ColumnNumero
            // 
            ColumnNumero.HeaderText = "Numero";
            ColumnNumero.Name = "ColumnNumero";
            ColumnNumero.ReadOnly = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(271, 294);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(141, 47);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Borrar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(24, 78);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 22;
            label9.Text = "Equipo:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.Control;
            lbl.Location = new Point(24, 21);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(95, 21);
            lbl.TabIndex = 21;
            lbl.Text = "Jugador N°";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(576, 78);
            button4.Name = "button4";
            button4.Size = new Size(92, 25);
            button4.TabIndex = 36;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(24, 294);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 37;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(527, 294);
            button2.Name = "button2";
            button2.Size = new Size(141, 47);
            button2.TabIndex = 38;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Consultar_Jugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(691, 352);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(lbl);
            Controls.Add(btnConfirmar);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Name = "Consultar_Jugadores";
            Text = "Consultar_Jugadores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnEquipo;
        private DataGridViewTextBoxColumn ColumnPosicion;
        private DataGridViewTextBoxColumn ColumnNumero;
        private Button btnConfirmar;
        private Label label9;
        private Label lbl;
        private Button button4;
        private Button button1;
        private Button button2;
    }
}