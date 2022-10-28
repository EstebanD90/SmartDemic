using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessComponents.Contracts;
using DataAccessComponents.Tools;
using Entitites;


namespace DataAccessComponents.Repositories
{
    internal class AlumnoRepository : IGenericRepository<Alumno>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Alumnos] ([ID_ALUMNO],[NOMBRE],[APELLIDO],[NRO_DOCUMENTO],[TIPO_DOCUMENTO],[TELEFONO],[DOMICILIO],[LOCALIDAD],[EMAIL],[FECHA_NACIMIENTO],[FECHA_INGRESO],[ESTADO],[TIMESTAMP])     VALUES(@ID_ALUMNO, @NOMBRE, @APELLIDO, @NRO_DOCUMENTO, @TIPO_DOCUMENTO, @TELEFONO, @DOMICILIO, @LOCALIDAD, @EMAIL, @FECHA_NACIMIENTO, @FECHA_INGRESO, @ESTADO, @TIMESTAMP)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Alumnos] SET ([NOMBRE],[APELLIDO],[NRO_DOCUMENTO],[TIPO_DOCUMENTO],[TELEFONO],[DOMICILIO],[LOCALIDAD],[EMAIL],[FECHA_NACIMIENTO],[FECHA_INGRESO],[ESTADO])     VALUES(@NOMBRE, @APELLIDO, @NRO_DOCUMENTO, @TIPO_DOCUMENTO, @TELEFONO, @DOMICILIO, @LOCALIDAD, @EMAIL, @FECHA_NACIMIENTO, @FECHA_INGRESO, @ESTADO)";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Alumnos] WHERE ID_ALUMNO = @ID_ALUMNO";
        }

        private string SelectOneStatement
        {
            get => "SELECT NOMBRE, APELLIDO, NRO_DOCUMENTO, TIPO_DOCUMENTO, TELEFONO, DOMICILIO, LOCALIDAD, EMAIL, FECHA_NACIMIENTO, FECHA_INGRESO, ESTADO FROM [dbo].[Alumnos] WHERE ID_ALUMNO = @ID_ALUMNO";
        }

        private string SelectAllStatement
        {
            get => "SELECT NOMBRE, APELLIDO, NRO_DOCUMENTO, TIPO_DOCUMENTO, TELEFONO, DOMICILIO, LOCALIDAD, EMAIL, FECHA_NACIMIENTO, FECHA_INGRESO, ESTADO FROM [dbo].[Alumnos]";
        }
        #endregion

        public List<Alumno> Alumnos { get; set; }

        public void Insert(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetAll()
        {
            return Alumnos;
        }

        public Alumno GetOne(Guid id)
        {
            Alumno aux = new Alumno();
            foreach (Alumno alumno in Alumnos)
            {
                if (alumno.id == id)
                {
                    aux = alumno;
                }
            }

            return aux;
        }

        public Alumno GetOneByDNI(int dni)
        {
            Alumno aux = new Alumno();
            foreach (Alumno alumno in Alumnos)
            {
                if (alumno.nro_documento == dni)
                {
                    aux = alumno;
                }
            }

            return aux;
        }

        public void Update(Alumno alumno)
        {
            throw new NotImplementedException();
        }

    }
}
