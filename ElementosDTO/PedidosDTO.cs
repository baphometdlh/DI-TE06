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
    public class PedidosDTO
    {
        #region Atributos
        private GestionBLL unaGestion;
        private string unCliente;
        private ObservableCollection<PedidosVO> pedidos;
        private SqlDataAdapter adaptadorPedidos;
        #endregion

        #region Constructor
        public PedidosDTO() { }
        #endregion

        #region Propiedades
        public GestionBLL UnaGestion { get => unaGestion; set => unaGestion = value; }
        public string UnCliente { get => unCliente; set => unCliente = value; }
        public ObservableCollection<PedidosVO> Pedidos { get => pedidos; set => pedidos = value; }
        public SqlDataAdapter AdaptadorPedidos { get => adaptadorPedidos; set => adaptadorPedidos = value; }
        #endregion

        #region Métodos

        #region Métoddo para obtener datos de un cliente en concreto
        public ObservableCollection<PedidosVO> pedidosCliente(string unCliente)
        {
            this.UnCliente = unCliente;

            List<PedidosVO> unaLista = new List<PedidosVO>();
            UnaGestion = new GestionBLL();            
            unaLista = unaGestion.PedidosBLL(UnCliente);
            Pedidos = new ObservableCollection<PedidosVO>(unaLista);

            return Pedidos;
        }
        #endregion

        #region Método para obtener cantidad y precio de los productos de los pedidos
        public ObservableCollection<PedidosVO> UnidadesCantidad(string cliente)
        {
            this.UnCliente = cliente;

            List<PedidosVO> unaLista = new List<PedidosVO>();
            unaGestion= new GestionBLL();
            unaLista = unaGestion.UnidadesCantidad(UnCliente);
            Pedidos = new ObservableCollection<PedidosVO>(unaLista);

            return Pedidos;

        }
        #endregion

        #region Método para obtener los productos, el precio unitario y la cantidad que pide un cliente
        public ObservableCollection<PedidosVO> ProductosCliente(string cliente)
        {
            this.UnCliente = cliente;

            List<PedidosVO> unaLista = new List<PedidosVO>();
            unaGestion = new GestionBLL();
            unaLista = unaGestion.ProductosCliente(UnCliente);
            Pedidos = new ObservableCollection<PedidosVO>(unaLista);

            return Pedidos;

        }
        #endregion

        #endregion
    }
}
