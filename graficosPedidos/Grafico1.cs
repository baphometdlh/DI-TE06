using ElementosVO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace graficosPedidos
{
    public partial class formPedidos : Form
    {
        public formPedidos()
        {
            InitializeComponent();
        }

        #region Método para insertar los datos en el gráfico
        public void MostrarDatos(ObservableCollection<PedidosVO> tabla, ObservableCollection<PedidosVO> queso)
        {
            chartPedidos.DataSource= tabla;
            chartQueso.DataSource= queso;
            ObservableCollection<int> countCantidad= new ObservableCollection<int>();
            ObservableCollection<int> cantidad= new ObservableCollection<int>();
            ObservableCollection<int> countPrecio = new ObservableCollection<int>(); 
            ObservableCollection<double> precio = new ObservableCollection<double>();

            try
            {
                //falta por hacer un método para esto.
                for (int i = 0; i < tabla.Count; i++)
                {
                    countCantidad.Add(i);
                    cantidad.Add(tabla[i].Cantidad);
                }

                for (int i = 0; i < tabla.Count; i++)
                {
                    countPrecio.Add(i);
                    precio.Add(tabla[i].PrecioUnitario);
                }

                chartPedidos.Series["Unidades Producto"].Points.DataBindXY(countCantidad, cantidad);
                chartPedidos.Series["Precio Producto"].Points.DataBindXY(countPrecio, precio);

                chartQueso.Series["producto"].Points.DataBindXY(countCantidad, cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion


        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
