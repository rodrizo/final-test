using ExamenDB.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDB.Controllers
{
    public class ComboData
    {

        private Conexion cn = new Conexion();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;


        #region "Retornando tabla con data de estudiantes"
        public DataTable getEstudiantes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Alumno";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }
        #endregion

        #region "Retornando tabla con data de prácticas"
        public DataTable getPracticas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Practica";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }
        #endregion

        #region "Retornando tabla con data de profesores"
        public DataTable getProfesores()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Profesor";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
        }
        #endregion

    }
}
