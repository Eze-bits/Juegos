using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;



namespace DAL
{
    public class Acceder
    {

        private SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3N00FM4\SQLEXPRESS;Initial Catalog=TP2;Integrated Security=True");

        SqlCommand Command;





        public DataSet Leer(string consulta, List<SqlParameter> parametros)
        {


            DataSet tabla = new DataSet();
            try
            {

                SqlDataAdapter Dta = new SqlDataAdapter(consulta, Conexion);
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand(consulta, Conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (SqlParameter p in parametros)
                    {
                        cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                    }
                }

                Dta.SelectCommand = cmd;
                Conexion.Open();
                Dta.Fill(tabla);

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                Conexion.Close();
            }
            return tabla;
        }


        public void Modificar(string consulta, List<SqlParameter> parametros)
        {

            Conexion.Open();
            Command = new SqlCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = Conexion;
            Command.CommandText = consulta;
            if (parametros != null)
            {

                foreach (SqlParameter P in parametros)
                {
                    Command.Parameters.AddWithValue(P.ParameterName, P.Value);
                }

            }




            SqlTransaction TR;
            TR = Conexion.BeginTransaction();


            //    try
            {
                Command.Transaction = TR;
                Command.ExecuteNonQuery();
                TR.Commit();
            }
            //     catch (SqlException ex)
            {

            }

            //     finally
            { Conexion.Close(); }


        }







    }
}
