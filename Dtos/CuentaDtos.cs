using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Dtos
{
    internal class cuentaDtos
    {
        //ATRIBUTOS (CARACTERISTICAS)

        int idCuenta;

        string Nombrecuenta = "aaaaa";
        string isban = "EE123456789";
        string fchAltaCuenta = "9999/12/31";
        string fchBajaCuenta = "9999/12/31";
        string codigoswitch = "CSI1SSXX";
        string dniCliente = "aaaaa";





        //CONSTRUCTORES ( metodos que crean objetos -new)
        public cuentaDtos(long idCuenta, string nombreCuenta, string fchAltaCliente, string fchBajaCuenta, string codigoswitch, string isban, string dniCliente)
        {
            this.idCuenta = (int)idCuenta;
            this.Nombrecuenta = nombreCuenta;
            this.fchAltaCuenta = fchAltaCliente;
            this.fchBajaCuenta = fchBajaCuenta;
            this.isban = isban;
            this.codigoswitch = codigoswitch;
            this.DniCliente = dniCliente;
        }

        public cuentaDtos()
        {
        }



        //GETTER Y SETTERS (metodos de acceso get-lectura; set-escritura;)
        public long IdCuenta { get => idCuenta; set => idCuenta = (int)value; }
        public string Nombrecuenta1 { get => Nombrecuenta; set => Nombrecuenta = value; }
        public string Isban { get => isban; set => isban = value; }
        public string FchAltaCuenta { get => fchAltaCuenta; set => fchAltaCuenta = value; }
        public string FchBajaCuenta { get => fchBajaCuenta; set => fchBajaCuenta = value; }
        public string Codigoswitch { get => codigoswitch; set => codigoswitch = value; }
        public string? FchAltaCliente { get; internal set; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }



        override
           public string ToString()
        {
            string cuentaString =
                "Nombre:" + this.Nombrecuenta +
                "DNI:" + this.DniCliente +
                "Fecha alta:" + this.FchAltaCliente +
                "Fecha baja:" + this.FchBajaCuenta +
                "Switch:" + this.codigoswitch;
            return cuentaString;


        }
    }
}
