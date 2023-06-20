using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        public string? Nombre { get; set; }

        public int? IdCategoria { get; set; }
        public string? DescripcionCategoria { get; set; }

        public int? Stock { get; set; }
        //el PRecio lo dejamos en string porque desde la intefaz lo vamos a recibir en texto luego lo cambiamos a decimal
        public string? Precio { get; set; }
        //se cambia EsActivo a entero, (estaba en bool)
        public int? EsActivo { get; set; }
    }
}
