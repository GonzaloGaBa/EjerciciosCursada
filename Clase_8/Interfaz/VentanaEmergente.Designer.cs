namespace Interfaz
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            lblTitulo = new Label();
            lblMensaje = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(179, 32);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(63, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.Location = new Point(62, 113);
            lblMensaje.Margin = new Padding(4, 0, 4, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(46, 25);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "msj";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Transparent;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnOk.Location = new Point(133, 166);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(142, 66);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // VentanaEmergente
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(424, 269);
            ControlBox = false;
            Controls.Add(btnOk);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VentanaEmergente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaEmergente";
            Load += VentanaEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMensaje;
        private Button btnOk;
    }
}