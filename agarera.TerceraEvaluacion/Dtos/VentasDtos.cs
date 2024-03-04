using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Dtos
{
    internal class VentasDtos
    {
        int importeVenta;
        int idVenta;
        DateTime fechaVenta;

         public VentasDtos()
        {
            
        }
        public VentasDtos(int importeVenta, int idVenta, DateTime fechaVenta)
        {
            this.importeVenta = importeVenta;
            this.idVenta = idVenta;
            this.fechaVenta = fechaVenta;
            
        }

        public int ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public DateTime FechaVenta1 { get => fechaVenta; set => fechaVenta = value; }
    }
}
