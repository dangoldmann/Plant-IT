using System;   
using System.Data.OleDb;

namespace COPIA
{
    public class Planta
    {
        private static OleDbConnection conexion = new OleDbConnection(Database.connectionString);
        private static OleDbCommand comando = new OleDbCommand();

        public static string[] nombre = new string[3];
        public static int[,] rango_HumedadRecomendada = new int[3, 2];
        public static int[,] rango_LuzRecomendada = new int[3, 2];
        public static int[] IDFamilia = new int[3];

        public static void Update(string nombre, int humedadMinima, int humedadMaxima, int luzMinima, int luzMaxima, int IDFamilia, int id)
        {
            Database.OpenConnection(conexion, comando);
            comando.CommandText = $"update Planta set Nombre='{nombre}', HumedadMinima='{humedadMinima}', HumedadMaxima='{humedadMaxima}', LuzMinima='{luzMinima}', LuzMaxima='{luzMaxima }', IDFamilia='{IDFamilia}' where Id={id}";
            comando.ExecuteNonQuery();
            conexion.Close();
        } // ACTUALIZA LA TABLA PLANTA

        public static void ActualizarVariables()
        {
            Database.OpenConnection(conexion, comando);
            for (int i = 0; i < 3; i++)
            {
                comando.CommandText = $"select Nombre, HumedadMinima, HumedadMaxima, LuzMinima, LuzMaxima, IDFamilia from Planta where Id={i + 1}";
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    nombre[i] = reader["Nombre"].ToString();
                    rango_HumedadRecomendada[i, 0] = Convert.ToInt32(reader["HumedadMinima"]);
                    rango_HumedadRecomendada[i, 1] = Convert.ToInt32(reader["HumedadMaxima"]);
                    rango_LuzRecomendada[i, 0] = Convert.ToInt32(reader["LuzMinima"]);
                    rango_LuzRecomendada[i, 1] = Convert.ToInt32(reader["LuzMaxima"]);
                    IDFamilia[i] = Convert.ToInt32(reader["IDFamilia"]);
                }
                reader.Close();
            }
            conexion.Close();
        }

        public static void GetRangosFamilia(int idFamilia, int index)
        {
            Database.OpenConnection(conexion, comando);

            string[] camposHumedad = new string[2] { "HumedadMinima", "HumedadMaxima" };
            string[] camposLuz = new string[2] { "LuzMinima", "LuzMaxima" };

            for (int i = 0; i < 2; i++)
            {
                comando.CommandText = $"select [{camposHumedad[i]}] from Familia where Id=" + idFamilia;
                rango_HumedadRecomendada[index, i] = Convert.ToInt32(comando.ExecuteScalar());
                comando.CommandText = $"select [{camposLuz[i]}] from Familia where Id=" + idFamilia;
                rango_LuzRecomendada[index, i] = Convert.ToInt32(comando.ExecuteScalar());
            }
            conexion.Close();
        }  // AGARRA LOS RANGOS DE LA FAMILIA DE PLANTAS Y LOS GUARDA EN VARIABLES
    
    }
}
