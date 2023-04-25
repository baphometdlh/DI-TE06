using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosVO
{
    public class CustomerVO
    {

        #region Atributos
        private string iDCliente;
        private string nombreEmpresa;
        private string nombreContacto;
        private string tituloContacto;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigoPostal;
        private string pais;
        private string telefono;
        private string fax;
        #endregion

        #region Costructor
        public CustomerVO() { }
        #endregion

        #region Propiedades
        public string IDCliente { get => iDCliente; set => iDCliente = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string TituloContacto { get => tituloContacto; set => tituloContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
        #endregion
    }
}
