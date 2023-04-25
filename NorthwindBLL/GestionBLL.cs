using ElementosVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatosDAL;
using System.Data.SqlClient;

namespace NorthwindBLL
{
    public class GestionBLL
    {
        #region Atributos
        private List<CustomerVO> paises;
        private List<CustomerVO> ciudades;
        private List<CustomerVO> clientes;
        private List<CustomerVO> boton;
        private List<EmpleadosVO> empleados;
        private List<PedidosVO> pedidos;
        private SqlDataAdapter adaptadorPedidos;
        private ConsultasSQL unaConsulta;
        private string unpais;
        private string unaCiudad;
        private string unCliente;
        #endregion

        #region Constructor
        public GestionBLL() { }
        #endregion

        #region Propiedades
        public ConsultasSQL UnaConsulta { get => unaConsulta; set => unaConsulta = value; }
        public string Unpais { get => unpais; set => unpais = value; }
        public List<CustomerVO> Ciudades { get => ciudades; set => ciudades = value; }
        public string UnaCiudad { get => unaCiudad; set => unaCiudad = value; }
        public List<CustomerVO> Boton { get => boton; set => boton = value; }
        public List<EmpleadosVO> Empleados { get => empleados; set => empleados = value; }
        public List<CustomerVO> Paises { get => paises; set => paises = value; }
        public List<PedidosVO> Pedidos { get => pedidos; set => pedidos = value; }
        public string UnCliente { get => unCliente; set => unCliente = value; }
        public List<CustomerVO> Clientes { get => clientes; set => clientes = value; }
        public SqlDataAdapter AdaptadorPedidos { get => adaptadorPedidos; set => adaptadorPedidos = value; }
        #endregion

        #region Métodos para CLIENTES
        #region Método para obtener todas las ciudades
        public List<CustomerVO> CiudadesBLL()
        {
            unaConsulta = new ConsultasSQL();
            Ciudades = unaConsulta.ConsultaCiudades();
            return Ciudades;
        }
        #endregion

        #region Método para obtener todos los paises
        public List<CustomerVO> PaisesBLL()
        {
            unaConsulta = new ConsultasSQL();
            Paises = unaConsulta.ConsultaPaises();
            return Paises;
        }
        #endregion

        #region método para obtener las ciudades de un país en concreto        
        public List<CustomerVO> SeleccionPais(string unpais)
        {
            unaConsulta = new ConsultasSQL();
            this.Unpais = unpais;
            ciudades = unaConsulta.CiudadesPais(unpais);
            return ciudades;

        }
        #endregion

        #region método para pedir la lista de lo que se ha seleccionado clicando el boton        
        public List<CustomerVO> BotonBLL(string pais, string ciudad)
        {

            if (pais.Equals("TODOS LOS PAISES"))
            {
                this.Unpais = "%";
            }
            else
            {
                this.Unpais = pais;
            }

            if (ciudad.Equals("TODAS LAS CIUDADES"))
            {
                this.unaCiudad = "%";
            }
            else
            {
                this.unaCiudad = ciudad;
            }


            ConsultasSQL unaConsulta = new ConsultasSQL();
            Boton = unaConsulta.ConsultaBoton(Unpais, UnaCiudad);
            return Boton;

        }
        #endregion

        #region Método para obtener una lista con todos los cliente
        public List<CustomerVO> ClienteBLL()
        {
            unaConsulta= new ConsultasSQL();
            Clientes = unaConsulta.ConsultaCliente();
            return Clientes;
        }
        #endregion

        #endregion

        #region Métodos para EMPLEADOS
        #region Método para pedir la lista de todos los empleados
        public List<EmpleadosVO> EmpeladosBLL()
        {
            unaConsulta = new ConsultasSQL();
            Empleados = unaConsulta.consultaEmpleados();
            return empleados;
        }
        #endregion
        #endregion

        #region Métodos para PEDIDOS

        #region Método para pedir info de pedidos de un cliente en concreto
        public List<PedidosVO> PedidosBLL(string unCliente)
        {
            if(unCliente.Equals("TODOS LOS CLIENTES"))
            {
                this.UnCliente = "%";
            }
            else
            {
                this.UnCliente = unCliente;
            }
            
            unaConsulta= new ConsultasSQL();
            Pedidos = unaConsulta.ConsultaPedidosCantidades(UnCliente);
            return Pedidos;
        }
        #endregion

        #region Método para obtener las unidades y precio de pedidos de cliente
        public List<PedidosVO> UnidadesCantidad(string cliente)
        {
            if (cliente.Equals("TODOS LOS CLIENTES"))
            {
                this.UnCliente = "%";
            }
            else
            {
                this.UnCliente = cliente;
            }

            unaConsulta= new ConsultasSQL();
            Pedidos = unaConsulta.ConsultaCantidadPrecio(UnCliente);
            return Pedidos;
        }
        #endregion

        #region Método para obtener los productos, el precio unirtario y la cantidad por pedido de un cliente
        public List<PedidosVO> ProductosCliente(string cliente)
        {
            if (cliente.Equals("TODOS LOS CLIENTES"))
            {
                this.UnCliente = "%";
            }
            else
            {
                this.UnCliente = cliente;
            }

            unaConsulta = new ConsultasSQL();
            Pedidos = unaConsulta.ConsultaProductosPedidos(UnCliente);
            return Pedidos;
        }
        #endregion

        #endregion
    }
}
