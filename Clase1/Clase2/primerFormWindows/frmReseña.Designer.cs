namespace primerFormWindows
{
    partial class frmReseña
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            lblDireccion = new Label();
            cboTipoLocal = new ComboBox();
            lblTipoLocal = new Label();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            lblPuntuacion = new Label();
            cboPuntuacion = new ComboBox();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TipoLocal = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(287, 23);
            dtpFecha.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 52);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // cboTipoLocal
            // 
            cboTipoLocal.FormattingEnabled = true;
            cboTipoLocal.Items.AddRange(new object[] { "Parrilla", "Cafe de especialidad", "Panaderia", "Blanqueria", "Pastas", "Pizzeria" });
            cboTipoLocal.Location = new Point(12, 135);
            cboTipoLocal.Name = "cboTipoLocal";
            cboTipoLocal.Size = new Size(287, 23);
            cboTipoLocal.TabIndex = 2;
            // 
            // lblTipoLocal
            // 
            lblTipoLocal.AutoSize = true;
            lblTipoLocal.Location = new Point(12, 117);
            lblTipoLocal.Name = "lblTipoLocal";
            lblTipoLocal.Size = new Size(75, 15);
            lblTipoLocal.TabIndex = 3;
            lblTipoLocal.Text = "Tipo de local";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 82);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(287, 23);
            txtDireccion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 229);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 33);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar reseña";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(12, 171);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(68, 15);
            lblPuntuacion.TabIndex = 6;
            lblPuntuacion.Text = "Puntuacion";
            // 
            // cboPuntuacion
            // 
            cboPuntuacion.FormattingEnabled = true;
            cboPuntuacion.Location = new Point(12, 188);
            cboPuntuacion.Name = "cboPuntuacion";
            cboPuntuacion.Size = new Size(287, 23);
            cboPuntuacion.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Direccion, TipoLocal, Puntuacion });
            dataGridView1.Location = new Point(12, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(438, 112);
            dataGridView1.TabIndex = 8;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // TipoLocal
            // 
            TipoLocal.HeaderText = "TipoLocal";
            TipoLocal.Name = "TipoLocal";
            // 
            // Puntuacion
            // 
            Puntuacion.HeaderText = "Puntuacion";
            Puntuacion.Name = "Puntuacion";
            // 
            // button2
            // 
            button2.Location = new Point(360, 100);
            button2.Name = "button2";
            button2.Size = new Size(90, 86);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(169, 229);
            button3.Name = "button3";
            button3.Size = new Size(130, 33);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmReseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 393);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(cboPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(lblTipoLocal);
            Controls.Add(cboTipoLocal);
            Controls.Add(lblDireccion);
            Controls.Add(dtpFecha);
            Name = "frmReseña";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label lblDireccion;
        private ComboBox cboTipoLocal;
        private Label lblTipoLocal;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Label lblPuntuacion;
        private ComboBox cboPuntuacion;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TipoLocal;
        private DataGridViewTextBoxColumn Puntuacion;
        private Button button3;
    }
}
