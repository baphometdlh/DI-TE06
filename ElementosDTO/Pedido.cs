using ElementosVO;
using NorthwindBLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosDTO
{
    public class Pedido
    {
        #region Atributos
        private GestionBLL unaGestion;
        private string unCliente;
        private ObservableCollection<PedidosDTO> pedidos;
        private SqlDataAdapter adaptadorPedidos;
        #endregion

        #region Constructor
        public Pedido() { }
        #endregion

        #region Propiedades
        public GestionBLL UnaGestion { get => unaGestion; set => unaGestion = value; }
        public string UnCliente { get => unCliente; set => unCliente = value; }
        public ObservableCollection<PedidosDTO> Pedidos { get => pedidos; set => pedidos = value; }
        public SqlDataAdapter AdaptadorPedidos { get => adaptadorPedidos; set => adaptadorPedidos = value; }
        #endregion

        #region Métodos

        #region Métoddo para obtener datos de un cliente en concreto
        public ObservableCollection<PedidosDTO> pedidosCliente(string unCliente)
        {
            this.UnCliente = unCliente;

            List<PedidosDTO> unaLista = new List<PedidosDTO>();
            UnaGestion = new GestionBLL();            
            unaLista = unaGestion.PedidosBLL(UnCliente);
            Pedidos = new ObservableCollection<PedidosDTO>(unaLista);

            return Pedidos;
        }
        #endregion

        #region Método para obtener cantidad y precio de los productos de los pedidos
        public ObservableCollection<PedidosDTO> UnidadesCantidad(string cliente)
        {
            this.UnCliente = cliente;

            List<PedidosDTO> unaLista = new List<PedidosDTO>();
            unaGestion= new GestionBLL();
            unaLista = unaGestion.UnidadesCantidad(UnCliente);
            Pedidos = new ObservableCollection<PedidosDTO>(unaLista);

            return Pedidos;

        }
        #endregion

        #region Método para obtener los productos, el precio unitario y la cantidad que pide un cliente
        public ObservableCollection<PedidosDTO> ProductosCliente(string cliente)
        {
            this.UnCliente = cliente;

            List<PedidosDTO> unaLista = new List<PedidosDTO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.ProductosCliente(UnCliente);
            Pedidos = new ObservableCollection<PedidosDTO>(unaLista);

            return Pedidos;

        }
        #endregion

        #endregion
    }
}
