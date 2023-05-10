using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ElementosVO;
using System.Globalization;
using System.Data;

namespace BaseDatosDAL
{
    public class ConsultasSQL
    {
        #region Atributos
        private String Ruta = @"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234";
        private string seleccion;

        #endregion

        #region Propiedades
        public string Seleccion { get => seleccion; set => seleccion = value; }
        #endregion


        #region Constructor
        public ConsultasSQL() { }
        #endregion


        #region Abrir conexion.
        public void AbrirConexion()
        {
            //cadena de conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            try
            {
                conn.Open();
                Console.WriteLine("Conexion establecida con exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
        #endregion


        #region CONSULTAS CLIENTES
        #region Consultas para la tabla Customers

        #region Consulta para sacar la lista de clientes
        public List<CustomerDTO> ConsultaCliente()
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            //consulta
            string sql = "select CompanyName from customers;";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;


            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> clientes = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unCliente = new CustomerDTO();
                    unCliente.NombreEmpresa = dataReader.GetValue(0).ToString();
                    clientes.Add(unCliente);
                }

                dataReader.Close();
                command.Dispose();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region consulta para sacar la lista de paises
        public List<CustomerDTO> ConsultaPaises()
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            //consulta
            string sql = "select Country from customers group by Country;";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;


            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> paises = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unPais = new CustomerDTO();
                    unPais.Pais = dataReader.GetValue(0).ToString();
                    paises.Add(unPais);
                }

                dataReader.Close();
                command.Dispose();
                return paises;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region consulta para sacar las ciudades de un pais elegido
        public List<CustomerDTO> CiudadesPais(string Seleccion)
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = Seleccion;

            //consulta
            string sql = "select city from Customers where country like \'"+ Seleccion + "\' group by city;";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> ciudades = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unaCiudad = new CustomerDTO();
                    unaCiudad.Ciudad = dataReader.GetValue(0).ToString();
                    ciudades.Add(unaCiudad);
                }

                dataReader.Close();
                command.Dispose();
                return ciudades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region consulta para sacar la lista de todas las ciudades.
        public List<CustomerDTO> ConsultaCiudades()
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            //consulta
            string sql = "select city from customers group by city;";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;


            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> ciudades = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unaCiudad = new CustomerDTO();
                    unaCiudad.Ciudad = dataReader.GetValue(0).ToString();
                    ciudades.Add(unaCiudad);
                }

                dataReader.Close();
                command.Dispose();
                return ciudades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region consulta para sacar los clientes de una ciudad en concreto
        public List<CustomerDTO> ClientesCiudad(string Seleccion)
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = Seleccion;

