namespace Interfaz
{
    partial class FormLogin
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
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.Desktop;
            txtUsuario.Location = new Point(208, 117);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "     Ingrese Usuario";
            txtUsuario.Size = new Size(332, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtClave.ForeColor = SystemColors.Desktop;
            txtClave.Location = new Point(208, 200);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "     Ingrese Contraseña";
            txtClave.Size = new Size(332, 27);
            txtClave.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(208, 290);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(332, 68);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Red;
            btnCerrar.Location = new Point(718, 370);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(70, 68);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnCerrar;
    }
}