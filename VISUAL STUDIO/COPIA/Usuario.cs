using System;
using System.Data.OleDb;

namespace COPIA
{
    public class Usuario
    {
        private static OleDbConnection conexion = new OleDbConnection(Database.connectionString);
        private static OleDbCommand comando = new OleDbCommand();

        public static string Telefono { get; set; }
        public static bool Notificaciones { get; set; }
        
        public static void UpdateUsuario(string telefono, bool notificaciones)
        {
            Database.OpenConnection(conexion, comando);
            comando.CommandText = $"update Usuario set Telefono='{telefono}', Notificaciones={notificaciones}";
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static void ActualizarVariables()
        {
            Database.OpenConnection(conexion, comando);

            comando.CommandText = "select [Telefono] from Usuario";
            Telefono = comando.ExecuteScalar().ToString();

            comando.CommandText = "select [Notificaciones] from Usuario";
            Notificaciones = Convert.ToBoolean(comando.ExecuteScalar());

            conexion.Close();
        }

    }
}
