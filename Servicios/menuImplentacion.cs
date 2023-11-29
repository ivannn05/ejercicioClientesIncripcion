using ejercicioClientesIncripcion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Servicios
{
    internal class menuImplentacion : menuInterfaz
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Darse de alta del cliente ");
            Console.WriteLine("2.Darse de alta en la cuenta bancaria");
            Console.WriteLine("3.Modificar los datos de un cliente ");
            Console.WriteLine("4.Eliminar un cliente ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string pedirDni()
        {
            Console.WriteLine("Indique el DNI del cliente ");
            string cliente = Console.ReadLine();
            return cliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccionCliente()
        {
            int opcionIntroducida;
            Console.WriteLine("##############################");
            Console.WriteLine("0.Modificar nombre ");
            Console.WriteLine("1.Modificar apellidos ");
            Console.WriteLine("2.Modificar dni");
            Console.WriteLine("3.Modificar fchNacimiento");
            Console.WriteLine("4.Modificar email");
            Console.WriteLine("5.Modificar tlf");
            Console.WriteLine("6.Modificar fchBaja");
            Console.WriteLine("##############################");
            Console.WriteLine("Seleccione una opcion");

            opcionIntroducida =Convert.ToInt32(Console.ReadLine());
            return opcionIntroducida;
        }
    }
}
