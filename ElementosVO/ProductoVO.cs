using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosVO
{
    public class ProductoVO
    {

        #region Atributos
        private string nombreProducto;
        private string productID;
        #endregion

        #region Constructor
        public ProductoVO() { }
        #endregion

        #region Propiedades
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string ProductID { get => productID; set => productID = value; }
        #endregion
    }
}
