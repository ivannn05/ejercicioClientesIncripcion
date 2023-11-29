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

        public void borrarCliente(List<clienteDtos> listaClientes)
        {
            menuInterfaz mi = new menuImplentacion();
            string dniBuscar = mi.pedirDni();
            //Objeto especifico:Se elimina por refencia de valores , no por valores 
            clienteDtos clienteABorrar = new clienteDtos();
            foreach(clienteDtos cliente in listaClientes)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    break; 
                }
            }listaClientes.Remove(clienteABorrar);

            //Posicion 
            /*
            int i;
            bool aBorrar = false;
            for ( i = 0; i<listaClientes.Count(); i++)
            {
                if (listaClientes[i].DniCliente.Equals(dniBuscar))
                {
                    aBorrar = true;
                    break;

                }

            }
            if (aBorrar)
            {
                listaClientes.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("El cliente no existe");
            }*/
        }

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

        public void modificarCliente(List<clienteDtos> listaClientes)
        {
            menuInterfaz mi = new menuImplentacion();
            string dniBuscar = mi.pedirDni();
            
            clienteDtos clienteAModificar= new clienteDtos();
            foreach (clienteDtos cliente in listaClientes)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteAModificar = cliente;

                    break;
                }
            }



        }

      

    }
}
