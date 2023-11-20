using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Dtos
{
    internal class clienteDtos
    {
       
            //ATRIBUTOS (CARACTERISTICAS)

            long idCliente;//PK

            string nombreCliente ="aaaaa";
            string apellidosCliente = "aaaaa";
            string dniCliente = "aaaaa"; //UNIVOCO
            string fchNacimientoCliente = "9999/12/31";
            string emailCliente = "aaaaa";
            int tlfCliente = 111111;
            string fchAltaCliente = "9999/12/31";
            string fchBajaCliente = "9999/12/31";
         
        //GETTER Y SETTERS (metodos de acceso get-lectura; set-escritura;)
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        //CONSTRUCTORES ( metodos que crean objetos -new)
        public clienteDtos(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
           
        }

        public clienteDtos() 
        {
        }

        override
            public string ToString()
        {
            string clienteString = "Nombre:" + this.nombreCliente +
                "Apellido:" + this.apellidosCliente +
                "DNI:" + this.DniCliente +
                "Fecha nacimiento:" + this.FchNacimientoCliente +
                "Email:" + this.emailCliente +
                "Telefono:" + this.tlfCliente +
                "Fecha alta:" + this.fchAltaCliente +
                "Fecha baja:" + this.fchBajaCliente;

            return clienteString;


        }
    }
}
