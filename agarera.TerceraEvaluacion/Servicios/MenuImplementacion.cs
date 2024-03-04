using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MenuEmpleado()
        {
            int opcionEmpleado;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("|1. Cálculo total de ventas diario |");
            Console.WriteLine("|2. Añadir venta                   |");
            Console.WriteLine("|3. Volver al menu principal       |");
            Console.WriteLine("------------------------------------");

            opcionEmpleado = Convert.ToInt32(Console.ReadLine());

            return opcionEmpleado;
        }

        public int MenuGerencia()
        {
            int opcionGerencia;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|1. Escribir en un fichero todas las ventas del día  |");
            Console.WriteLine("|2. Crear un nuevo pedido para proveedores           |");
            Console.WriteLine("|3. Volver al menu principal                         |");
            Console.WriteLine("------------------------------------------------------");

            opcionGerencia = Convert.ToInt32(Console.ReadLine());

            return opcionGerencia;
        }

        public int MenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("--------------------");
            Console.WriteLine("|1. Menu empleado  |");
            Console.WriteLine("|2. Menu gerencia  |");
            Console.WriteLine("|3. Cerrar menu    |");
            Console.WriteLine("--------------------");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }


    }
}
