using ejercicioClientesIncripcion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioClientesIncripcion.Dtos;
namespace ejercicioClientesIncripcion.Servicios;


internal class cuentaImplementacion : cuentaInterfaz
{


    string nombreCuenta;
    string isban;
    string fchAltaCuenta;
    string fchBajaCuenta;
    string codigoswitch;

    //metodo de dar alta cuenta 
    public void darAltaCuenta(List<Dtos.cuentaDtos> listaCuentas)
    {
        cuentaDtos cuenta = crearNuevaCuenta();

        listaCuentas.Add(cuenta);
    }
    //metodo de dar alta cuenta nueva 
    cuentaDtos crearNuevaCuenta()
    {
        cuentaDtos cuentaNueva = new cuentaDtos();

        Console.WriteLine("Introduzca su id ");
        cuentaNueva.IdCuenta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca su nombre ");
        cuentaNueva.Nombrecuenta1 = Console.ReadLine();

        Console.WriteLine("Introduzca su Isban ");
        cuentaNueva.Isban = Console.ReadLine();

        Console.WriteLine("Introduzca su FchAltaCliente ");
        cuentaNueva.FchAltaCuenta = Console.ReadLine();

    

        return cuentaNueva;

       
    }
}