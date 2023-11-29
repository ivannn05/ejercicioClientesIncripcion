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

                    

                    int opcionseleccionada;
                    opcionseleccionada = mi.mostrarMenuYSeleccionCliente();
                    Console.WriteLine(opcionseleccionada);
                    switch (opcionseleccionada)
                    {
                        case 0:
                            Console.WriteLine("[INFO] -Introduzca el nuevo nombre ");
                            cliente.NombreCliente = Console.ReadLine();
                            break;
                        case 1:
                            Console.WriteLine("[INFO] -Introduzca el nuevo apellidos");
                           cliente.ApellidosCliente = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("[INFO] -Introduzca el nuevo dni");
                            cliente.DniCliente = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("[INFO] -Introduzca la nueva  fchNacimiento");
                            cliente.FchNacimientoCliente = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("[INFO] -Introduzca el nuevo  email");
                            cliente.EmailCliente = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("[INFO] -Introduzca el nuevo  telefono");
                            cliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("[INFO] -Introduzca la nueva fchBaja");
                            cliente.FchBajaCliente = Console.ReadLine();
                            break;
                        
                        default:
                            Console.WriteLine("[INFO] - La opcion selecionada no coincide con ninguna ");
                            break;
                    }

                    break;
                }
            }
            


        }

      

    }
}
