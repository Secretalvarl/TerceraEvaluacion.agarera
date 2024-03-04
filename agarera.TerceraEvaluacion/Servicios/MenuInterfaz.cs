using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.TerceraEvaluacion.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo para gestionar el MenuYSeleccion
        /// agb - 04/03/2024
        /// </summary>
        public int MenuYSeleccion();
        /// <summary>
        /// Metodo para gestionar el MenuEmpleado
        /// agb - 04/03/2024
        /// </summary>
        public int MenuEmpleado();
        /// <summary>
        /// Metodo para gestionar el MenuGerencia
        /// agb - 04/03/2024
        /// </summary>
        public int MenuGerencia();


    }
}
