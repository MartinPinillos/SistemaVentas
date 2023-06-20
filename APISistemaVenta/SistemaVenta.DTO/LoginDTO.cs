using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class LoginDTO
    {
        //esta clase me va a permitir recibir las credenciales
        public string Correo { get; set; }
        public string Clave { get; set; }

    }
}
