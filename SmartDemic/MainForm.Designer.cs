namespace SmartDemic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalAdministrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesExternasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reunionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exámenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lbl_mainform_user = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_fechaHora = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.radStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_mainform_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalAdministrativoToolStripMenuItem,
            this.gestiónDeModulosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // personalAdministrativoToolStripMenuItem
            // 
            this.personalAdministrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMAlumnosToolStripMenuItem,
            this.aBMDocentesToolStripMenuItem,
            this.actividadesExternasToolStripMenuItem,
            this.observacionesToolStripMenuItem,
            this.reunionesToolStripMenuItem});
            resources.ApplyResources(this.personalAdministrativoToolStripMenuItem, "personalAdministrativoToolStripMenuItem");
            this.personalAdministrativoToolStripMenuItem.Name = "personalAdministrativoToolStripMenuItem";
            // 
            // aBMAlumnosToolStripMenuItem
            // 
            this.aBMAlumnosToolStripMenuItem.Name = "aBMAlumnosToolStripMenuItem";
            resources.ApplyResources(this.aBMAlumnosToolStripMenuItem, "aBMAlumnosToolStripMenuItem");
            this.aBMAlumnosToolStripMenuItem.Click += new System.EventHandler(this.aBMAlumnosToolStripMenuItem_Click);
            // 
            // aBMDocentesToolStripMenuItem
            // 
            this.aBMDocentesToolStripMenuItem.Name = "aBMDocentesToolStripMenuItem";
            resources.ApplyResources(this.aBMDocentesToolStripMenuItem, "aBMDocentesToolStripMenuItem");
            this.aBMDocentesToolStripMenuItem.Click += new System.EventHandler(this.aBMDocentesToolStripMenuItem_Click);
            // 
            // actividadesExternasToolStripMenuItem
            // 
            this.actividadesExternasToolStripMenuItem.Name = "actividadesExternasToolStripMenuItem";
            resources.ApplyResources(this.actividadesExternasToolStripMenuItem, "actividadesExternasToolStripMenuItem");
            this.actividadesExternasToolStripMenuItem.Click += new System.EventHandler(this.actividadesExternasToolStripMenuItem_Click);
            // 
            // observacionesToolStripMenuItem
            // 
            this.observacionesToolStripMenuItem.Name = "observacionesToolStripMenuItem";
            resources.ApplyResources(this.observacionesToolStripMenuItem, "observacionesToolStripMenuItem");
            this.observacionesToolStripMenuItem.Click += new System.EventHandler(this.observacionesToolStripMenuItem_Click);
            // 
            // reunionesToolStripMenuItem
            // 
            this.reunionesToolStripMenuItem.Name = "reunionesToolStripMenuItem";
            resources.ApplyResources(this.reunionesToolStripMenuItem, "reunionesToolStripMenuItem");
            this.reunionesToolStripMenuItem.Click += new System.EventHandler(this.reunionesToolStripMenuItem_Click);
            // 
            // gestiónDeModulosToolStripMenuItem
            // 
            this.gestiónDeModulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMModulosToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            resources.ApplyResources(this.gestiónDeModulosToolStripMenuItem, "gestiónDeModulosToolStripMenuItem");
            this.gestiónDeModulosToolStripMenuItem.Name = "gestiónDeModulosToolStripMenuItem";
            // 
            // aBMModulosToolStripMenuItem
            // 
            this.aBMModulosToolStripMenuItem.Name = "aBMModulosToolStripMenuItem";
            resources.ApplyResources(this.aBMModulosToolStripMenuItem, "aBMModulosToolStripMenuItem");
            this.aBMModulosToolStripMenuItem.Click += new System.EventHandler(this.aBMModulosToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            resources.ApplyResources(this.dashboardToolStripMenuItem, "dashboardToolStripMenuItem");
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciasToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.exámenesToolStripMenuItem});
            resources.ApplyResources(this.docentesToolStripMenuItem, "docentesToolStripMenuItem");
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Click += new System.EventHandler(this.docentesToolStripMenuItem_Click);
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            resources.ApplyResources(this.asistenciasToolStripMenuItem, "asistenciasToolStripMenuItem");
            this.asistenciasToolStripMenuItem.Click += new System.EventHandler(this.asistenciasToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            resources.ApplyResources(this.calificacionesToolStripMenuItem, "calificacionesToolStripMenuItem");
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // exámenesToolStripMenuItem
            // 
            this.exámenesToolStripMenuItem.Name = "exámenesToolStripMenuItem";
            resources.ApplyResources(this.exámenesToolStripMenuItem, "exámenesToolStripMenuItem");
            this.exámenesToolStripMenuItem.Click += new System.EventHandler(this.exámenesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.crearPresupuestoToolStripMenuItem});
            resources.ApplyResources(this.alumnosToolStripMenuItem, "alumnosToolStripMenuItem");
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            resources.ApplyResources(this.inventarioToolStripMenuItem, "inventarioToolStripMenuItem");
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // crearPresupuestoToolStripMenuItem
            // 
            this.crearPresupuestoToolStripMenuItem.Name = "crearPresupuestoToolStripMenuItem";
            resources.ApplyResources(this.crearPresupuestoToolStripMenuItem, "crearPresupuestoToolStripMenuItem");
            this.crearPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.crearPresupuestoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminUsuariosToolStripMenuItem,
            this.familiasToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            resources.ApplyResources(this.configuracionToolStripMenuItem, "configuracionToolStripMenuItem");
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            // 
            // adminUsuariosToolStripMenuItem
            // 
            this.adminUsuariosToolStripMenuItem.Name = "adminUsuariosToolStripMenuItem";
            resources.ApplyResources(this.adminUsuariosToolStripMenuItem, "adminUsuariosToolStripMenuItem");
            this.adminUsuariosToolStripMenuItem.Click += new System.EventHandler(this.adminUsuariosToolStripMenuItem_Click);
            // 
            // familiasToolStripMenuItem
            // 
            this.familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            resources.ApplyResources(this.familiasToolStripMenuItem, "familiasToolStripMenuItem");
            this.familiasToolStripMenuItem.Click += new System.EventHandler(this.familiasToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            resources.ApplyResources(this.salirDelSistemaToolStripMenuItem, "salirDelSistemaToolStripMenuItem");
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiónToolStripMenuItem});
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            // 
            // versiónToolStripMenuItem
            // 
            this.versiónToolStripMenuItem.Name = "versiónToolStripMenuItem";
            resources.ApplyResources(this.versiónToolStripMenuItem, "versiónToolStripMenuItem");
            this.versiónToolStripMenuItem.Click += new System.EventHandler(this.versiónToolStripMenuItem_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Controls.Add(this.lbl_mainform_user);
            this.radStatusStrip1.Controls.Add(this.radLabel1);
            this.radStatusStrip1.Controls.Add(this.lbl_fechaHora);
            resources.ApplyResources(this.radStatusStrip1, "radStatusStrip1");
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.StatusBarClick += new Telerik.WinControls.UI.RadStatusStrip.RadStatusBarClickEvenHandler(this.radStatusStrip1_StatusBarClick);
            // 
            // lbl_mainform_user
            // 
            resources.ApplyResources(this.lbl_mainform_user, "lbl_mainform_user");
            this.lbl_mainform_user.Name = "lbl_mainform_user";
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            // 
            // lbl_fechaHora
            // 
            resources.ApplyResources(this.lbl_fechaHora, "lbl_fechaHora");
            this.lbl_fechaHora.Name = "lbl_fechaHora";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.radStatusStrip1.ResumeLayout(false);
            this.radStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_mainform_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalAdministrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeModulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesExternasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reunionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMModulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exámenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiónToolStripMenuItem;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Label lbl_fechaHora;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Telerik.WinControls.UI.RadLabel lbl_mainform_user;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}

