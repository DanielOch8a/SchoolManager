namespace SchoolManager
{
    partial class frm_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.mnStrip_Main = new System.Windows.Forms.MenuStrip();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMnStrip_ImgLogo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnStrip_Main.SuspendLayout();
            this.ctxMnStrip_ImgLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnStrip_Main
            // 
            this.mnStrip_Main.BackColor = System.Drawing.Color.Silver;
            this.mnStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesorToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.adminsToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.mnStrip_Main.Name = "mnStrip_Main";
            this.mnStrip_Main.Size = new System.Drawing.Size(767, 24);
            this.mnStrip_Main.TabIndex = 0;
            this.mnStrip_Main.Text = "menuStrip1";
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.profesorToolStripMenuItem.Image = global::SchoolManager.Properties.Resources.profesor_Img;
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // capturaToolStripMenuItem
            // 
            this.capturaToolStripMenuItem.Image = global::SchoolManager.Properties.Resources.capturar_Img;
            this.capturaToolStripMenuItem.Name = "capturaToolStripMenuItem";
            this.capturaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.capturaToolStripMenuItem.Text = "Captura";
            this.capturaToolStripMenuItem.Click += new System.EventHandler(this.capturaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Image = global::SchoolManager.Properties.Resources.consultas_Img;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Image = global::SchoolManager.Properties.Resources.alumnos_Img;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // adminsToolStripMenuItem
            // 
            this.adminsToolStripMenuItem.Image = global::SchoolManager.Properties.Resources.admins_Star;
            this.adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            this.adminsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.adminsToolStripMenuItem.Text = "Admins";
            this.adminsToolStripMenuItem.Click += new System.EventHandler(this.adminsToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ctxMnStrip_ImgLogo
            // 
            this.ctxMnStrip_ImgLogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesorToolStripMenuItem1,
            this.alumnosToolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.ctxMnStrip_ImgLogo.Name = "ctxMnStrip_ImgLogo";
            this.ctxMnStrip_ImgLogo.Size = new System.Drawing.Size(123, 70);
            // 
            // profesorToolStripMenuItem1
            // 
            this.profesorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaToolStripMenuItem1,
            this.consultaToolStripMenuItem1});
            this.profesorToolStripMenuItem1.Image = global::SchoolManager.Properties.Resources.profesor_Img;
            this.profesorToolStripMenuItem1.Name = "profesorToolStripMenuItem1";
            this.profesorToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.profesorToolStripMenuItem1.Text = "Profesor";
            // 
            // capturaToolStripMenuItem1
            // 
            this.capturaToolStripMenuItem1.Image = global::SchoolManager.Properties.Resources.capturar_Img;
            this.capturaToolStripMenuItem1.Name = "capturaToolStripMenuItem1";
            this.capturaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.capturaToolStripMenuItem1.Text = "Captura";
            this.capturaToolStripMenuItem1.Click += new System.EventHandler(this.capturaToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Image = global::SchoolManager.Properties.Resources.consultas_Img;
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.Image = global::SchoolManager.Properties.Resources.alumnos_Img;
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.alumnosToolStripMenuItem1.Text = "Alumnos";
            this.alumnosToolStripMenuItem1.Click += new System.EventHandler(this.alumnosToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ContextMenuStrip = this.ctxMnStrip_ImgLogo;
            this.pictureBox1.Image = global::SchoolManager.Properties.Resources.SchoolManager_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(267, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrip_Main;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolManager";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.mnStrip_Main.ResumeLayout(false);
            this.mnStrip_Main.PerformLayout();
            this.ctxMnStrip_ImgLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ctxMnStrip_ImgLogo;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
    }
}

