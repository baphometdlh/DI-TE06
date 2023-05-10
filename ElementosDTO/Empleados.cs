using ElementosVO;
using NorthwindBLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosDTO
{
    public class Empleados
    {
        #region Atributos
        private ObservableCollection<EmpleadosDTO> empleadosBoton;
        #endregion

        #region Constructores
        public Empleados() { }
        #endregion

        #region Propiedades
        public ObservableCollection<EmpleadosDTO> EmpleadosBoton { get => empleadosBoton; set => empleadosBoton = value; }
        #endregion

        #region Métodos
        #region todos los empleados de la base de datos
        public ObservableCollection<EmpleadosDTO> BotonEmpleadosDTO()
        {
            List<EmpleadosDTO> unaLista = new List<EmpleadosDTO>();
            GestionBLL unaGestion = new GestionBLL();
            unaLista = unaGestion.EmpeladosBLL();
            EmpleadosBoton = new ObservableCollection<EmpleadosDTO>(unaLista);

            return EmpleadosBoton;
        }
        #endregion
        #endregion
    }
}
