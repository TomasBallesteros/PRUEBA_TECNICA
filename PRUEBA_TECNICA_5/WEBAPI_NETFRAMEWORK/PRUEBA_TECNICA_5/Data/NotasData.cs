using PRUEBA_TECNICA_5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRUEBA_TECNICA_5.Data
{
    public class NotasData
    {
        public static List<Notas> Listar()
        {
            List<Notas> oNotas = new List<Notas>();
            using (SqlConnection oConection = new SqlConnection(Conection.cadenaSQL))
            {
                SqlCommand cmd = new SqlCommand("NO_LISTAR_DIEZ", oConection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
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
                    return oNotas;
                }
            }
        }
    }
}