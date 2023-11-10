namespace Clase_6
{
    partial class FormularioInicial
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
            lblNombre = new Label();
            btnMostrar = new Button();
            txtNombre = new TextBox();
            lblGenero = new Label();
            txtSalario = new TextBox();
            lblSalario = new Label();
            rdoFemenino = new RadioButton();
            rdoMasculino = new RadioButton();
            cmbTareas = new ComboBox();
            lblTareas = new Label();
            grpGenero = new GroupBox();
            lstEmpleados = new ListBox();
            btnAgregarTareas = new Button();
            dataGridView1 = new DataGridView();
            Tareas = new DataGridViewTextBoxColumn();
            grpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Indigo;
            lblNombre.Font = new Font("Stencil", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.DeepSkyBlue;
            lblNombre.Location = new Point(73, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(169, 44);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Coral;
            btnMostrar.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.BlueViolet;
            btnMostrar.Location = new Point(592, 397);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(232, 78);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(307, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 43);
            txtNombre.TabIndex = 2;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Indigo;
            lblGenero.Font = new Font("Stencil", 28F, FontStyle.Italic, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.DeepSkyBlue;
            lblGenero.Location = new Point(73, 196);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(165, 46);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Genero";
            // 
            // txtSalario
            // 
            txtSalario.BackColor = SystemColors.ScrollBar;
            txtSalario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(307, 105);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(180, 43);
            txtSalario.TabIndex = 6;
            txtSalario.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.BackColor = Color.Indigo;
            lblSalario.Font = new Font("Stencil", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblSalario.ForeColor = Color.DeepSkyBlue;
            lblSalario.Location = new Point(73, 105);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(170, 44);
            lblSalario.TabIndex = 5;
            lblSalario.Text = "Salario";
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.BackColor = Color.HotPink;
            rdoFemenino.FlatAppearance.BorderColor = Color.Black;
            rdoFemenino.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rdoFemenino.Location = new Point(6, 22);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(156, 35);
            rdoFemenino.TabIndex = 7;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.TextAlign = ContentAlignment.BottomLeft;
            rdoFemenino.UseVisualStyleBackColor = false;
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.BackColor = Color.IndianRed;
            rdoMasculino.Font = new Font("Snap ITC", 17F, FontStyle.Regular, GraphicsUnit.Point);
            rdoMasculino.Location = new Point(6, 74);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(160, 34);
            rdoMasculino.TabIndex = 8;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.TextAlign = ContentAlignment.TopCenter;
            rdoMasculino.UseVisualStyleBackColor = false;
            // 
            // cmbTareas
            // 
            cmbTareas.Font = new Font("Segoe Script", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTareas.FormattingEnabled = true;
            cmbTareas.Items.AddRange(new object[] { "Cerrar Caja", "Limpiar Cocina", "Limpiar Baño", "Atender Clientes" });
            cmbTareas.Location = new Point(307, 308);
            cmbTareas.Name = "cmbTareas";
            cmbTareas.Size = new Size(180, 40);
            cmbTareas.TabIndex = 9;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.BackColor = Color.Indigo;
            lblTareas.Font = new Font("Stencil", 29F, FontStyle.Italic, GraphicsUnit.Point);
            lblTareas.ForeColor = Color.DeepSkyBlue;
            lblTareas.Location = new Point(73, 302);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(163, 46);
            lblTareas.TabIndex = 10;
            lblTareas.Text = "Tareas";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdoFemenino);
            grpGenero.Controls.Add(rdoMasculino);
            grpGenero.Location = new Point(307, 154);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(180, 119);
            grpGenero.TabIndex = 11;
            grpGenero.TabStop = false;
            grpGenero.Text = "Generos";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(556, 37);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(287, 139);
            lstEmpleados.TabIndex = 12;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnAgregarTareas
            // 
            btnAgregarTareas.BackColor = Color.Coral;
            btnAgregarTareas.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregarTareas.ForeColor = Color.BlueViolet;
            btnAgregarTareas.Location = new Point(136, 397);
            btnAgregarTareas.Name = "btnAgregarTareas";
            btnAgregarTareas.Size = new Size(232, 78);
            btnAgregarTareas.TabIndex = 13;
            btnAgregarTareas.Text = "Agregar";
            btnAgregarTareas.UseVisualStyleBackColor = false;
            btnAgregarTareas.Click += btnAgregarTareas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tareas });
            dataGridView1.Location = new Point(556, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(287, 150);
            dataGridView1.TabIndex = 14;
            // 
            // Tareas
            // 
            Tareas.HeaderText = "Tareas";
            Tareas.Name = "Tareas";
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(863, 515);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarTareas);
            Controls.Add(lstEmpleados);
            Controls.Add(grpGenero);
            Controls.Add(lblTareas);
            Controls.Add(cmbTareas);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(lblGenero);
            Controls.Add(txtNombre);
            Controls.Add(btnMostrar);
            Controls.Add(lblNombre);
            ForeColor = SystemColors.ControlText;
            Name = "FormularioInicial";
            Text = "Formulario Inicial";
            Load += FormularioInicial_Load_1;
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button btnMostrar;
        private TextBox txtNombre;
        private Label lblGenero;
        private TextBox txtSalario;
        private Label lblSalario;
        private RadioButton rdoFemenino;
        private RadioButton rdoMasculino;
        private ComboBox comboBox1;
        private ComboBox cmbTareas;
        private Label lblTareas;
        private GroupBox grpGenero;
        private ListBox lstEmpleados;
        private Button btnAgregarTareas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tareas;
    }
}