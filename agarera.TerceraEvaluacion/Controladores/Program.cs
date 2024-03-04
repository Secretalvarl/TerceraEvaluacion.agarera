using agarera.TerceraEvaluacion.Dtos;
using agarera.TerceraEvaluacion.Servicios;

namespace agarera.TerceraEvaluacion.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplementacion();

            List<VentasDtos> listaVentas = new List<VentasDtos>();
            List<PedidosDtos> listaPedidos = new List<PedidosDtos>();

            bool cerrarMenu = false;
            int opcionSeleccionada;
            
            while (!cerrarMenu)
            {
                opcionSeleccionada = alpha.MenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 1: 
                        bool cerrarEmpleado = false;
                        int opcionEmpleado;
                        while (!cerrarEmpleado)
                        {
                            opcionEmpleado = alpha.MenuEmpleado();

                            switch (opcionEmpleado)
                            {

                                case 1:
                                    Console.WriteLine("Calculo de la venta de un dia");
                                    omega.calculoVentas(listaVentas);
                                    break;
                                case 2:
                                    Console.WriteLine("AñadirVenta");
                                    omega.añadirVenta(listaVentas);
                                    break; 
                                case 3:
                                    Console.WriteLine("Menu principal");
                                    cerrarEmpleado = true;
                                    break; 
                            }
                        }
                        break;
                    case 2:
                        bool cerrarGerencia = false;
                        int opcionGerencia;
                        while (!cerrarGerencia)
                        {
                            opcionGerencia = alpha.MenuGerencia();

                            switch (opcionGerencia)
                            {
                                case 1:
                                    omega.mostrarVentasFichero(listaVentas);
                                    break; 
                                case 2:
                                    omega.crearPedido(listaPedidos);
                                    break;
                                case 3:
                                    Console.WriteLine("Menu principal");
                                    cerrarGerencia = true;
                                    break;
                            }
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Menu Cerrado");
                        cerrarMenu = true; 
                        break;

                        default:
                        break;

                }
            }
        }
    }
}