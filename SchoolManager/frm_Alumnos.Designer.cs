namespace SchoolManager
{
    partial class frm_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Alumnos));
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.cbxAlumnos = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblExtraEscolar = new System.Windows.Forms.Label();
            this.lblInformacionAlumno = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtExtraescolar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(82, 39);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(62, 17);
            this.lblAlumnos.TabIndex = 0;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // cbxAlumnos
            // 
            this.cbxAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlumnos.FormattingEnabled = true;
            this.cbxAlumnos.Items.AddRange(new object[] {
            "Arath Camacho",
            "Daniel Ochoa",
            "José Soto",
            "Miguel Fajardo"});
            this.cbxAlumnos.Location = new System.Drawing.Point(150, 36);
            this.cbxAlumnos.Name = "cbxAlumnos";
            this.cbxAlumnos.Size = new System.Drawing.Size(148, 24);
            this.cbxAlumnos.TabIndex = 0;
            this.cbxAlumnos.SelectedIndexChanged += new System.EventHandler(this.cbxAlumnos_SelectedIndexChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(34, 129);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 17);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(27, 168);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(52, 17);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(169, 129);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblExtraEscolar
            // 
            this.lblExtraEscolar.AutoSize = true;
            this.lblExtraEscolar.Location = new System.Drawing.Point(139, 168);
            this.lblExtraEscolar.Name = "lblExtraEscolar";
            this.lblExtraEscolar.Size = new System.Drawing.Size(90, 17);
            this.lblExtraEscolar.TabIndex = 5;
            this.lblExtraEscolar.Text = "Extraescolar:";
            // 
            // lblInformacionAlumno
            // 
            this.lblInformacionAlumno.AutoSize = true;
            this.lblInformacionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionAlumno.Location = new System.Drawing.Point(86, 82);
            this.lblInformacionAlumno.Name = "lblInformacionAlumno";
            this.lblInformacionAlumno.Size = new System.Drawing.Size(198, 20);
            this.lblInformacionAlumno.TabIndex = 6;
            this.lblInformacionAlumno.Text = "Información del Alumno";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(85, 126);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(34, 23);
            this.txtEdad.TabIndex = 7;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(85, 165);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(34, 23);
            this.txtGrupo.TabIndex = 8;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(235, 126);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(94, 23);
            this.txtCarrera.TabIndex = 9;
            // 
            // txtExtraescolar
            // 
            this.txtExtraescolar.Location = new System.Drawing.Point(235, 165);
            this.txtExtraescolar.Name = "txtExtraescolar";
            this.txtExtraescolar.ReadOnly = true;
            this.txtExtraescolar.Size = new System.Drawing.Size(94, 23);
            this.txtExtraescolar.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(150, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frm_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 245);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtExtraescolar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblInformacionAlumno);
            this.Controls.Add(this.lblExtraEscolar);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.cbxAlumnos);
            this.Controls.Add(this.lblAlumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.ComboBox cbxAlumnos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblExtraEscolar;
        private System.Windows.Forms.Label lblInformacionAlumno;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtExtraescolar;
        private System.Windows.Forms.Button btnSalir;
    }
}