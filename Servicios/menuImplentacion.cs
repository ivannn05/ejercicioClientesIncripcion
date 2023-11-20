using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Servicios
{
    internal class menuImplentacion : menuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("##############################");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Darse de alta");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;
        }
    }
}
