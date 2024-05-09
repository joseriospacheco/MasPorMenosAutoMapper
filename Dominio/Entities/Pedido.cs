using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Pedido: EntidadBase
    {
        
        public string Descripcion { get; set; }
        public string DireccionRecogida { get; set; }
        public string DireccionEntrega { get; set; }
        public string Estado { get; set; }
    }
}
