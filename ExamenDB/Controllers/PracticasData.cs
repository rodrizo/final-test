using ExamenDB.Data;
using ExamenDB.Models;
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
    public class PracticasData
    {

        public DataSet getPracticas(int id)
        {
            Conexion cn = new Conexion();
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("sp_practicas", connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@action", "R"));
                        command.Parameters.Add(new SqlParameter("@idAlumno", id));
                        command.Parameters.Add(new SqlParameter("@idPractica", null));
                        command.Parameters.Add(new SqlParameter("@fecha", null));
                        command.Parameters.Add(new SqlParameter("@nota", null));
                        command.Parameters.Add(new SqlParameter("@idProfesor", null));

                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "Practica");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return ds;
            }

        }
        public DataSet getPracticasProfesor(int id)
        {
            Conexion cn = new Conexion();
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("sp_practicas", connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@action", "RP"));
                        command.Parameters.Add(new SqlParameter("@idAlumno", null));
                        command.Parameters.Add(new SqlParameter("@idPractica", null));
                        command.Parameters.Add(new SqlParameter("@fecha", null));
                        command.Parameters.Add(new SqlParameter("@nota", null));
                        command.Parameters.Add(new SqlParameter("@idProfesor", id));

                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "PracticaProfe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return ds;
            }

        }

        public void PracticaCRUD(AlumnoPractica alum, string action)
        {
            Conexion cn = new Conexion();
            using (SqlConnection connection = new SqlConnection(cn.conStrin("dbExamen")))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("sp_practicas", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@action", action));
                        if (action == "C")
                        {
                            command.Parameters.Add(new SqlParameter("@idAlumno", alum.IdAlumno));
                            command.Parameters.Add(new SqlParameter("@idPractica", alum.IdPractica));
                            command.Parameters.Add(new SqlParameter("@fecha", alum.Fecha));
                            command.Parameters.Add(new SqlParameter("@nota", alum.Nota));
                            command.Parameters.Add(new SqlParameter("@idProfesor", null));
                        }
                        command.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}