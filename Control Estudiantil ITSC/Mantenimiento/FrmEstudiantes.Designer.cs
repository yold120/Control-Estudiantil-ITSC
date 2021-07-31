namespace Control_Estudiantil_ITSC.Mantenimiento
{
    partial class FrmEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiantes));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tblEstudiantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBControlEstudiantesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkMateria = new System.Windows.Forms.CheckBox();
            this.chkSencillo = new System.Windows.Forms.CheckBox();
            this.chkProfesor = new System.Windows.Forms.CheckBox();
            this.chkCarrera = new System.Windows.Forms.CheckBox();
            this.dgvDatos2 = new System.Windows.Forms.DataGridView();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNoSeEncontraronDatos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.contenedor1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.cbbMateria = new System.Windows.Forms.ComboBox();
            this.cbbCarrera = new System.Windows.Forms.ComboBox();
            this.cbbProfesor = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barra1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstudiantesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControlEstudiantesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstudiantesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.contenedor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Indigo;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(201, 233);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 48);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tblEstudiantesBindingSource1
            // 
            this.tblEstudiantesBindingSource1.DataMember = "tblEstudiantes";
            this.tblEstudiantesBindingSource1.DataSource = this.dBControlEstudiantesDataSetBindingSource;
            // 
            // dBControlEstudiantesDataSetBindingSource
            // 
            this.dBControlEstudiantesDataSetBindingSource.Position = 0;
            // 
            // dBControlEstudiantesDataSet
            // 
            // 
            // tblEstudiantesBindingSource
            // 
            this.tblEstudiantesBindingSource.DataMember = "tblEstudiantes";
            this.tblEstudiantesBindingSource.DataSource = this.dBControlEstudiantesDataSetBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.cbbBuscar);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblEditar);
            this.groupBox2.Controls.Add(this.lblBorrar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.chkNombre);
            this.groupBox2.Controls.Add(this.chkMateria);
            this.groupBox2.Controls.Add(this.chkSencillo);
            this.groupBox2.Controls.Add(this.chkProfesor);
            this.groupBox2.Controls.Add(this.chkCarrera);
            this.groupBox2.Controls.Add(this.dgvDatos2);
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNoSeEncontraronDatos);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(208, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(445, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cbbBuscar
            // 
            this.cbbBuscar.FormattingEnabled = true;
            this.cbbBuscar.Items.AddRange(new object[] {
            "Apellido",
            "Carrera",
            "Materia",
            "Matricula",
            "Nombre",
            "Profesor"});
            this.cbbBuscar.Location = new System.Drawing.Point(40, 22);
            this.cbbBuscar.Name = "cbbBuscar";
            this.cbbBuscar.Size = new System.Drawing.Size(85, 21);
            this.cbbBuscar.TabIndex = 8;
            this.cbbBuscar.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.BackColor = System.Drawing.Color.Indigo;
            this.lblEditar.ForeColor = System.Drawing.Color.White;
            this.lblEditar.Location = new System.Drawing.Point(126, 284);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(40, 13);
            this.lblEditar.TabIndex = 6;
            this.lblEditar.Text = "Editar";
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.BackColor = System.Drawing.Color.Indigo;
            this.lblBorrar.ForeColor = System.Drawing.Color.White;
            this.lblBorrar.Location = new System.Drawing.Point(211, 283);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(41, 13);
            this.lblBorrar.TabIndex = 6;
            this.lblBorrar.Text = "Borrar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Indigo;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(117, 234);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 48);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightCyan;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(25, 250);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 35);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.BackColor = System.Drawing.Color.Indigo;
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(283, 249);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(69, 17);
            this.chkNombre.TabIndex = 10;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = false;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkMateria
            // 
            this.chkMateria.AutoSize = true;
            this.chkMateria.BackColor = System.Drawing.Color.Indigo;
            this.chkMateria.ForeColor = System.Drawing.Color.White;
            this.chkMateria.Location = new System.Drawing.Point(283, 273);
            this.chkMateria.Name = "chkMateria";
            this.chkMateria.Size = new System.Drawing.Size(68, 17);
            this.chkMateria.TabIndex = 11;
            this.chkMateria.Text = "Materia";
            this.chkMateria.UseVisualStyleBackColor = false;
            this.chkMateria.CheckedChanged += new System.EventHandler(this.chkMateria_CheckedChanged);
            // 
            // chkSencillo
            // 
            this.chkSencillo.AutoSize = true;
            this.chkSencillo.BackColor = System.Drawing.Color.Transparent;
            this.chkSencillo.Checked = true;
            this.chkSencillo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSencillo.ForeColor = System.Drawing.Color.Black;
            this.chkSencillo.Location = new System.Drawing.Point(362, 24);
            this.chkSencillo.Name = "chkSencillo";
            this.chkSencillo.Size = new System.Drawing.Size(71, 17);
            this.chkSencillo.TabIndex = 14;
            this.chkSencillo.Text = "Sencillo";
            this.chkSencillo.UseVisualStyleBackColor = false;
            this.chkSencillo.CheckedChanged += new System.EventHandler(this.chkSencillo_CheckedChanged);
            // 
            // chkProfesor
            // 
            this.chkProfesor.AutoSize = true;
            this.chkProfesor.BackColor = System.Drawing.Color.Indigo;
            this.chkProfesor.ForeColor = System.Drawing.Color.White;
            this.chkProfesor.Location = new System.Drawing.Point(366, 274);
            this.chkProfesor.Name = "chkProfesor";
            this.chkProfesor.Size = new System.Drawing.Size(73, 17);
            this.chkProfesor.TabIndex = 13;
            this.chkProfesor.Text = "Profesor";
            this.chkProfesor.UseVisualStyleBackColor = false;
            this.chkProfesor.CheckedChanged += new System.EventHandler(this.chkProfesor_CheckedChanged);
            // 
            // chkCarrera
            // 
            this.chkCarrera.AutoSize = true;
            this.chkCarrera.BackColor = System.Drawing.Color.Indigo;
            this.chkCarrera.ForeColor = System.Drawing.Color.White;
            this.chkCarrera.Location = new System.Drawing.Point(366, 250);
            this.chkCarrera.Name = "chkCarrera";
            this.chkCarrera.Size = new System.Drawing.Size(67, 17);
            this.chkCarrera.TabIndex = 12;
            this.chkCarrera.Text = "Carrera";
            this.chkCarrera.UseVisualStyleBackColor = false;
            this.chkCarrera.CheckedChanged += new System.EventHandler(this.chkCarrera_CheckedChanged);
            // 
            // dgvDatos2
            // 
            this.dgvDatos2.AllowUserToAddRows = false;
            this.dgvDatos2.AllowUserToResizeColumns = false;
            this.dgvDatos2.AllowUserToResizeRows = false;
            this.dgvDatos2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDatos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDatos2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos2.GridColor = System.Drawing.Color.Bisque;
            this.dgvDatos2.Location = new System.Drawing.Point(6, 52);
            this.dgvDatos2.Name = "dgvDatos2";
            this.dgvDatos2.ReadOnly = true;
            this.dgvDatos2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos2.Size = new System.Drawing.Size(432, 177);
            this.dgvDatos2.StandardTab = true;
            this.dgvDatos2.TabIndex = 21;
            this.dgvDatos2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos2_CellClick);
            this.dgvDatos2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos2_CellContentClick);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvDatos.Location = new System.Drawing.Point(6, 52);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(432, 177);
            this.dgvDatos.TabIndex = 6;
            this.dgvDatos.Visible = false;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(131, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(142, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "lblNoSeEncontraronDatos";
            // 
            // lblNoSeEncontraronDatos
            // 
            this.lblNoSeEncontraronDatos.AutoSize = true;
            this.lblNoSeEncontraronDatos.Enabled = false;
            this.lblNoSeEncontraronDatos.Location = new System.Drawing.Point(142, 159);
            this.lblNoSeEncontraronDatos.Name = "lblNoSeEncontraronDatos";
            this.lblNoSeEncontraronDatos.Size = new System.Drawing.Size(153, 13);
            this.lblNoSeEncontraronDatos.TabIndex = 2;
            this.lblNoSeEncontraronDatos.Text = "lblNoSeEncontraronDatos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(6, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(65, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(433, 66);
            this.button1.TabIndex = 23;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(73, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 55);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(6, 229);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 55);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // contenedor1
            // 
            this.contenedor1.BackColor = System.Drawing.Color.GhostWhite;
            this.contenedor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contenedor1.Controls.Add(this.label13);
            this.contenedor1.Controls.Add(this.label12);
            this.contenedor1.Controls.Add(this.label11);
            this.contenedor1.Controls.Add(this.txtId);
            this.contenedor1.Controls.Add(this.btnAgregar);
            this.contenedor1.Controls.Add(this.btnAñadir);
            this.contenedor1.Controls.Add(this.btnCancelar);
            this.contenedor1.Controls.Add(this.cbbMateria);
            this.contenedor1.Controls.Add(this.cbbCarrera);
            this.contenedor1.Controls.Add(this.cbbProfesor);
            this.contenedor1.Controls.Add(this.txtMatricula);
            this.contenedor1.Controls.Add(this.txtApellido);
            this.contenedor1.Controls.Add(this.label7);
            this.contenedor1.Controls.Add(this.txtNombre);
            this.contenedor1.Controls.Add(this.label1);
            this.contenedor1.Controls.Add(this.label6);
            this.contenedor1.Controls.Add(this.label2);
            this.contenedor1.Controls.Add(this.label5);
            this.contenedor1.Controls.Add(this.label3);
            this.contenedor1.Controls.Add(this.label4);
            this.contenedor1.Location = new System.Drawing.Point(1, 16);
            this.contenedor1.Name = "contenedor1";
            this.contenedor1.Size = new System.Drawing.Size(205, 301);
            this.contenedor1.TabIndex = 3;
            this.contenedor1.TabStop = false;
            this.contenedor1.Enter += new System.EventHandler(this.contenedor1_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(155, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "M/P";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Agregar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(78, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cancelar";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Thistle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(66, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(149, 230);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(50, 55);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // cbbMateria
            // 
            this.cbbMateria.DataSource = this.tblEstudiantesBindingSource;
            this.cbbMateria.DisplayMember = "Materia";
            this.cbbMateria.FormattingEnabled = true;
            this.cbbMateria.Location = new System.Drawing.Point(66, 158);
            this.cbbMateria.Name = "cbbMateria";
            this.cbbMateria.Size = new System.Drawing.Size(127, 21);
            this.cbbMateria.TabIndex = 6;
            this.cbbMateria.ValueMember = "Materia";
            // 
            // cbbCarrera
            // 
            this.cbbCarrera.FormattingEnabled = true;
            this.cbbCarrera.Items.AddRange(new object[] {
            "==============",
            "INFORMATICA",
            "==============",
            "-  Software",
            "-  Soporte",
            "-  Redes",
            "==============",
            "SALUD",
            "==============",
            "",
            "==============",
            "TURISMO",
            "==============",
            "",
            "==============",
            "INDUSTRIAL",
            "==============",
            "",
            "==============",
            "ARTE",
            "==============",
            "",
            "==============",
            "CONSTRUCCION",
            "==============",
            "",
            "==============",
            "ELECTROMECANICA",
            "=============="});
            this.cbbCarrera.Location = new System.Drawing.Point(66, 128);
            this.cbbCarrera.Name = "cbbCarrera";
            this.cbbCarrera.Size = new System.Drawing.Size(127, 21);
            this.cbbCarrera.TabIndex = 5;
            this.cbbCarrera.Text = "Software";
            // 
            // cbbProfesor
            // 
            this.cbbProfesor.DataSource = this.tblEstudiantesBindingSource1;
            this.cbbProfesor.DisplayMember = "Profesor";
            this.cbbProfesor.FormattingEnabled = true;
            this.cbbProfesor.Location = new System.Drawing.Point(66, 188);
            this.cbbProfesor.Name = "cbbProfesor";
            this.cbbProfesor.Size = new System.Drawing.Size(127, 21);
            this.cbbProfesor.TabIndex = 7;
            this.cbbProfesor.ValueMember = "Profesor";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(66, 99);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Profesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // tblEstudiantesTableAdapter
            // 
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Indigo;
            this.barra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.barra1.FlatAppearance.BorderSize = 0;
            this.barra1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.barra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barra1.ForeColor = System.Drawing.SystemColors.Control;
            this.barra1.Image = ((System.Drawing.Image)(resources.GetObject("barra1.Image")));
            this.barra1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barra1.Location = new System.Drawing.Point(207, 2);
            this.barra1.Margin = new System.Windows.Forms.Padding(0);
            this.barra1.Name = "barra1";
            this.barra1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.barra1.Size = new System.Drawing.Size(455, 19);
            this.barra1.TabIndex = 22;
            this.barra1.Text = "                                                    SISTEMA ESTUDIANTIL-YC";
            this.barra1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barra1.UseVisualStyleBackColor = false;
            this.barra1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra1_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(631, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(22, 19);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(66, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(653, 318);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.contenedor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "              SISTEMA ESTUDIANTIL YC";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEstudiantes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblEstudiantesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstudiantesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.contenedor1.ResumeLayout(false);
            this.contenedor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkMateria;
        private System.Windows.Forms.CheckBox chkSencillo;
        private System.Windows.Forms.CheckBox chkProfesor;
        private System.Windows.Forms.CheckBox chkCarrera;
        private System.Windows.Forms.DataGridView dgvDatos2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbbBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNoSeEncontraronDatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.BindingSource dBControlEstudiantesDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblEstudiantesBindingSource;
        private System.Windows.Forms.BindingSource tblEstudiantesBindingSource1;
        private System.Windows.Forms.GroupBox contenedor1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbbMateria;
        private System.Windows.Forms.ComboBox cbbCarrera;
        private System.Windows.Forms.ComboBox cbbProfesor;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button barra1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
    }
}