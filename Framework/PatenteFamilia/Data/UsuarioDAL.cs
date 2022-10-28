using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;
using System.Data;
using System.Data.SqlClient;
using DataAccessComponents.Tools;

namespace Framework.PatenteFamilia.Data
{
    public class UsuarioDAL
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Arq_Usuarios] (ID_USUARIO, NOMBRE, APELLIDO, USUARIO, PASSWORD, TIPO_USUARIO, EMAIL, FECHA_CREACION, ULTIMO_INGRESO) VALUES (@ID_USUARIO, @NOMBRE, @APELLIDO, @USUARIO, @PASSWORD, @TIPO_USUARIO, @EMAIL, @FECHA_CREACION, NULL)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Arq_Usuarios] SET (NOMBRE= @NOMBRE, APELLIDO=@APELLIDO, USUARIO=@USUARIO, PASSWORD=@PASSWORD, EMAIL=@EMAIL, TIPO_USUARIO=@TIPO_USUARIO) WHERE ID_USUARIO = @ID_USUARIO";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Arq_Usuarios] WHERE ID_USUARIO = @ID_USUARIO";
        }

        private string SelectOneByIDStatement
        {
            get => "SELECT ID_USUARIO, NOMBRE, APELLIDO, USUARIO, PASSWORD, TIPO_USUARIO, EMAIL FROM [dbo].[Arq_Usuarios] WHERE ID_USUARIO = @ID_USUARIO";
        }

        private string SelectOneByUserStatement
        {
            get => "SELECT NOMBRE, APELLIDO, USUARIO, TIPO_USUARIO, EMAIL FROM [dbo].[Arq_Usuarios] WHERE USUARIO = @USUARIO";
        }

        private string SelectOneByApellidoStatement
        {
            get => "SELECT NOMBRE, APELLIDO, USUARIO, TIPO_USUARIO, EMAIL FROM [dbo].[Arq_Usuarios] WHERE APELLIDO = @APELLIDO";
        }

        private string SelectOneByNombreStatement
        {
            get => "SELECT NOMBRE, APELLIDO, USUARIO, TIPO_USUARIO, EMAIL FROM [dbo].[Arq_Usuarios] WHERE NOMBRE = @NOMBRE";
        }

        private string SelectOneByTipoUserStatement
        {
            get => "SELECT NOMBRE, APELLIDO, USUARIO, TIPO_USUARIO, EMAIL FROM [dbo].[Arq_Usuarios] WHERE TIPO_USUARIO = @TIPO_USUARIO";
        }

        private string SelectAllUsersStatement
        {
            get => "SELECT ID_USUARIO,NOMBRE,APELLIDO,USUARIO,PASSWORD,TIPO_USUARIO,EMAIL,FECHA_CREACION FROM [dbo].[Arq_Usuarios]";
        }

        private string SelectAllStatement
        {
            get => "SELECT ID_USUARIO,NOMBRE,APELLIDO,USUARIO,PASSWORD,TIPO_USUARIO,EMAIL,FECHA_CREACION  FROM [dbo].[Arq_Usuarios]";
        }
        #endregion

        public void Insert(Usuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(SqlHelper.conString))
                {
                    //SqlCommand comando = new SqlCommand();

                    conexion.Open();
                    //comando.Connection = conexion;
                    //comando.CommandText = "INSERT INTO [dbo].[Arq_Usuarios] (ID_USUARIO,NOMBRE,APELLIDO,USUARIO,PASSWORD,TIPO_USUARIO,EMAIL,FECHA_CREACION,ULTIMO_INGRESO) VALUES ( '" + usuario.id + "','" + usuario.nombre + "','" + usuario.apellido + "','" + usuario.nombre + "." + usuario.apellido + "','" + usuario.password + "','" + usuario.tipo_usuario + "','" + usuario.email + "','" + usuario.fecha_creacion + "'," + "NULL" + ")";
                    //comando.CommandType = System.Data.CommandType.Text;

                    //comando.ExecuteNonQuery();
                    SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                                new SqlParameter("@ID_USUARIO", usuario.id),
                                new SqlParameter("@NOMBRE", usuario.nombre),
                                new SqlParameter("@APELLIDO", usuario.apellido),
                                new SqlParameter("@USUARIO", usuario.usuario),
                                new SqlParameter("@PASSWORD",usuario.password),
                                new SqlParameter("@TIPO_USUARIO",usuario.tipo_usuario),
                                new SqlParameter("@EMAIL",usuario.email),
                                new SqlParameter("@FECHA_CREACION",usuario.fecha_creacion),
                                //new SqlParameter("@ULTIMO_INGRESO", usuario.ultimo_ingreso)

                    }); ;

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //throw new NotImplementedException();

        }

        //public static bool Exists(Usuario usuario)
        //{

        //}

        public static void Delete(Usuario usuario)
        {

        }

        public Usuario GetUserByID(Guid id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByIDStatement, System.Data.CommandType.Text,
                                      new SqlParameter[] { new SqlParameter("@ID_USUARIO", id) }))
                {
                    Object[] values = new Object[dr.FieldCount];

                    Usuario usuario = null;

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //usuario = UsuarioDAL.ObtenerOcrearUsuario();
                    }

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new DALException(ex));
                //return null;
                throw ex;
            }

        }

        public Usuario GetUserByUser(string user)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByUserStatement, System.Data.CommandType.Text,
                                      new SqlParameter[] { new SqlParameter("@USUARIO", user) }))
                {
                    Object[] values = new Object[dr.FieldCount];

                    Usuario usuario = null;

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //usuario = UsuarioDAL.ObtenerOcrearUsuario();
                    }

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new DALException(ex));
                //return null;
                throw ex;
            }

        }

        public Usuario GetUserByApellido(string apellido)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByApellidoStatement, System.Data.CommandType.Text,
                                      new SqlParameter[] { new SqlParameter("@APELLIDO", apellido) }))
                {
                    Object[] values = new Object[dr.FieldCount];

                    Usuario usuario = null;

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //usuario = UsuarioDAL.ObtenerOcrearUsuario();
                    }

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new DALException(ex));
                //return null;
                throw ex;
            }

        }

        public Usuario GetUserByNombre(string nombre)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByNombreStatement, System.Data.CommandType.Text,
                                      new SqlParameter[] { new SqlParameter("@NOMBRE", nombre) }))
                {
                    Object[] values = new Object[dr.FieldCount];

                    Usuario usuario = null;

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //usuario = UsuarioDAL.ObtenerOcrearUsuario();
                    }

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new DALException(ex));
                //return null;
                throw ex;
            }

        }

        public Usuario GetUserByTipoUser(string tipo_usuario)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByTipoUserStatement, System.Data.CommandType.Text,
                                      new SqlParameter[] { new SqlParameter("@TIPO_USUARIO", tipo_usuario) }))
                {
                    Object[] values = new Object[dr.FieldCount];

                    Usuario usuario = null;

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                    }

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                //Services.Exceptions.Service.Handle(new DALException(ex));
                //return null;
                throw ex;
            }

        }

        public List<Usuario> GetAllUsers()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                using (var dr = SqlHelper.ExecuteReader(SelectAllUsersStatement, System.Data.CommandType.Text))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);

                        Usuario usuario = new Usuario();
                        usuario.id = Guid.Parse(values[0].ToString().ToUpper());
                        usuario.nombre = values[1].ToString();
                        usuario.apellido = values[2].ToString();
                        usuario.usuario = values[3].ToString();
                        usuario.password = values[4].ToString();
                        usuario.tipo_usuario = values[5].ToString();
                        usuario.email = values[6].ToString();
                        usuario.fecha_creacion = Convert.ToDateTime(values[7]);

                        usuarios.Add(usuario);
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);

                        Usuario usuario = new Usuario();
                        usuario.nombre = values[1].ToString();
                        usuario.apellido = values[2].ToString();
                        usuario.usuario = values[3].ToString();
                        usuario.password = values[4].ToString();
                        usuario.tipo_usuario = values[5].ToString();
                        usuario.email = values[6].ToString();
                        usuario.fecha_creacion = Convert.ToDateTime(values[7]);

                        usuarios.Add(usuario);
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                //return null;
                throw ex;
            }
            

            /*
            using (SqlConnection conexion = new SqlConnection(SqlHelper.conString))
            {
                conexion.Open();

                try
                {
                    string query = "SELECT ID_USUARIO,NOMBRE,APELLIDO,USUARIO,PASSWORD,TIPO_USUARIO,EMAIL,FECHA_CREACION,ULTIMO_INGRESO  FROM [TC1_GestionAcademica].[dbo].[Arq_Usuarios]";
                   
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuarios.Add(new Usuario()
                            {
                                id = Guid.Parse((string)dr["ID_USUARIO"]),
                                nombre = dr["NOMBRE"].ToString(),
                                apellido = dr["APELLIDO"].ToString(),
                                usuario = dr["USUARIO"].ToString(),
                                password = dr["PASSWORD"].ToString(),
                                tipo_usuario = dr["TIPO_USUARIO"].ToString(),
                                email = dr["EMAIL"].ToString(),
                                //estado = dr["[ESTADO]"],
                                fecha_creacion = Convert.ToDateTime(dr["FECHA_CREACION"]),
                                ultimo_ingreso = Convert.ToDateTime(dr["ULTIMO_INGRESO"])
                            }) ;
                        }
                    }

                }
                catch(Exception ex)
                {
                    //usuarios = new List<Usuario>();
                    List<Usuario> usuarios1 = usuarios;
                }
            }*/

            //return usuarios;
            
        }

        public static void Update(Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlHelper.conString))
                {
                    SqlCommand comando = new SqlCommand();

                    conn.Open();

                    comando.Connection = conn;
                    comando.CommandText = "UPDATE [TC1_GestionAcademica].[dbo].[Arq_Usuarios] SET ";
                    comando.CommandText += " NOMBRE = '" + usuario.nombre + "',";
                    comando.CommandText += " APELLIDO = '" + usuario.apellido + "',";
                    comando.CommandText += " USUARIO = '" + usuario.usuario + "',";
                    comando.CommandText += " EMAIL = '" + usuario.email + "',";
                    comando.CommandText += " TIPO_USUARIO = '" + usuario.tipo_usuario + "',";
                    comando.CommandText += " ULTIMO_INGRESO = '" + usuario.ultimo_ingreso + "'";
                    comando.CommandText += " where ID_USUARIO = '" + usuario.id + "'";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.ExecuteNonQuery();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static Usuario ObtenerOcrearUsuario(Usuario usuario)
        //{
        //    Usuario userObj = GetUserByID(usuario);

        //    if (userObj == null)
        //    {
        //        userObj = Insert()
        //    }

        //    return oCl;
        //}
    }
}
