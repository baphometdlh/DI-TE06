﻿using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using ElementosDTO;
using ElementosVO;
using FichaEmpleados;
using graficosPedidos;
using Reportes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NorthwindApp_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Atributos
        public List<string> listaEleccion { get; set; }
        public List<string> listaPaises { get; set; }
        public List<string> listaClientes { get; set; }
        public ObservableCollection<string> listaCiudades { get; set; }
        public ObservableCollection<CustomerDTO> unBotonCliente { get; set; } 
        public ObservableCollection<EmpleadosDTO> unBotonEmpleado { get; set; }
        public ObservableCollection<PedidosDTO> unBotonPedido { get; set; }
        public ObservableCollection<PedidosDTO> unBotonGrafico { get; set; }
        public ObservableCollection<PedidosDTO> unBotonQueso { get; set; }
        public string unPais { get; set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            #region Lista de Paises
            try
            {
                listaPaises = new List<string>();
                Customer unosPaises = new Customer();
                listaPaises = unosPaises.GestionPaises();
                this.DataContext = this;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                
            }
            #endregion

            #region Lista Ciudades
            try
            {
                listaCiudades = new ObservableCollection<string>();
                Customer todasCiudades = new Customer();
                listaCiudades = todasCiudades.GestionCiudades();
                this.DataContext = this;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            #endregion

            #region Lista Clientes
            try
            {
                listaClientes = new List<string>();
                Customer unosClientes = new Customer();
                listaClientes = unosClientes.GestionClientes();
                this.DataContext = this;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
            #endregion
        }

        #region CLIENTES: ComboBox y botones

        #region Combox para elegir el pais de los clientes
        private void ComboBoxPaises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                this.unPais = ComboBoxPaises.SelectedItem.ToString();

                Customer unaConsulta = new Customer();
                if (ComboBoxPaises.SelectedItem.Equals("TODOS LOS PAISES"))
                {
                    ComboBoxCiudad.SelectedIndex = -1;
                    listaCiudades = unaConsulta.GestionCiudades();
                    ComboBoxCiudad.ItemsSource = listaCiudades;
                }
                else
                {
                    listaCiudades = unaConsulta.EleccionPais(unPais);
                    ComboBoxCiudad.ItemsSource = listaCiudades;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }

        }
        #endregion

        #region Botón de que muestra los pedidos del cliente seleccionado
        private void ButtonCustomers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pais = ComboBoxPaises.SelectedItem.ToString();
                string ciudad = ComboBoxCiudad.SelectedItem.ToString();
                unBotonCliente = new ObservableCollection<CustomerDTO>();
                Customer unCustomer = new Customer();
                unBotonCliente = unCustomer.BotonDTO(pais, ciudad);
                DataGrid.ItemsSource = unBotonCliente;
                DataGrid.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("No has seleccionado todo para poder hacer la busqueda");
            }

        }
        #endregion

        #region Botón para mostrar el panel de los clientes
        private void botonClientes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gridClientes.Visibility = Visibility.Visible;
                dataGridEmpleado.Visibility = Visibility.Hidden;
                GridPedidos.Visibility = Visibility.Hidden;
                GridEmpleado.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }

        }
        #endregion

        #region Botón para abrir la ventan de los informes
        private void ButtonInformeClientes_Click(object sender, RoutedEventArgs e)
        {
            InformeClientes unInforme = new InformeClientes();
            unInforme.Show();

        }
        #endregion

        #endregion

        #region EMPLEADOS: botones

        #region Botón para mostrar el panel de los empleados
        private void botonEmpleados_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GridPedidos.Visibility = Visibility.Hidden;
                DataGrid.Visibility = Visibility.Hidden;
                gridClientes.Visibility = Visibility.Hidden;
                unBotonEmpleado = new ObservableCollection<EmpleadosDTO>();
                Empleados unEmpleado = new Empleados();
                unBotonEmpleado = unEmpleado.BotonEmpleadosDTO();
                dataGridEmpleado.ItemsSource = unBotonEmpleado;
                dataGridEmpleado.Visibility = Visibility.Visible;
                GridEmpleado.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
          
        }
        #endregion

        #region Botón para mostrar una ficha de empleados
        private void botonFichaEmpleado_Click(object sender, RoutedEventArgs e)
        {
            EmpleadosDTO unEmpleado = new EmpleadosDTO();
            unEmpleado = (EmpleadosDTO)dataGridEmpleado.SelectedItem;
            
            try
            {
                Ficha unaFicha = new Ficha();
                if (unEmpleado.Equals(""))
                {
                    System.Windows.MessageBox.Show("No has seleccionado nigún empleado");
                }
                else
                {
                    unaFicha.UnEmpleado(unEmpleado);
                    unaFicha.Show();
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("No has seleccionado nigún empleado");

            }
            

        }
        #endregion

        #region Boton para generar un informe de empleados
        private void ButtonInformeEmpleados_Click(object sender, RoutedEventArgs e)
        {
            InformeEmpleados unInforme = new InformeEmpleados();
            unInforme.Show();
        }
        #endregion

        #endregion

        #region PEDIDOS: botones

        #region Botón pedidos
        private void botonPedidos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGrid.Visibility = Visibility.Hidden;
                gridClientes.Visibility = Visibility.Hidden;
                dataGridEmpleado.Visibility = Visibility.Hidden;
                GridPedidos.Visibility = Visibility.Visible;
                GridEmpleado.Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Boton para mostrar los pedidos en un datagrid
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cliente = comboxClientesPedidos.SelectedItem.ToString();
                unBotonPedido = new ObservableCollection<PedidosDTO>();
                Pedido unPedido= new Pedido();
                unBotonPedido = unPedido.pedidosCliente(cliente);
                dataGridEmpleado.ItemsSource = unBotonPedido;
                dataGridEmpleado.Visibility = Visibility.Visible;

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("No has seleccionado ningún Cliente");
            }
        }

        #endregion

        #region Botón para generar una gráfica con los pedidos.
        private void BotonGenerarGrafica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cliente = comboxClientesPedidos.SelectedItem.ToString();
                Pedido unPedido = new Pedido();
                Pedido otroPedido = new Pedido();
                unBotonGrafico = unPedido.UnidadesCantidad(cliente);
                unBotonQueso = otroPedido.ProductosCliente(cliente);


                formPedidos grafico = new formPedidos();

                grafico.MostrarDatos(unBotonGrafico, unBotonQueso);
                
                grafico.Show();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("No has seleccionado ningún Cliente");
            }
        }



        #endregion

        #region Botón para generar un informe
        private void ButtonInformePedidos_Click(object sender, RoutedEventArgs e)
        {
            InformePedidos unInforme = new InformePedidos();
            unInforme.Show();
        }


        #endregion

        #endregion

        #region Boton FastReport

        private void BotonFastReport_Click(object sender, RoutedEventArgs e)
        {
            InformeEspecial unInforme = new InformeEspecial();
            unInforme.Show();
        }

        #endregion


        #region Botón para abrir el archivo del manual de usuario
        private void BotonManual_Click(object sender, RoutedEventArgs e)
        {
            Help.ShowHelp(null, "file://C:\\GIT\\DI-TE06\\manual de usuario\\NorthwindApp.chm");
        }

        #endregion

    }
}
