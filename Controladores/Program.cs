﻿using ejercicioClientesIncripcion;
using ejercicioClientesIncripcion.Dtos;
using ejercicioClientesIncripcion.Servicios;
using System.Data;

namespace ejercicioClientesIncripcion.Controladores
{
    //Metodo principal desde donde se lanza el preograma 
    class Program
    {
      
        public static void Main(string[] args)
        {
            List<clienteDtos> listaClientes = new List<clienteDtos>();
            List<cuentaDtos>listaCuentas = new List<cuentaDtos>();
            menuInterfaz mi = new menuImplentacion();
            operativaInterfaz op = new operativaImplementacion();
            cuentaInterfaz cu = new cuentaImplementacion();
            bool cerrarMenu = false;

            int opcionseleccionada;

            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionseleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionseleccionada);
                switch (opcionseleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] -Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] -Se ejecuta la inscripcion del usuario");
                        op.darAltaCLiente(listaClientes) ;
                        /*foreach (clienteDtos cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }*/
                        break;
                    case 2:
                        Console.WriteLine("[INFO] -Se ejecuta la inscripcion de la cuenta");
                        cu.darAltaCuenta(listaCuentas);
                        //El Tostring es algo de prueba , para comprobar q la lista vaya bien 
                        //Examen es obligatorio
                       /* foreach (cuentaDtos cuenta in cuentaDtos) 
                        {
                            Console.WriteLine(cuenta.ToString());
                        }*/
                        break;
                    case 3:
                        Console.WriteLine("[INFO] -Se modificaran los datos ");
                        op.modificarCliente(listaClientes);
                       
                        break;
                    case 4:
                        Console.WriteLine("[INFO] -Eliminar un cliente ");
                        op.borrarCliente(listaClientes) ;
                        break;
                    case 5:
                        Console.WriteLine("[INFO] -Se ejecuta caso 5 ");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion selecionada no coincide con ninguna ");
                        break;
                }

                

            }
        }

    }
}

//Partiendo de esta esturctura crear la funcionalidad de crear y dar de alta una cuanta
//bancaria dentro de ella tiene q haber un campo que identifique a q cliente
//pertenece esa cuenta bancaria
//campos:

//id cuenta bancaria,hisband cuenta bancaria ,
//el codigo switch de la cuenta a la q pertenece, campo de identificacion
//,fecha alta y fecha baja 