using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int MedicoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage ="Ingrese el Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required(ErrorMessage ="Ingrese el Apellido")]
        public string Apellido { get; set; }

        [RegularExpression(@"^[A-Z]{2}\s+[1-9]{4}$", ErrorMessage = "Solo se aceptan dos letras y cuatro numeros")]
        public int Matricula { get; set; }
    }
}
