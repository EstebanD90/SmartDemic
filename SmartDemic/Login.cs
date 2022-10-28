using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Framework.PatenteFamilia.Entity;
using Business;
using System.Linq;
using Framework.PatenteFamilia.Business;

namespace SmartDemic
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_ingresar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetAll();

            Usuario usuario = usuarios.Where(u => u.usuario == txtb_login_user.Text && u.password == txtb_login_password.Text).FirstOrDefault();

            if (usuario != null)
            {
                MainForm mainForm = new MainForm(usuario);

                var userLogin = new UsuarioBLL().GetUserByUsuario(usuario.usuario);
                userLogin.ultimo_ingreso = DateTime.Now;
                UsuarioBLL.ActualizarUsuario(userLogin);


                mainForm.Show();
                this.Hide();

                mainForm.FormClosing += formClosing;
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void formClosing(object sender, FormClosingEventArgs e)
        {
            txtb_login_user.Text = "";
            txtb_login_password.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
