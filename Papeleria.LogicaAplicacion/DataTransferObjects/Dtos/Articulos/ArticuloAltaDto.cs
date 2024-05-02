using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos
{
    public class ArticuloAltaDto
    {
        [Required]
        public long CodigoProveedor { get; set; }
        public string NombreArticulo { get; set; } 
        public string Descripcion { get; set; }
        public double PrecioVP { get; set; }
        public int Stock {  get; set; }

    }
}
