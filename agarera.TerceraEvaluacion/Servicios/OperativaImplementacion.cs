using agarera.TerceraEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        private IFormatProvider? provider;

        /// <summary>
        /// Metodo que añade ventas
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void añadirVenta(List<VentasDtos> listantigua)
        {
            VentasDtos venta = new VentasDtos();

            int idVenta = 1;
            Console.WriteLine("Cual es el importe: ");
            int importe = Convert.ToInt32(Console.ReadLine());

            DateTime fechaVenta = DateTime.Now;

            venta.ImporteVenta = importe;
            venta.FechaVenta1 = fechaVenta;
            venta.IdVenta = idVenta;
           
            listantigua.Add(venta);
            idVenta++;
        }

        /// <summary>
        /// Metodo quer suma todas las ventas
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoVentas(List<VentasDtos> listantigua)
        {
            int importe = 0;

            Console.WriteLine("Cual es la fecha para calcular las ventas el formato debbe de ser dd-MM-yyyy): ");
            string fechaDada = Console.ReadLine();
            string formato = "dd-MM-yyyy";

            DateTime FechaBien = DateTime.ParseExact(fechaDada, formato, provider);

            foreach (VentasDtos ventas in listantigua)
            {
                if (FechaBien.Equals(ventas.FechaVenta1))
                {
                    importe = importe + ventas.ImporteVenta;
                }

                Console.WriteLine("Total ventas: " + importe + "euros");
                Console.WriteLine("Tiempo transcurrido: " + ventas.FechaVenta1);
            }
        }

        /// <summary>
        /// Metodo que escribe las ventas en un fichero
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void mostrarVentasFichero(List<VentasDtos> listantigua)
        {
            Console.WriteLine("Escriba una fecha con este formato dd-MM-yyyy: ");
            string fecha = Console.ReadLine();
            string formatoFecha = "dd-MM-yyyy";

            DateTime fecha2 = DateTime.ParseExact(fecha, formatoFecha, provider);

            StreamWriter sw = new StreamWriter($"{fecha2.Day}{fecha2.Month}{fecha2.Year}.txt");

            int control = 1;

            foreach (VentasDtos ventas in listantigua)
            {
                if (fecha2.Equals(ventas.FechaVenta1))
                {
                    sw.WriteLine(".....");
                    sw.WriteLine("Venta número: " + control);
                    sw.WriteLine("Euros: " + ventas.ImporteVenta + " euros");
                    sw.WriteLine("Instante de compra: " + ventas.FechaVenta1);
                    sw.WriteLine(".....");
                    control++;

                }
            }
        }
        /// <summary>
        /// Metodo que pido los pedidos y los muestra
        /// agb - 04/03/20024
        /// </summary>
        /// <param name="listantigua"></param>
        public void crearPedido(List<PedidosDtos> listantigua)
        {
            do
            {
                PedidosDtos pedido = new PedidosDtos();

                Console.WriteLine("Nombre del producto: ");
                string nombreProducto = Console.ReadLine();

                Console.WriteLine("Cantidad del producto: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fecha de entrega formato dd-MM-yyyy: ");
                int fechaEntrega = Convert.ToInt32(Console.ReadLine());

                pedido.NombreProducto = nombreProducto;
                pedido.CantidadProducto = cantidad;
                pedido.FechaProducto = fechaEntrega;

                listantigua.Add(pedido);

                Console.WriteLine("Si quiere continuar pulse (c), sino pulse cualquier otra letra");

            } while (Console.ReadLine().Equals("c"));

            foreach (PedidosDtos pedidos in listantigua)
            {
                Console.WriteLine("Producto: " + pedidos.NombreProducto);
                Console.WriteLine("Cantidad: " + pedidos.CantidadProducto + " unidades");
                Console.WriteLine("Fecha entrega: " + pedidos.FechaProducto);
          
            }
        }
    }
}