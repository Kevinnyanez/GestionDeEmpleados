using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    
        public class Empleados
        {
            public int IdEmpleado { get; set; }
            public string NombreCompleto { get; set; }
            public string NumeroCelular { get; set; }
            public string Gmail { get; set; }
            public string DNI { get; set; }
            public string FechaCumple { get; set; }
            public bool CumpleHoy { get; set; }
            public int DiasPersonalesAsignados { get; set; }
            public int DiasPersonalesRestantes { get; set; }
            public int VacacionesAsignadas { get; set; }
            public int VacacionesUsadas { get; set; }
            public int LicenciasAsignadas { get; set; }
            public int LicenciasUsadas { get; set; }
            public string Contraseña { get; set; }
        }
    
}
