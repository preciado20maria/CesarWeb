namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            return Mensaje;
        }
    }


}