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
            Console.WriteLine("1.Darse de alta del cliente ");
            Console.WriteLine("2.Darse de alta en la cuenta bancaria");
            Console.WriteLine("3.");
            Console.WriteLine("4.Eliminar un cliente ");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;
        }

        public string pedirDni()
        {
            Console.WriteLine("Indique el DNI del cliente ");
            string cliente = Console.ReadLine();
            return cliente;
        }
    }
}
