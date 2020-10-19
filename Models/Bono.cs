using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EXAMEN.Models
{
    [Table("personas")]
    public class Bono
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombres")]
        [Column("nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellidos")]
        [Column("apellidos")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su  Distrito")]
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String Distrito { get; set; }

        [Display(Name="Banco")]
        [Column("banco")]
        public String Banco { get; set; }
        [Display(Name="Edad")]
        [Column("edad")]
        public int Edad { get; set; }

        [Display(Name="Sexo")]
        [Column("sexo")]
        public String Se { get; set; }

        [Display(Name="Autor")]
        [Column("autor")]
        public String Author { get; set; }

        [NotMapped]

        public String Response { get; set; }

    }
}