using ejercicioClientesIncripcion;
using ejercicioClientesIncripcion.Dtos;
using ejercicioClientesIncripcion.Servicios;
using System.Data;

namespace ejercicioClientesIncripcion.Controladores
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            List<clienteDtos> listaClientes = new List<clienteDtos>();

            menuInterfaz mi = new menuImplentacion();
            operativaInterfaz op = new operativaImplementacion();
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
                        break;
                    case 2:
                        Console.WriteLine("[INFO] -Se ejecuta caso 2 ");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] -Se ejecuta caso 3 ");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] -Se ejecuta caso 4 ");
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