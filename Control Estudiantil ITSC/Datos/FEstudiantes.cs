
using SisEstudiantes.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Estudiantil_ITSC.Clases;

namespace Control_Estudiantil_ITSC.Datos
{
    class FEstudiantes
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEstudiantes_GetAll", dbParams);

        }

        public static int Insertar(Estudiantes estudiante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                    FDBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,estudiante.Nombre),
                    FDBHelper.MakeParam("@Apellido",SqlDbType.VarChar,0,estudiante.Apellido),
                    FDBHelper.MakeParam("@Matricula",SqlDbType.VarChar,0,estudiante.Matricula),
                    FDBHelper.MakeParam("@Carrera",SqlDbType.VarChar,0,estudiante.Carrera),
                    FDBHelper.MakeParam("@Materia",SqlDbType.VarChar,0,estudiante.Materia),
                    FDBHelper.MakeParam("@Profesor",SqlDbType.VarChar,0,estudiante.Profesor)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstudiantes_Insertar", dbParams));

        }

        public static int Actualizar(Estudiantes estudiante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id",SqlDbType.Int,0,estudiante.Id),

                    FDBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,estudiante.Nombre),
                    FDBHelper.MakeParam("@Apellido",SqlDbType.VarChar,0,estudiante.Apellido),
                    FDBHelper.MakeParam("@Matricula",SqlDbType.VarChar,0,estudiante.Matricula),
                    FDBHelper.MakeParam("@Carrera",SqlDbType.VarChar,0,estudiante.Carrera),
                    FDBHelper.MakeParam("@Materia",SqlDbType.VarChar,0,estudiante.Materia),
                    FDBHelper.MakeParam("@Profesor",SqlDbType.VarChar,0,estudiante.Profesor)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstudiantes_Actualizar", dbParams));

        }

        public static int Eliminar(Estudiantes estudiante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id",SqlDbType.Int,0,estudiante.Id),



                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstudiantes_Eliminar", dbParams));

        }

    }
}
