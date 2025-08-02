using System.ComponentModel.DataAnnotations;

namespace CRUD_Cursos.Model
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del curso es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El código del curso es obligatorio.")]
        public string Codigo { get; set; }
        [Range(1, 100, ErrorMessage = "El cupo debe estar entre 1 y 100.")]
        public int Cupo { get; set; }
    }
}
