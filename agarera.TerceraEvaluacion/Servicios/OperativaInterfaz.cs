using agarera.TerceraEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que escribe las ventas en un fichero
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void mostrarVentasFichero(List<VentasDtos> listantigua);

        /// <summary>
        /// Metodo que pido los pedidos y los muestra
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void crearPedido(List<PedidosDtos> listantigua);

        /// <summary>
        /// Metodo quer suma todas las ventas
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoVentas(List<VentasDtos> listantigua);

        /// <summary>
        /// Metodo que añade ventas
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void añadirVenta(List<VentasDtos> listantigua);


    }
}
