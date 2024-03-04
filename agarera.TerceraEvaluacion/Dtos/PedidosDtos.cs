using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Dtos
{
    internal class PedidosDtos
    {
        string nombreProducto;
        int cantidadProducto;
        int fechaProducto;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int FechaProducto { get => fechaProducto; set => fechaProducto = value; }

        public PedidosDtos() { }
        
        public PedidosDtos(string nombreProducto, int cantidadProducto, int fechaProducto)
        {
            this.fechaProducto = fechaProducto;
            this.cantidadProducto=cantidadProducto;
            this.nombreProducto=nombreProducto;
        }
    }
}
