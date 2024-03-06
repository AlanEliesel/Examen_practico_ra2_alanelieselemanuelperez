namespace examen_practico_RA2_DenzelAlvarez
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.C_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblMaestro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaestro = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cmbAreaTecnica = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.rbtnFemenino);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(430, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 146);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero:";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Enabled = false;
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnMasculino.Location = new System.Drawing.Point(39, 30);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(135, 30);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Enabled = false;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnFemenino.Location = new System.Drawing.Point(40, 90);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(134, 30);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(996, 177);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 60);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Matricula,
            this.C_Nombre,
            this.C_Direccion,
            this.C_Telefono,
            this.C_Genero,
            this.C_Email,
            this.C_Curso,
            this.C_Seccion,
            this.C_Area,
            this.C_Maestro});
            this.dgvDatos.Enabled = false;
            this.dgvDatos.Location = new System.Drawing.Point(26, 439);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.Size = new System.Drawing.Size(1892, 293);
            this.dgvDatos.TabIndex = 51;
            // 
            // C_Matricula
            // 
            this.C_Matricula.HeaderText = "Matricula";
            this.C_Matricula.MinimumWidth = 8;
            this.C_Matricula.Name = "C_Matricula";
            this.C_Matricula.ReadOnly = true;
            this.C_Matricula.Width = 150;
            // 
            // C_Nombre
            // 
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.MinimumWidth = 8;
            this.C_Nombre.Name = "C_Nombre";
            this.C_Nombre.ReadOnly = true;
            this.C_Nombre.Width = 150;
            // 
            // C_Direccion
            // 
            this.C_Direccion.HeaderText = "Direccion";
            this.C_Direccion.MinimumWidth = 8;
            this.C_Direccion.Name = "C_Direccion";
            this.C_Direccion.ReadOnly = true;
            this.C_Direccion.Width = 150;
            // 
            // C_Telefono
            // 
            this.C_Telefono.HeaderText = "Telefono";
            this.C_Telefono.MinimumWidth = 8;
            this.C_Telefono.Name = "C_Telefono";
            this.C_Telefono.ReadOnly = true;
            this.C_Telefono.Width = 150;
            // 
            // C_Genero
            // 
            this.C_Genero.HeaderText = "Genero";
            this.C_Genero.MinimumWidth = 8;
            this.C_Genero.Name = "C_Genero";
            this.C_Genero.ReadOnly = true;
            this.C_Genero.Width = 150;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "Email";
            this.C_Email.MinimumWidth = 8;
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
            this.C_Email.Width = 150;
            // 
            // C_Curso
            // 
            this.C_Curso.HeaderText = "Curso";
            this.C_Curso.MinimumWidth = 8;
            this.C_Curso.Name = "C_Curso";
            this.C_Curso.ReadOnly = true;
            this.C_Curso.Width = 150;
            // 
            // C_Seccion
            // 
            this.C_Seccion.HeaderText = "Seccion";
            this.C_Seccion.MinimumWidth = 8;
            this.C_Seccion.Name = "C_Seccion";
            this.C_Seccion.ReadOnly = true;
            this.C_Seccion.Width = 150;
            // 
            // C_Area
            // 
            this.C_Area.HeaderText = "Area";
            this.C_Area.MinimumWidth = 8;
            this.C_Area.Name = "C_Area";
            this.C_Area.ReadOnly = true;
            this.C_Area.Width = 150;
            // 
            // C_Maestro
            // 
            this.C_Maestro.HeaderText = "Maestro titular";
            this.C_Maestro.MinimumWidth = 8;
            this.C_Maestro.Name = "C_Maestro";
            this.C_Maestro.ReadOnly = true;
            this.C_Maestro.Width = 150;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Enabled = false;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurso.Location = new System.Drawing.Point(425, 103);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(70, 26);
            this.lblCurso.TabIndex = 50;
            this.lblCurso.Text = "Curso";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Silver;
            this.btn_limpiar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_limpiar.Location = new System.Drawing.Point(1087, 265);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(190, 67);
            this.btn_limpiar.TabIndex = 54;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Enabled = false;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.Location = new System.Drawing.Point(384, 49);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(139, 26);
            this.lblArea.TabIndex = 49;
            this.lblArea.Text = "Área Técnica";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Enabled = false;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeccion.Location = new System.Drawing.Point(425, 167);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(90, 26);
            this.lblSeccion.TabIndex = 48;
            this.lblSeccion.Text = "Sección";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(1522, 139);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(237, 63);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(1220, 95);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 63);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(1220, 182);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 60);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Silver;
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(996, 95);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(162, 60);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // lblMaestro
            // 
            this.lblMaestro.AutoSize = true;
            this.lblMaestro.Enabled = false;
            this.lblMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaestro.Location = new System.Drawing.Point(6, 359);
            this.lblMaestro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaestro.Name = "lblMaestro";
            this.lblMaestro.Size = new System.Drawing.Size(149, 26);
            this.lblMaestro.TabIndex = 43;
            this.lblMaestro.Text = "Maestro titular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(82, 295);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 26);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Enabled = false;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(60, 230);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 26);
            this.lblTelefono.TabIndex = 41;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Enabled = false;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Location = new System.Drawing.Point(56, 162);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(103, 26);
            this.lblDireccion.TabIndex = 40;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(68, 101);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 26);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Enabled = false;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatricula.Location = new System.Drawing.Point(60, 41);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(100, 26);
            this.lblMatricula.TabIndex = 38;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTelefono.Location = new System.Drawing.Point(165, 225);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 32);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(165, 289);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 32);
            this.txtEmail.TabIndex = 36;
            // 
            // txtMaestro
            // 
            this.txtMaestro.Enabled = false;
            this.txtMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaestro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMaestro.Location = new System.Drawing.Point(165, 356);
            this.txtMaestro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaestro.Name = "txtMaestro";
            this.txtMaestro.Size = new System.Drawing.Size(148, 32);
            this.txtMaestro.TabIndex = 35;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDireccion.Location = new System.Drawing.Point(165, 161);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(148, 32);
            this.txtDireccion.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNombre.Location = new System.Drawing.Point(165, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 32);
            this.txtNombre.TabIndex = 33;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMatricula.Location = new System.Drawing.Point(165, 35);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(148, 32);
            this.txtMatricula.TabIndex = 32;
            // 
            // cmbAreaTecnica
            // 
            this.cmbAreaTecnica.Enabled = false;
            this.cmbAreaTecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaTecnica.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbAreaTecnica.FormattingEnabled = true;
            this.cmbAreaTecnica.Items.AddRange(new object[] {
            "Enfermería",
            "Contabilidad",
            "Gastronomía",
            "Enfermería",
            "Informática"});
            this.cmbAreaTecnica.Location = new System.Drawing.Point(545, 41);
            this.cmbAreaTecnica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAreaTecnica.Name = "cmbAreaTecnica";
            this.cmbAreaTecnica.Size = new System.Drawing.Size(180, 34);
            this.cmbAreaTecnica.TabIndex = 31;
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Enabled = false;
            this.cmbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B",
            "C1",
            "C2",
            "D1",
            "D2",
            "E"});
            this.cmbSeccion.Location = new System.Drawing.Point(545, 154);
            this.cmbSeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(180, 34);
            this.cmbSeccion.TabIndex = 30;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Enabled = false;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "4 to",
            "5 to",
            "6 to"});
            this.cmbCurso.Location = new System.Drawing.Point(545, 95);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(180, 34);
            this.cmbCurso.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1924, 766);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblMaestro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaestro);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.cmbAreaTecnica);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Maestro;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblMaestro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaestro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cmbAreaTecnica;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbCurso;
    }
}

