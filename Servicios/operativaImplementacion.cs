using ejercicioClientesIncripcion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Servicios
{
    internal class operativaImplementacion : operativaInterfaz
    {

        string nombreCliente;
        string apellidosCliente;
        string dniCliente;
        string fchNacimientoCliente;
        string emailCliente;
        int     tlfCliente;
        string fchAltaCliente;  
        string fchBajaCliente;
        public void darAltaCLiente(List<clienteDtos> listaAntigua)
        {
            clienteDtos cliente = crearNuevoCliente();

            listaAntigua.Add(cliente);
        }
        private clienteDtos crearNuevoCliente()
        {
            clienteDtos nuevoCliente = new clienteDtos();

            Console.WriteLine("Introduzca su nombre ");
           nuevoCliente.NombreCliente= Console.ReadLine();

            Console.WriteLine("Introduzca su apellido  ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su dni  ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su fecha de naciemiento");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su email ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su telefono ");
            nuevoCliente.TlfCliente= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su fecha de alta ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            Console.WriteLine("Nuevo cliente registrado  ");
            return nuevoCliente;



        }

    }
}
