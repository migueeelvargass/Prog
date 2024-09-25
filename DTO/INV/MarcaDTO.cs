using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDemo.DTO.INV
{
    public class MarcaDTO
    {
        // (?) Significa que ese campo puede ser nulo
        public int Id {  get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? UsuarioCrea {  get; set; }

        // Campos opcionales
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifica {  get; set; }
        public bool Estado { get; set; } = false;
    }
}
