using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Session5.Data
{
    public class Api
    {
        private string url = "https://api.adamix.net/apec/cedula/";

        public Usuario Consulta(string cedula)
        {
            Usuario usr = new Usuario();
            url += cedula;

            try
            {
                var str = new WebClient().DownloadString(url);
                dynamic d = JsonConvert.DeserializeObject(str);

                usr.Cedula = cedula;
                usr.Nombre = d.Nombres;
                usr.Apellido = d.Apellido1 + " " + d.Apellido2;
                usr.Foto = d.foto;

                if (usr.Nombre == null)
                {
                    usr.Nombre = "No encontrado";
                    usr.Apellido = "No encontrado";
                }
            }
            catch (Exception)
            {

                throw;
            }

            return usr;
        }
    }
}