            //consulta
            string sql = "select CompanyName from Customers where city like \'" + Seleccion + "\';";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> clientes = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unCliente = new CustomerDTO();
                    unCliente.NombreEmpresa = dataReader.GetValue(0).ToString();
                    clientes.Add(unCliente);
                }

                dataReader.Close();
                command.Dispose();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region consulta para sacar los clientes de un pais en concreto
        public List<CustomerDTO> ClientesPais(string Seleccion)
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = Seleccion;

            //consulta
            string sql = "select CompanyName from Customers where country like \'" + Seleccion + "\';";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> clientes = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unCliente = new CustomerDTO();
                    unCliente.NombreEmpresa = dataReader.GetValue(0).ToString();
                    clientes.Add(unCliente);
                }

                dataReader.Close();
                command.Dispose();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #endregion

        #region Consulta para el botón Customers
        public List<CustomerDTO> ConsultaBoton(String pais, string ciudad)
        {

            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = Seleccion;

            //consulta
            string sql = "select * from customers where country like \'"+ pais + "\' and city like \'"+ ciudad +"\';";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<CustomerDTO> clientes = new List<CustomerDTO>();

                while (dataReader.Read())
                {
                    CustomerDTO unCliente = new CustomerDTO();
                    unCliente.IDCliente= dataReader.GetValue(0).ToString();
                    unCliente.NombreEmpresa = dataReader.GetValue(1).ToString();
                    unCliente.NombreContacto = dataReader.GetValue(2).ToString();
                    unCliente.TituloContacto = dataReader.GetValue(3).ToString();
                    unCliente.Direccion= dataReader.GetValue(4).ToString();
                    unCliente.Ciudad= dataReader.GetValue(5).ToString();
                    unCliente.Region= dataReader.GetValue(6).ToString();
                    unCliente.CodigoPostal= dataReader.GetValue(7).ToString();
                    unCliente.Pais= dataReader.GetValue(8).ToString();
                    unCliente.Telefono = dataReader.GetValue(9).ToString();
                    unCliente.Fax= dataReader.GetValue(10).ToString();
                    clientes.Add(unCliente);
                }

                dataReader.Close();
                command.Dispose();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #endregion

        #region CONSULTAS EMPLEADOS

        #region consulta para sacar la lista de todos los empleados
        public List<EmpleadosDTO> consultaEmpleados()
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = Seleccion;

            //consulta
            string sql = "select * from employees;";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<EmpleadosDTO> empleados = new List<EmpleadosDTO>();

                while (dataReader.Read())
                {
                    EmpleadosDTO unEmpleado = new EmpleadosDTO();
                    unEmpleado.IDEmpleado = dataReader.GetValue(0).ToString();
                    unEmpleado.Apellido = dataReader.GetValue(1).ToString();
                    unEmpleado.Nombre = dataReader.GetValue(2).ToString();
                    unEmpleado.Titulo = dataReader.GetValue(3).ToString();
                    unEmpleado.TituloDeCortesia = dataReader.GetValue(4).ToString();
                    unEmpleado.FechaNacimiento = dataReader.GetValue(5).ToString();
                    unEmpleado.FechaInicio = dataReader.GetValue(6).ToString();
                    unEmpleado.Direccion = dataReader.GetValue(7).ToString();
                    unEmpleado.Ciudad = dataReader.GetValue(8).ToString();
                    unEmpleado.Telefono = dataReader.GetValue(12).ToString();
                    unEmpleado.Extension = dataReader.GetValue(13).ToString();
                    empleados.Add(unEmpleado);
                }

                dataReader.Close();
                command.Dispose();
                return empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #endregion

        #region CONSULTAS PEDIDOS

        #region Consulta para sacar información de los pedidos de un cliente en concreto
        public List<PedidosDTO> ConsultaPedidosCantidades(string cliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;

            this.Seleccion = cliente;

            //consulta
            string sql = "select * from orders join customers " +
                "on orders.CustomerID = customers.CustomerID where customers.CompanyName like \'" + Seleccion + "\'";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<PedidosDTO> pedidos= new List<PedidosDTO>();

                while (dataReader.Read())
                {
                    PedidosDTO unPedido= new PedidosDTO();
                    unPedido.OrderID= int.Parse(dataReader.GetValue(0).ToString());
                    unPedido.ClienteID= dataReader.GetValue(1).ToString();
                    unPedido.EmpleadoID= dataReader.GetValue(2).ToString();
                    unPedido.FechaPedido= DateTime.Parse(dataReader.GetValue(3).ToString());
                    unPedido.FechaRequerida= DateTime.Parse(dataReader.GetValue(4).ToString());
                    unPedido.FechaEnvio = dataReader.GetValue(5).ToString();
                    if (unPedido.FechaEnvio.Equals(""))
                    {
                        unPedido.FechaEnvio = "Pedido no enviado";
                    }
                    

                    pedidos.Add(unPedido);
                }

                dataReader.Close();
                command.Dispose();
                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Consulta para sacar la cantidad y el precio de los pedidos de cliente
        public List<PedidosDTO> ConsultaCantidadPrecio(string cliente)
        {
            SqlConnection conn = new SqlConnection(this.Ruta);
            
            SqlCommand command;
            this.Seleccion = cliente;

            //consulta
            string sql = "select [Order Details].UnitPrice, [Order Details].Quantity from [Order Details] join orders on [Order Details].OrderID=orders.OrderID " +
                "join customers on orders.CustomerID=customers.CustomerID where customers.CompanyName like \'" + Seleccion + "\';";
            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<PedidosDTO> pedidos = new List<PedidosDTO>();

                while (dataReader.Read())
                {
                    PedidosDTO unPedido = new PedidosDTO();
                    unPedido.PrecioUnitario= double.Parse(dataReader.GetValue(0).ToString());
                    unPedido.Cantidad= int.Parse(dataReader.GetValue(1).ToString());

                    pedidos.Add(unPedido);
                }

                dataReader.Close();
                command.Dispose();
                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region Consulta para sacar los nombres, precio y unidades de productos en los pedidos de cliente
        public List<PedidosDTO> ConsultaProductosPedidos(string cliente)
        {
            SqlConnection conn = new SqlConnection(this.Ruta);

            SqlCommand command;
            this.Seleccion = cliente;

            //consulta
            string sql = "select Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from products join [Order Details] " +
                "on products.ProductID=[Order Details].ProductID " +
                "join orders on [Order Details].OrderID=orders.OrderID " +
                "join Customers on orders.CustomerID=customers.CustomerID " +
                "where customers.CompanyName like \'"+ Seleccion + "\' order by Products.ProductName;";

            //ojbeto para lectura de datos
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                List<PedidosDTO> pedidos = new List<PedidosDTO>();

                while (dataReader.Read())
                {
                    PedidosDTO unPedido = new PedidosDTO();
                    unPedido.NombreProdcuto = dataReader.GetValue(0).ToString();
                    unPedido.PrecioUnitario = double.Parse(dataReader.GetValue(1).ToString());
                    unPedido.Cantidad = int.Parse(dataReader.GetValue(2).ToString());

                    pedidos.Add(unPedido);
                }

                dataReader.Close();
                command.Dispose();
                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion

        #endregion
    }
}
