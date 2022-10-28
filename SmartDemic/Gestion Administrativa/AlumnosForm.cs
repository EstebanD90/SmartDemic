using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using SmartDemic.Interfaces;
using Entitites;
using Business;

namespace SmartDemic
{
    public partial class AlumnosForm : Telerik.WinControls.UI.RadForm
    {

        #region SingletonForm
        public static AlumnosForm instancia = null;
        public static AlumnosForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new AlumnosForm();
                return instancia;
            }
            return instancia;
        }

        public AlumnosForm()
        {
            InitializeComponent();
        }
        #endregion


        private void AlumnosForm_Load(object sender, EventArgs e)
        {
            //var Alumnos = AlumnosInterface.ObtenerAlumnos();
            var Alumnos = Business.AlumnoBLL.Current.GetAll();

            dtGv_alumnos.DataSource = Alumnos;
        }

        private void AlumnosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_alum_guardar_Click(object sender, EventArgs e)
        {
        }

        private void btn_alum_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var alumno = new Alumno();


                alumno.nombre = txtb_alum_nombre.Text;
                alumno.apellido = txtb_alum_apellido.Text;
                alumno.nro_documento = int.Parse(txtb_alum_nroDoc.Text);
                alumno.telefono = int.Parse(txtb_alum_telefono.Text);
                alumno.domicilio = txtb_alum_domicilio.Text;
                alumno.localidad = txtb_alum_localidad.Text;
                alumno.email = txtb_alum_email.Text;
                alumno.fecha_nacimiento = dTP_alum_fechaNac.Value;
                alumno.fecha_ingreso = DateTime.Now;
                alumno.estado = "activo";


                //alumno = AlumnoBLL.Current.Insert();


                MessageBox.Show("Alumno creado correctamente.", "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }
    }
}
