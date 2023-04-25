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
    public class EmpleadosDTO
    {
        #region Atributos
        private ObservableCollection<EmpleadosVO> empleadosBoton;
        #endregion

        #region Constructores
        public EmpleadosDTO() { }
        #endregion

        #region Propiedades
        public ObservableCollection<EmpleadosVO> EmpleadosBoton { get => empleadosBoton; set => empleadosBoton = value; }
        #endregion

        #region Métodos
        #region todos los empleados de la base de datos
        public ObservableCollection<EmpleadosVO> BotonEmpleadosDTO()
        {
            List<EmpleadosVO> unaLista = new List<EmpleadosVO>();
            GestionBLL unaGestion = new GestionBLL();
            unaLista = unaGestion.EmpeladosBLL();
            EmpleadosBoton = new ObservableCollection<EmpleadosVO>(unaLista);

            return EmpleadosBoton;
        }
        #endregion
        #endregion
    }
}
