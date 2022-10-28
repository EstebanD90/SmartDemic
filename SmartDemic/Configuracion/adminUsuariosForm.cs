using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Entitites;
using Framework.PatenteFamilia.Business;
using Framework.PatenteFamilia.Entity;

namespace SmartDemic.Configuracion
{
    public partial class adminUsuariosForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static adminUsuariosForm instancia = null;
        public static adminUsuariosForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new adminUsuariosForm();
                return instancia;
            }
            return instancia;
        }
        public adminUsuariosForm()
        {
            InitializeComponent();
        }
        #endregion

        private void adminUsuariosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void RefrescarListaUsuarios()
        {
            var Usuarios = new UsuarioBLL().GetUsuarios();
            dtGv_usuarios.DataSource = Usuarios;
        }

        private void LimpiarForm()
        {
            txtb_usuario_nombre.Text = "";
            txtb_usuario_apellido.Text = "";
            txtb_usuario_user.Text = "";
            txtb_usuario_password.Text = "";
            txtb_usuario_email.Text = "";
            cmb_usuario_tipoUser.Text = "";
            txtb_usuario_busqueda.Text = "";
            
        }

        private void adminUsuariosForm_Load(object sender, EventArgs e)
        {
            //var Alumnos = AlumnosInterface.ObtenerAlumnos();
            var Usuarios = new UsuarioBLL().GetUsuarios();

            //dtGv_alumnos2.DataSource = Alumnos;
            dtGv_usuarios.DataSource = Usuarios;

            
            txtb_usuario_user.Text = txtb_usuario_nombre.Text + "." + txtb_usuario_apellido.Text;
            txtb_usuario_password.Text = "1234";
            
            txtb_usuario_user.Enabled = false;
            txtb_usuario_password.Enabled = false;

        }
        private void txtb_alum_nroDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_apellido_Click(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_password_Click(object sender, EventArgs e)
        {

        }

        private void txtb_usuario_nombre_TextChanged(object sender, EventArgs e)
        {
            txtb_usuario_user.Text = txtb_usuario_nombre.Text + "." + txtb_usuario_apellido.Text; ;
        }

        private void txtb_usuario_apellido_TextChanged(object sender, EventArgs e)
        {
            txtb_usuario_user.Text = txtb_usuario_nombre.Text + "." + txtb_usuario_apellido.Text;
        }

        private void lbl_usuario_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_tipoUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuario_guardar_Click(object sender, EventArgs e)
        {
            var id = dtGv_usuarios.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (id != null)
                {
                    Usuario usuario = new Usuario();

                    usuario = new UsuarioBLL().GetUserByID(Guid.Parse(id));


                    //usuario.id = Guid.Parse(dtGv_usuarios.CurrentRow.Cells[0].Value.ToString());
                    usuario.nombre = txtb_usuario_nombre.Text;
                    usuario.apellido = txtb_usuario_apellido.Text;
                    usuario.usuario = txtb_usuario_user.Text;
                    usuario.email = txtb_usuario_email.Text;
                    usuario.tipo_usuario = cmb_usuario_tipoUser.SelectedItem.ToString();

                    //usuario.fecha_creacion = DateTime.Now;

                    new UsuarioBLL().ObtenerOcrearUsuario(usuario);

                    //new UsuarioBLL().CrearUsuario(usuario);

                    MessageBox.Show("Usuario modificado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefrescarListaUsuarios();
                    LimpiarForm();
                }   
                else
                {
                    Usuario usuario = new Usuario();

                    usuario.id = Guid.NewGuid();
                    usuario.nombre = txtb_usuario_nombre.Text;
                    usuario.apellido = txtb_usuario_apellido.Text;
                    usuario.usuario = txtb_usuario_user.Text;
                    usuario.password = txtb_usuario_password.Text;
                    usuario.email = txtb_usuario_email.Text;
                    usuario.tipo_usuario = cmb_usuario_tipoUser.SelectedItem.ToString();
                    usuario.fecha_creacion = DateTime.Now;


                    new UsuarioBLL().CrearUsuario(usuario);

                    MessageBox.Show("Usuario creado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefrescarListaUsuarios();
                    LimpiarForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtGv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Usuario usuario = new Usuario();

            Usuario usuario = new UsuarioBLL().GetUserByID(Guid.Parse(dtGv_usuarios.CurrentRow.Cells[0].Value.ToString()));

            txtb_usuario_nombre.Text = usuario.nombre;
            txtb_usuario_apellido.Text = usuario.apellido;
            txtb_usuario_user.Text = usuario.usuario;
            txtb_usuario_password.Text = usuario.password;
            txtb_usuario_email.Text = usuario.email;
            cmb_usuario_tipoUser.Text = usuario.tipo_usuario;
        }

        private void btn_usuario_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void txtb_usuario_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_usuario_busqueda_TextChanged(object sender, EventArgs e)
        {
            //Apellido
            //Email
            //Usuario
            //Tipo de usuario



            if (cmb_usuario_busqueda.Text == "Apellido")
            {
                Usuario usuario = new UsuarioBLL().GetUserByApellido(txtb_usuario_apellido.Text);

            }


        }
    }
}
