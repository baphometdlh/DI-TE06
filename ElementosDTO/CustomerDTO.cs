using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBLL;
using ElementosVO;
using System.Collections.ObjectModel;

namespace ElementosDTO
{
    public class CustomerDTO
    {

        #region Atributos
        private GestionBLL unaGestion;
        private List<string> paises;
        private List<string> clientes;
        private ObservableCollection<string> ciudades;
        private ObservableCollection<CustomerVO> clientesBoton;
        private ObservableCollection<EmpleadosDTO> empleadosBoton;
        private string pais;
        private string ciudad;

        #endregion

        #region Constructor
        public CustomerDTO() { }

        #endregion

        #region Propiedades
        public GestionBLL UnaGestion { get => unaGestion; set => unaGestion = value; }
        public List<string> Paises { get => paises; set => paises = value; }
        public ObservableCollection<string> Ciudades { get => ciudades; set => ciudades = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public ObservableCollection<CustomerVO> ClientesBoton { get => clientesBoton; set => clientesBoton = value; }
        internal ObservableCollection<EmpleadosDTO> EmpleadosBoton { get => empleadosBoton; set => empleadosBoton = value; }
        public List<string> Clientes { get => clientes; set => clientes = value; }
        #endregion

        #region Métodos

        #region Todos los paises de la base de datos
        public List<string> GestionPaises()
        {
            paises = new List<string>();
            List<CustomerVO> unaLista = new List<CustomerVO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.PaisesBLL();
            paises.Add("TODOS LOS PAISES");
            foreach (var pais in unaLista)
            {
                paises.Add(pais.Pais.ToString());
            }
            return paises;
        }
        #endregion

        #region Todas las ciudades de la base de datos
        public ObservableCollection<string> GestionCiudades()
        {
            ciudades = new ObservableCollection<string>();
            List<CustomerVO> unaLista = new List<CustomerVO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.CiudadesBLL();
            ciudades.Add("TODAS LAS CIUDADES");
            foreach (var ciudad in unaLista)
            {
                ciudades.Add(ciudad.Ciudad.ToString());
            }
            return ciudades;
        }
        #endregion

        #region Todos los clientes de la base de datos
        public List<string> GestionClientes()
        {
            Clientes= new List<string>();
            List<CustomerVO> unaLista = new List<CustomerVO>();
            unaGestion= new GestionBLL();
            unaLista = unaGestion.ClienteBLL();
            Clientes.Add("TODOS LOS CLIENTES");
            foreach (var cliente in unaLista)
            {
                Clientes.Add(cliente.NombreEmpresa.ToString());
            }
            return Clientes;
        }
        #endregion

        #region elección de Ciudad según País
        public ObservableCollection<string> EleccionPais(string pais)
        {
            string eleccion = pais;
            Ciudades = new ObservableCollection<string>();
            List<CustomerVO> unaLista = new List<CustomerVO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.SeleccionPais(eleccion);
            Ciudades.Add("TODAS LAS CIUDADES");

            foreach (var ciudad in unaLista)
            {
                Ciudades.Add(ciudad.Ciudad.ToString());
            }

            return Ciudades;

        }

        #endregion

        #region Boton customers
        public ObservableCollection<CustomerVO> BotonDTO(string pais, string ciudad)
        {
            this.pais = pais;
            this.Ciudad = ciudad;
            
            List<CustomerVO> unaLista = new List<CustomerVO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.BotonBLL(Pais, Ciudad);
            ClientesBoton = new ObservableCollection<CustomerVO>(unaLista);

            return ClientesBoton;

        }
        #endregion


        #endregion

    }
}
