namespace SmartDemic.Configuracion
{
    partial class adminUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminUsuariosForm));
            this.dtGv_usuarios = new System.Windows.Forms.DataGridView();
            this.cmb_usuario_tipoUser = new System.Windows.Forms.ComboBox();
            this.btn_usuario_refresh = new Telerik.WinControls.UI.RadButton();
            this.txtb_usuario_password = new Telerik.WinControls.UI.RadTextBox();
            this.txtb_usuario_user = new Telerik.WinControls.UI.RadTextBox();
            this.txtb_usuario_email = new Telerik.WinControls.UI.RadTextBox();
            this.txtb_usuario_apellido = new Telerik.WinControls.UI.RadTextBox();
            this.txtb_usuario_nombre = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_usuario_email = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_tipoUser = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_password = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_user = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_apellido = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_nombre = new Telerik.WinControls.UI.RadLabel();
            this.btn_usuario_guardar = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_usuario_buscar = new Telerik.WinControls.UI.RadButton();
            this.cmb_usuario_busqueda = new System.Windows.Forms.ComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_usuario_busqueda = new Telerik.WinControls.UI.RadLabel();
            this.txtb_usuario_busqueda = new Telerik.WinControls.UI.RadTextBox();
            this.btn_usuario_limpiar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_apellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_tipoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_apellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_guardar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGv_usuarios
            // 
            this.dtGv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGv_usuarios.Location = new System.Drawing.Point(35, 249);
            this.dtGv_usuarios.Name = "dtGv_usuarios";
            this.dtGv_usuarios.Size = new System.Drawing.Size(991, 243);
            this.dtGv_usuarios.TabIndex = 35;
            this.dtGv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGv_usuarios_CellClick);
            // 
            // cmb_usuario_tipoUser
            // 
            this.cmb_usuario_tipoUser.FormattingEnabled = true;
            this.cmb_usuario_tipoUser.Items.AddRange(new object[] {
            "ADMIN",
            "PERS. ADMINISTRATIVO",
            "DOCENTE",
            "BASICO"});
            this.cmb_usuario_tipoUser.Location = new System.Drawing.Point(667, 32);
            this.cmb_usuario_tipoUser.Name = "cmb_usuario_tipoUser";
            this.cmb_usuario_tipoUser.Size = new System.Drawing.Size(184, 21);
            this.cmb_usuario_tipoUser.TabIndex = 34;
            // 
            // btn_usuario_refresh
            // 
            this.btn_usuario_refresh.AutoSize = true;
            this.btn_usuario_refresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_usuario_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario_refresh.Image")));
            this.btn_usuario_refresh.Location = new System.Drawing.Point(889, 185);
            this.btn_usuario_refresh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_usuario_refresh.Name = "btn_usuario_refresh";
            this.btn_usuario_refresh.Size = new System.Drawing.Size(129, 34);
            this.btn_usuario_refresh.TabIndex = 33;
            this.btn_usuario_refresh.Text = "Actualizar Lista";
            this.btn_usuario_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // txtb_usuario_password
            // 
            this.txtb_usuario_password.Location = new System.Drawing.Point(667, 74);
            this.txtb_usuario_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_password.Name = "txtb_usuario_password";
            this.txtb_usuario_password.PasswordChar = '*';
            this.txtb_usuario_password.Size = new System.Drawing.Size(184, 20);
            this.txtb_usuario_password.TabIndex = 32;
            this.txtb_usuario_password.TextChanged += new System.EventHandler(this.txtb_usuario_password_TextChanged);
            // 
            // txtb_usuario_user
            // 
            this.txtb_usuario_user.Location = new System.Drawing.Point(390, 74);
            this.txtb_usuario_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_user.Name = "txtb_usuario_user";
            this.txtb_usuario_user.ReadOnly = true;
            this.txtb_usuario_user.Size = new System.Drawing.Size(195, 20);
            this.txtb_usuario_user.TabIndex = 30;
            this.txtb_usuario_user.TextChanged += new System.EventHandler(this.txtb_usuario_nombre_TextChanged);
            // 
            // txtb_usuario_email
            // 
            this.txtb_usuario_email.Location = new System.Drawing.Point(83, 72);
            this.txtb_usuario_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_email.Name = "txtb_usuario_email";
            this.txtb_usuario_email.Size = new System.Drawing.Size(206, 20);
            this.txtb_usuario_email.TabIndex = 28;
            // 
            // txtb_usuario_apellido
            // 
            this.txtb_usuario_apellido.Location = new System.Drawing.Point(390, 29);
            this.txtb_usuario_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_apellido.Name = "txtb_usuario_apellido";
            this.txtb_usuario_apellido.Size = new System.Drawing.Size(195, 20);
            this.txtb_usuario_apellido.TabIndex = 27;
            this.txtb_usuario_apellido.TextChanged += new System.EventHandler(this.txtb_usuario_apellido_TextChanged);
            // 
            // txtb_usuario_nombre
            // 
            this.txtb_usuario_nombre.Location = new System.Drawing.Point(83, 29);
            this.txtb_usuario_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_nombre.Name = "txtb_usuario_nombre";
            this.txtb_usuario_nombre.Size = new System.Drawing.Size(206, 20);
            this.txtb_usuario_nombre.TabIndex = 26;
            this.txtb_usuario_nombre.TextChanged += new System.EventHandler(this.txtb_usuario_nombre_TextChanged);
            // 
            // lbl_usuario_email
            // 
            this.lbl_usuario_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_email.Location = new System.Drawing.Point(42, 72);
            this.lbl_usuario_email.Margin = new System.Windows.Forms.Padding(12);
            this.lbl_usuario_email.Name = "lbl_usuario_email";
            this.lbl_usuario_email.Size = new System.Drawing.Size(42, 21);
            this.lbl_usuario_email.TabIndex = 23;
            this.lbl_usuario_email.Text = "Email:";
            this.lbl_usuario_email.Click += new System.EventHandler(this.lbl_usuario_email_Click);
            // 
            // lbl_usuario_tipoUser
            // 
            this.lbl_usuario_tipoUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_tipoUser.Location = new System.Drawing.Point(635, 32);
            this.lbl_usuario_tipoUser.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_usuario_tipoUser.Name = "lbl_usuario_tipoUser";
            this.lbl_usuario_tipoUser.Size = new System.Drawing.Size(30, 21);
            this.lbl_usuario_tipoUser.TabIndex = 21;
            this.lbl_usuario_tipoUser.Text = "Rol:";
            this.lbl_usuario_tipoUser.Click += new System.EventHandler(this.lbl_usuario_tipoUser_Click);
            // 
            // lbl_usuario_password
            // 
            this.lbl_usuario_password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_password.Location = new System.Drawing.Point(598, 73);
            this.lbl_usuario_password.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_usuario_password.Name = "lbl_usuario_password";
            this.lbl_usuario_password.Size = new System.Drawing.Size(67, 21);
            this.lbl_usuario_password.TabIndex = 20;
            this.lbl_usuario_password.Text = "Password:";
            this.lbl_usuario_password.Click += new System.EventHandler(this.lbl_usuario_password_Click);
            // 
            // lbl_usuario_user
            // 
            this.lbl_usuario_user.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_user.Location = new System.Drawing.Point(334, 72);
            this.lbl_usuario_user.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_usuario_user.Name = "lbl_usuario_user";
            this.lbl_usuario_user.Size = new System.Drawing.Size(56, 21);
            this.lbl_usuario_user.TabIndex = 19;
            this.lbl_usuario_user.Text = "Usuario:";
            // 
            // lbl_usuario_apellido
            // 
            this.lbl_usuario_apellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_apellido.Location = new System.Drawing.Point(324, 32);
            this.lbl_usuario_apellido.Margin = new System.Windows.Forms.Padding(6);
            this.lbl_usuario_apellido.Name = "lbl_usuario_apellido";
            this.lbl_usuario_apellido.Size = new System.Drawing.Size(66, 21);
            this.lbl_usuario_apellido.TabIndex = 18;
            this.lbl_usuario_apellido.Text = "Apellidos:";
            this.lbl_usuario_apellido.Click += new System.EventHandler(this.lbl_usuario_apellido_Click);
            // 
            // lbl_usuario_nombre
            // 
            this.lbl_usuario_nombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_nombre.Location = new System.Drawing.Point(18, 32);
            this.lbl_usuario_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_usuario_nombre.Name = "lbl_usuario_nombre";
            this.lbl_usuario_nombre.Size = new System.Drawing.Size(66, 21);
            this.lbl_usuario_nombre.TabIndex = 25;
            this.lbl_usuario_nombre.Text = "Nombres:";
            // 
            // btn_usuario_guardar
            // 
            this.btn_usuario_guardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_usuario_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario_guardar.Image")));
            this.btn_usuario_guardar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_usuario_guardar.Location = new System.Drawing.Point(896, 33);
            this.btn_usuario_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_usuario_guardar.Name = "btn_usuario_guardar";
            this.btn_usuario_guardar.Size = new System.Drawing.Size(88, 62);
            this.btn_usuario_guardar.TabIndex = 17;
            this.btn_usuario_guardar.Text = "Guardar";
            this.btn_usuario_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_usuario_guardar.Click += new System.EventHandler(this.btn_usuario_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lbl_usuario_nombre);
            this.groupBox1.Controls.Add(this.lbl_usuario_apellido);
            this.groupBox1.Controls.Add(this.cmb_usuario_tipoUser);
            this.groupBox1.Controls.Add(this.lbl_usuario_user);
            this.groupBox1.Controls.Add(this.btn_usuario_guardar);
            this.groupBox1.Controls.Add(this.lbl_usuario_password);
            this.groupBox1.Controls.Add(this.txtb_usuario_password);
            this.groupBox1.Controls.Add(this.lbl_usuario_tipoUser);
            this.groupBox1.Controls.Add(this.txtb_usuario_user);
            this.groupBox1.Controls.Add(this.lbl_usuario_email);
            this.groupBox1.Controls.Add(this.txtb_usuario_email);
            this.groupBox1.Controls.Add(this.txtb_usuario_nombre);
            this.groupBox1.Controls.Add(this.txtb_usuario_apellido);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 123);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btn_usuario_buscar);
            this.groupBox2.Controls.Add(this.cmb_usuario_busqueda);
            this.groupBox2.Controls.Add(this.radLabel1);
            this.groupBox2.Controls.Add(this.lbl_usuario_busqueda);
            this.groupBox2.Controls.Add(this.txtb_usuario_busqueda);
            this.groupBox2.Location = new System.Drawing.Point(35, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 92);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Usuario";
            // 
            // btn_usuario_buscar
            // 
            this.btn_usuario_buscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_usuario_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario_buscar.Image")));
            this.btn_usuario_buscar.Location = new System.Drawing.Point(603, 30);
            this.btn_usuario_buscar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_usuario_buscar.Name = "btn_usuario_buscar";
            this.btn_usuario_buscar.Size = new System.Drawing.Size(118, 39);
            this.btn_usuario_buscar.TabIndex = 38;
            this.btn_usuario_buscar.Text = "Buscar";
            this.btn_usuario_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // cmb_usuario_busqueda
            // 
            this.cmb_usuario_busqueda.FormattingEnabled = true;
            this.cmb_usuario_busqueda.Items.AddRange(new object[] {
            "Apellido",
            "Email",
            "Usuario",
            "Tipo de usuario"});
            this.cmb_usuario_busqueda.Location = new System.Drawing.Point(428, 38);
            this.cmb_usuario_busqueda.Name = "cmb_usuario_busqueda";
            this.cmb_usuario_busqueda.Size = new System.Drawing.Size(155, 21);
            this.cmb_usuario_busqueda.TabIndex = 41;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(351, 38);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 21);
            this.radLabel1.TabIndex = 40;
            this.radLabel1.Text = "Buscar por:";
            // 
            // lbl_usuario_busqueda
            // 
            this.lbl_usuario_busqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_usuario_busqueda.Location = new System.Drawing.Point(19, 38);
            this.lbl_usuario_busqueda.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_usuario_busqueda.Name = "lbl_usuario_busqueda";
            this.lbl_usuario_busqueda.Size = new System.Drawing.Size(70, 21);
            this.lbl_usuario_busqueda.TabIndex = 38;
            this.lbl_usuario_busqueda.Text = "Busqueda:";
            // 
            // txtb_usuario_busqueda
            // 
            this.txtb_usuario_busqueda.Location = new System.Drawing.Point(91, 38);
            this.txtb_usuario_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_usuario_busqueda.Name = "txtb_usuario_busqueda";
            this.txtb_usuario_busqueda.Size = new System.Drawing.Size(219, 24);
            this.txtb_usuario_busqueda.TabIndex = 39;
            this.txtb_usuario_busqueda.TextChanged += new System.EventHandler(this.txtb_usuario_busqueda_TextChanged);
            // 
            // btn_usuario_limpiar
            // 
            this.btn_usuario_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario_limpiar.Image")));
            this.btn_usuario_limpiar.Location = new System.Drawing.Point(916, 141);
            this.btn_usuario_limpiar.Name = "btn_usuario_limpiar";
            this.btn_usuario_limpiar.Size = new System.Drawing.Size(110, 24);
            this.btn_usuario_limpiar.TabIndex = 35;
            this.btn_usuario_limpiar.Text = "Limpiar Filtros";
            this.btn_usuario_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuario_limpiar.Click += new System.EventHandler(this.btn_usuario_limpiar_Click);
            // 
            // adminUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 510);
            this.Controls.Add(this.btn_usuario_limpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGv_usuarios);
            this.Controls.Add(this.btn_usuario_refresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminUsuariosForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminUsuariosForm_FormClosing);
            this.Load += new System.EventHandler(this.adminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_apellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_tipoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_apellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_guardar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_usuario_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_usuario_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usuario_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGv_usuarios;
        private System.Windows.Forms.ComboBox cmb_usuario_tipoUser;
        private Telerik.WinControls.UI.RadButton btn_usuario_refresh;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_password;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_user;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_email;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_apellido;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_nombre;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_email;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_tipoUser;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_password;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_user;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_apellido;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_nombre;
        private Telerik.WinControls.UI.RadButton btn_usuario_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_usuario_busqueda;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lbl_usuario_busqueda;
        private Telerik.WinControls.UI.RadTextBox txtb_usuario_busqueda;
        private Telerik.WinControls.UI.RadButton btn_usuario_buscar;
        private Telerik.WinControls.UI.RadButton btn_usuario_limpiar;
    }
}
