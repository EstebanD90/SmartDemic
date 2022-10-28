using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.PatenteFamilia.Entity;

namespace SmartDemic
{
    public partial class MainForm : Form
    {
        private static Usuario usuarioActual;

        public MainForm(Usuario usuarioObj)
        {
            usuarioActual = usuarioObj;

            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm version = AyudaForm.instancia_unica();
            version.MdiParent = this;
            version.Show();
            version.BringToFront();
        }

        private void aBMAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosForm alumno = AlumnosForm.instancia_unica();
            alumno.MdiParent = this;
            alumno.Show();
            alumno.BringToFront();
        }

        private void aBMDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocentesForm docente = DocentesForm.instancia_unica();
            docente.MdiParent = this;
            docente.Show();
            docente.BringToFront();
        }

        private void actividadesExternasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActividadesExternasForm actividadesExternas = ActividadesExternasForm.instancia_unica();
            actividadesExternas.MdiParent = this;
            actividadesExternas.Show();
            actividadesExternas.BringToFront();
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObservacionesForm observacion = ObservacionesForm.instancia_unica();
            observacion.MdiParent = this;
            observacion.Show();
            observacion.BringToFront();
        }

        private void reunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReunionesForm reunion = ReunionesForm.instancia_unica();
            reunion.MdiParent = this;
            reunion.Show();
            reunion.BringToFront();
        }

        private void aBMModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Modulos.ModulosForm modulo = Gestion_Modulos.ModulosForm.instancia_unica();
            modulo.MdiParent = this;
            modulo.Show();
            modulo.BringToFront();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Docente.AsistenciasForm asistencia = Gestion_Docente.AsistenciasForm.instancia_unica();
            asistencia.MdiParent = this;
            asistencia.Show();
            asistencia.BringToFront();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Docente.CalificacionesForm calificacion = Gestion_Docente.CalificacionesForm.instancia_unica();
            calificacion.MdiParent = this;
            calificacion.Show();
            calificacion.BringToFront();
        }

        private void exámenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Docente.ExamenesForm examen = Gestion_Docente.ExamenesForm.instancia_unica();
            examen.MdiParent = this;
            examen.Show();
            examen.BringToFront();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Inventario.InventarioForm inventario = Gestion_Inventario.InventarioForm.instancia_unica();
            inventario.MdiParent = this;
            inventario.Show();
            inventario.BringToFront();
        }

        private void crearPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Inventario.PresupuestoForm presupuesto = Gestion_Inventario.PresupuestoForm.instancia_unica();
            presupuesto.MdiParent = this;
            presupuesto.Show();
            presupuesto.BringToFront();
        }

        private void adminUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.adminUsuariosForm usuario = Configuracion.adminUsuariosForm.instancia_unica();
            usuario.MdiParent = this;
            usuario.Show();
            usuario.BringToFront();
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.adminFamiliasPatentesForm familiaPatente = Configuracion.adminFamiliasPatentesForm.instancia_unica();
            familiaPatente.MdiParent = this;
            familiaPatente.Show();
            familiaPatente.BringToFront();
        }

        private void radStatusStrip1_StatusBarClick(object sender, Telerik.WinControls.UI.RadStatusBarClickEventArgs args)
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_mainform_user.Text = usuarioActual.usuario;
            lbl_fechaHora.Text = Convert.ToString(DateTime.Now);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Reportes.ReportesForm reportes = Gestion_Reportes.ReportesForm.instancia_unica();
            reportes.MdiParent = this;
            reportes.Show();
            reportes.BringToFront();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
