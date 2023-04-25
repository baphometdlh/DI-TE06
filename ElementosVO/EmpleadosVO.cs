using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosVO
{
    public class EmpleadosVO
    {

        #region Atributos
        private string iDEmpleado;
        private string apellido;
        private string nombre;
        private string titulo;
        private string tituloDeCortesia;
        private string fechaNacimiento;
        private string fechaInicio;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string extension;
        #endregion

        #region Constructor
        public EmpleadosVO() { }
        #endregion

        #region Propiedades
        public string IDEmpleado { get => iDEmpleado; set => iDEmpleado = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string TituloDeCortesia { get => tituloDeCortesia; set => tituloDeCortesia = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Extension { get => extension; set => extension = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        #endregion

    }
}
