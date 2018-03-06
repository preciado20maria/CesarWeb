namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedario = ("abcdefghijklmnñopqrstuvwxyz");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            int i;
            int j;
            string nuevo= Mensaje;
            for(i=0; i<Mensaje.Length; i++)
            {
                for(j=0; j<26; j--)
                {
                    if(Mensaje [i] == ABECEDARIO[j])
                    {
                        nuevo = nuevo.Replace(nuevo[i], ABECEDARIO[j-clave%27]);
                    }
                    if(Mensaje[i] == abecedario[j])
                        {
                            nuevo = nuevo.Replace(nuevo[i], abecedario[j-clave%27]);
                        }
                }
            }
        Mensaje = nuevo;
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
         int i;
         int j;
          string nuevo=Mensaje;
	        for(i=0; i < Mensaje.Length ; i++)

                {  
                    for(j = 0; j < 26; j++)
                    {
                        if(Mensaje[i] == ABECEDARIO[j])
                        {
                
                    nuevo = nuevo.Replace(nuevo[i], ABECEDARIO[j+clave%27]);
                            
                        }

                        if(Mensaje[i] == abecedario[j])
                        {
                            nuevo = nuevo.Replace(nuevo[i], abecedario[j+clave%27]);
                        }
                    }


	            }
            Mensaje=nuevo;
            return Mensaje;
        }
    }


}