using System;
using System.ComponentModel.DataAnnotations;

namespace EXAMEN.Models
{
    public class Bono
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombres")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellidos")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su  Distrito")]
        [Display(Name="Distrito")]
        public String Distrito { get; set; }

        [Display(Name="Banco")]
        public String Banco { get; set; }
        [Display(Name="Edad")]
        public String Edad { get; set; }

        [Display(Name="Sexo")]
        public String Se { get; set; }

        [Display(Name="Autor")]
        public String Author { get; set; }

        public String Message { get; set; }

        public String Response { get; set; }

    }
}