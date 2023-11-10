namespace Interfaz
{
    partial class FormStock
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
            dtgStock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgStock).BeginInit();
            SuspendLayout();
            // 
            // dtgStock
            // 
            dtgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStock.Location = new Point(167, 69);
            dtgStock.Name = "dtgStock";
            dtgStock.Size = new Size(240, 150);
            dtgStock.TabIndex = 0;
            
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 319);
            Controls.Add(dtgStock);
            Name = "FormStock";
            Text = "FormStock";
            FormClosing += FormStock_FormClosing;
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgStock;
    }
}