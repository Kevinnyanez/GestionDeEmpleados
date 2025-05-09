using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeempleadosProductos.Models
{
    public class Productos
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaID { get; set; }
        public int SubCatID { get; set; }
    }
    
}
