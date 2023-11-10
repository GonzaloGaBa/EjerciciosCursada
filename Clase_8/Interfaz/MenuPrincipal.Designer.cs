namespace Interfaz
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            cELULARESToolStripMenuItem = new ToolStripMenuItem();
            aPPLEToolStripMenuItem = new ToolStripMenuItem();
            sAMSUNGToolStripMenuItem = new ToolStripMenuItem();
            xIAOMIToolStripMenuItem = new ToolStripMenuItem();
            hUAWIEToolStripMenuItem = new ToolStripMenuItem();
            mOTOROLAToolStripMenuItem = new ToolStripMenuItem();
            sTOCKToolStripMenuItem = new ToolStripMenuItem();
            cERRARToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, cELULARESToolStripMenuItem, sTOCKToolStripMenuItem, cERRARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(845, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            iNICIOToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            iNICIOToolStripMenuItem.ImageTransparentColor = Color.FromArgb(224, 224, 224);
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(54, 20);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // cELULARESToolStripMenuItem
            // 
            cELULARESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aPPLEToolStripMenuItem, sAMSUNGToolStripMenuItem, xIAOMIToolStripMenuItem, hUAWIEToolStripMenuItem, mOTOROLAToolStripMenuItem });
            cELULARESToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            cELULARESToolStripMenuItem.Name = "cELULARESToolStripMenuItem";
            cELULARESToolStripMenuItem.Size = new Size(80, 20);
            cELULARESToolStripMenuItem.Text = "CELULARES";
            cELULARESToolStripMenuItem.Click += cELULARESToolStripMenuItem_Click;
            // 
            // aPPLEToolStripMenuItem
            // 
            aPPLEToolStripMenuItem.Name = "aPPLEToolStripMenuItem";
            aPPLEToolStripMenuItem.Size = new Size(137, 22);
            aPPLEToolStripMenuItem.Text = "APPLE";
            // 
            // sAMSUNGToolStripMenuItem
            // 
            sAMSUNGToolStripMenuItem.Name = "sAMSUNGToolStripMenuItem";
            sAMSUNGToolStripMenuItem.Size = new Size(137, 22);
            sAMSUNGToolStripMenuItem.Text = "SAMSUNG";
            // 
            // xIAOMIToolStripMenuItem
            // 
            xIAOMIToolStripMenuItem.Name = "xIAOMIToolStripMenuItem";
            xIAOMIToolStripMenuItem.Size = new Size(137, 22);
            xIAOMIToolStripMenuItem.Text = "XIAOMI";
            // 
            // hUAWIEToolStripMenuItem
            // 
            hUAWIEToolStripMenuItem.Name = "hUAWIEToolStripMenuItem";
            hUAWIEToolStripMenuItem.Size = new Size(137, 22);
            hUAWIEToolStripMenuItem.Text = "HUAWIE";
            // 
            // mOTOROLAToolStripMenuItem
            // 
            mOTOROLAToolStripMenuItem.Name = "mOTOROLAToolStripMenuItem";
            mOTOROLAToolStripMenuItem.Size = new Size(137, 22);
            mOTOROLAToolStripMenuItem.Text = "MOTOROLA";
            // 
            // sTOCKToolStripMenuItem
            // 
            sTOCKToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            sTOCKToolStripMenuItem.Name = "sTOCKToolStripMenuItem";
            sTOCKToolStripMenuItem.Size = new Size(54, 20);
            sTOCKToolStripMenuItem.Text = "STOCK";
            sTOCKToolStripMenuItem.Click += toolStripMenuItem3_Click;
            // 
            // cERRARToolStripMenuItem
            // 
            cERRARToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            cERRARToolStripMenuItem.Name = "cERRARToolStripMenuItem";
            cERRARToolStripMenuItem.Size = new Size(62, 20);
            cERRARToolStripMenuItem.Text = "CERRAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(845, 381);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
       
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(845, 405);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem cELULARESToolStripMenuItem;
        private ToolStripMenuItem aPPLEToolStripMenuItem;
        private ToolStripMenuItem sAMSUNGToolStripMenuItem;
        private ToolStripMenuItem xIAOMIToolStripMenuItem;
        private ToolStripMenuItem sTOCKToolStripMenuItem;
        private ToolStripMenuItem cERRARToolStripMenuItem;
        private ToolStripMenuItem hUAWIEToolStripMenuItem;
        private ToolStripMenuItem mOTOROLAToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}