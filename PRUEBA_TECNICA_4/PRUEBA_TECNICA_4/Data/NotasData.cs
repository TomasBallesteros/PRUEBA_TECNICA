using PRUEBA_TECNICA_4.Models;
using System.Data.SqlClient;
using System.Data;

namespace PRUEBA_TECNICA_4.Data
{
    public class NotasData
    {
        public List<Notas> Listar()
        {
            List<Notas> oNotas = new List<Notas>();

            Conection conection = new Conection();

            using (var conect = new SqlConnection(conection.getCadenaSQL()))
            {
                try
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("NO_LISTAR", conect);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oNotas.Add(new Notas()
                            {
                                NoId = Convert.ToInt32(reader["NO_ID"]),
                                NoFecha = Convert.ToDateTime(reader["NO_FECHA"].ToString()),
                                NoNota = Convert.ToDecimal(reader["NO_NOTA"].ToString()),
                                NoEstudiante = reader["NO_ESTUDIANTE"].ToString(),
                                NoMateria = reader["NO_MATERIA"].ToString(),
                                NoPeriodo = reader["NO_PERIODO"].ToString()
                            });
                        }
                    }
                    return oNotas;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    return oNotas;
                }
            }
        }

        public Notas Obtener(int IdNota)
        {
            Notas oNotas = new Notas();

            Conection conection = new Conection();

            using (var conect = new SqlConnection(conection.getCadenaSQL()))
            {
                try
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("NO_OBTENER", conect);
                    cmd.Parameters.AddWithValue("NO_ID", IdNota);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oNotas.NoId = Convert.ToInt32(reader["NO_ID"]);
                            oNotas.NoFecha = Convert.ToDateTime(reader["NO_FECHA"].ToString());
                            oNotas.NoNota = Convert.ToDecimal(reader["NO_NOTA"].ToString());
                            oNotas.NoEstudiante = reader["NO_ESTUDIANTE"].ToString();
                            oNotas.NoMateria = reader["NO_MATERIA"].ToString();
                            oNotas.NoPeriodo = reader["NO_PERIODO"].ToString();
                        }
                    }
                    return oNotas;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    return oNotas;
                }
            }
        }

        public bool Guardar(Notas oNotas)
        {
            try
            {
                Conection conection = new Conection();

                using (var conect = new SqlConnection(conection.getCadenaSQL()))
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("NO_GUARDAR", conect);
                    cmd.Parameters.AddWithValue("NO_FECHA", oNotas.NoFecha);
                    cmd.Parameters.AddWithValue("NO_NOTA", oNotas.NoNota);
                    cmd.Parameters.AddWithValue("NO_ESTUDIANTE", oNotas.NoEstudiante);
                    cmd.Parameters.AddWithValue("NO_MATERIA", oNotas.NoMateria);
                    cmd.Parameters.AddWithValue("NO_PERIODO", oNotas.NoPeriodo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        public bool Editar(Notas oNotas)
        {
            try
            {
                Conection conection = new Conection();

                using (var conect = new SqlConnection(conection.getCadenaSQL()))
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("NO_EDITAR", conect);
                    cmd.Parameters.AddWithValue("NO_ID", oNotas.NoId);
                    cmd.Parameters.AddWithValue("NO_FECHA", oNotas.NoFecha);
                    cmd.Parameters.AddWithValue("NO_NOTA", oNotas.NoNota);
                    cmd.Parameters.AddWithValue("NO_ESTUDIANTE", oNotas.NoEstudiante);
                    cmd.Parameters.AddWithValue("NO_MATERIA", oNotas.NoMateria);
                    cmd.Parameters.AddWithValue("NO_PERIODO", oNotas.NoPeriodo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        public bool Eliminar(int IdNota)
        {
            try
            {
                Conection conection = new Conection();

                using (var conect = new SqlConnection(conection.getCadenaSQL()))
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("NO_ELIMINAR", conect);
                    cmd.Parameters.AddWithValue("NO_ID", IdNota);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }
    }
}
