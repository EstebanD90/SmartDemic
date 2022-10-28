using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;
using Framework.PatenteFamilia.Data;
using System.Transactions;

namespace Framework.PatenteFamilia.Business
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuario = new UsuarioDAL();

        public void CrearUsuario(Usuario user)
        {
            try
            {
                usuario.Insert(user);
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new BLLException(ex));
                throw ex;
            }

        }

        public List<Usuario> GetAll()
        {
            return usuario.GetAll();
        }

        public List<Usuario> GetUsuarios()
        {
            return usuario.GetAllUsers();
        }

        public Usuario GetUserByID(Guid id)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetUsuarios();

            Usuario usuarioObj = usuarios.Where(u => u.id == id).FirstOrDefault();

            return usuarioObj;
        }

        public void ObtenerOcrearUsuario(Usuario usuario)
        {
            Usuario userObj = GetUserByID(usuario.id);

            if (userObj == null)
            {
                new UsuarioBLL().CrearUsuario(usuario);
            }
            else
            {
                ActualizarUsuario(usuario);
            }
            //return userObj;
        }


        public static void Delete(Usuario usuario)
        {
            UsuarioDAL.Delete(usuario);
        }

        public static void ActualizarUsuario(Usuario usuario)
        {
            UsuarioDAL.Update(usuario);
        }

        public Usuario GetUserByUsuario(string user)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetUsuarios();

            Usuario usuarioObj = usuarios.Where(u => u.usuario == user).FirstOrDefault();

            return usuarioObj;
        }
        public Usuario GetUserByApellido(string apellido)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetUsuarios();

            Usuario usuarioObj = usuarios.Where(u => u.apellido == apellido).FirstOrDefault();

            return usuarioObj;
        }
        public Usuario GetUserByNombre(string nombre)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetUsuarios();

            Usuario usuarioObj = usuarios.Where(u => u.nombre == nombre).FirstOrDefault();

            return usuarioObj;
        }
        public Usuario GetUserByTipoUsuario(string tipo_usuario)
        {
            List<Usuario> usuarios = new UsuarioBLL().GetUsuarios();

            Usuario usuarioObj = usuarios.Where(u => u.tipo_usuario == tipo_usuario).FirstOrDefault();

            return usuarioObj;
        }
    }
}
