using System;
using System.Data.OleDb;

namespace COPIA
{
    public static class Maceta
    {
        private static OleDbConnection conexion = new OleDbConnection(Database.connectionString);
        private static OleDbCommand comando = new OleDbCommand();

        public static int[] humedad = new int[3];
        public static int[] luz = new int[3];
        public static string[] estadoHumedad = new string[3];
        public static string[] estadoLuz = new string[3];
        public static string[] hora = new string[3];

        public static void InsertarRegistro(int humedad, int luz, string estadoHumedad, string estadoLuz, int IDPlanta)
        {
            Database.OpenConnection(conexion, comando);
            comando.CommandText = $"insert into Maceta (Humedad,Luz,EstadoHumedad,EstadoLuz,Fecha,Hora,IDPlanta) values ('{humedad}', '{luz}', '{estadoHumedad}', '{estadoLuz}', '{DateTime.Now.ToShortDateString()}','{DateTime.Now.ToShortTimeString()}', '{IDPlanta}')";
            comando.ExecuteNonQuery();
            conexion.Close();
        } 

        public static void UpdateUltimoRegistro(int humedad, int luz, string estadoHumedad, string estadoLuz, int ID)
        {
            Database.OpenConnection(conexion, comando);
            comando.CommandText = $"update Maceta set Humedad='{humedad}', Luz='{luz}', EstadoHumedad='{estadoHumedad}', EstadoLuz='{estadoLuz}', Fecha='{DateTime.Now.ToShortDateString()}',Hora='{DateTime.Now.ToShortTimeString()}' where Id={ID}";
            comando.ExecuteNonQuery();
            conexion.Close();
        } // ACTUALIZA EL REGISTRO QUE GUARDA LO QUE SE MOSTRARA EN LA APLICACION

        public static void ActualizarVariables()
        {
            Database.OpenConnection(conexion, comando);
            for (int i = 0; i < 3; i++)
            {
                comando.CommandText = $"select Humedad, Luz, EstadoHumedad, EstadoLuz, Hora from Maceta where Id={i + 1}";
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    humedad[i] = Convert.ToInt32(reader["Humedad"]);
                    luz[i] = Convert.ToInt32(reader["Luz"]);
                    estadoHumedad[i] = Convert.ToString(reader["EstadoHumedad"]);
                    estadoLuz[i] = Convert.ToString(reader["EstadoLuz"]);
                    hora[i] = Convert.ToString(reader["Hora"]);
                }
                reader.Close();
            }
            conexion.Close();
        } // LLENA TODAS LAS VARIABLES RELACIONADAS CON LA TABLA MACETA

        public static void ActualizarEstadosActuales(int index, string medicion)
        {
            Database.OpenConnection(conexion, comando);
            string estado = "";
            switch (medicion)
            {
                case "Humedad":
                    if (Planta.rango_HumedadRecomendada[index, 1] != 0 && humedad[index] != 0)
                    {
                        if (humedad[index] < Planta.rango_HumedadRecomendada[index, 0] || humedad[index] > Planta.rango_HumedadRecomendada[index, 1])
                        {
                            if (humedad[index] < Planta.rango_HumedadRecomendada[index, 0])
                                estado = "(Bajo)";
                            else if (humedad[index] > Planta.rango_HumedadRecomendada[index, 1])
                                estado = "(Alto)";
                        }
                        else
                            estado = "(Normal)";
                    }

                    estadoHumedad[index] = estado;
                    comando.CommandText = $"update Maceta set EstadoHumedad='{estadoHumedad[index]}' where Id={index + 1}";
                    comando.ExecuteNonQuery();
                    break;
                case "Luz":
                    if (Planta.rango_LuzRecomendada[index, 1] != 0 && luz[index] != 0)
                    {
                        if (luz[index] < Planta.rango_LuzRecomendada[index, 0] || luz[index] > Planta.rango_LuzRecomendada[index, 1])
                        {
                            if (luz[index] < Planta.rango_LuzRecomendada[index, 0])
                                estado = "(Bajo)";
                            else if (luz[index] > Planta.rango_LuzRecomendada[index, 1])
                                estado = "(Alto)";
                        }
                        else
                            estado = "(Normal)";
                    }

                    estadoLuz[index] = estado;
                    comando.CommandText = $"update Maceta set EstadoLuz='{estadoLuz[index]}' where Id={index + 1}";
                    comando.ExecuteNonQuery();
                    break;
            }
            conexion.Close();
        }
    }
}
