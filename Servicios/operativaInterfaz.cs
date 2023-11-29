using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClientesIncripcion.Servicios
{
    internal interface operativaInterfaz
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="listaClientes"></param>
        public void darAltaCLiente(List<Dtos.clienteDtos> listaClientes)
        {

          
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="listaClientes"></param>
        public void borrarCliente(List<Dtos.clienteDtos> listaClientes);

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="listaClientes"></param>
        public void modificarCliente(List<Dtos.clienteDtos> listaClientes);
    }
}
