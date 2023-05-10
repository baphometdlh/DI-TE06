using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosVO
{
    public class PedidosDTO
    {
        #region Atributos
        private int orderID;
        private string clienteID;
        private string empleadoID;
        private DateTime fechaPedido;
        private DateTime fechaRequerida;
        private string fechaEnvio;
        private double precioUnitario;
        private int cantidad;
        private string nombreProducto;

        
        #endregion

        #region Constructor
        public PedidosDTO() { }

        #endregion

        #region Propiedades
        public int OrderID { get => orderID; set => orderID = value; }
        public string ClienteID { get => clienteID; set => clienteID = value; }
        public string EmpleadoID { get => empleadoID; set => empleadoID = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaRequerida { get => fechaRequerida; set => fechaRequerida = value; }
        public string FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string NombreProdcuto { get => nombreProducto; set => nombreProducto = value; }
        #endregion
    }
}
