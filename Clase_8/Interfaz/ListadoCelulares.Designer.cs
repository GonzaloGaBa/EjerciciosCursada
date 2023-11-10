namespace Interfaz
{
    partial class ListadoCelulares
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoCelulares));
            dtgCelulares = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgCelulares).BeginInit();
            SuspendLayout();
            // 
            // dtgCelulares
            // 
            dtgCelulares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCelulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.BlueViolet;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgCelulares.DefaultCellStyle = dataGridViewCellStyle1;
            dtgCelulares.Location = new Point(25, 32);
            dtgCelulares.Name = "dtgCelulares";
            dtgCelulares.RowHeadersVisible = false;
            dtgCelulares.RowTemplate.Height = 25;
            dtgCelulares.Size = new Size(655, 272);
            dtgCelulares.TabIndex = 1;
            // 
            // ListadoCelulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 346);
            ControlBox = false;
            Controls.Add(dtgCelulares);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadoCelulares";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListadoCelulares";
            Load += ListadoCelulares_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCelulares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgCelulares;
    }
}