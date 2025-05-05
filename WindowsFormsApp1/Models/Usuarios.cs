using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Admin
    {
        //
        public int IdAdmin { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool EsAdmin { get; set; }

    }
}
