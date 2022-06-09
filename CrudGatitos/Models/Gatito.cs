using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudGatitos.Models
{
    public class Gatito
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por Favor no deje al Gatito sin Nombre")]
        [StringLength(50, ErrorMessage = "El Nombre tiene un maximo de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La raza es obligatoria")]
        [StringLength(50, ErrorMessage = "La Raza tiene un maximo de 50 caracteres")]
        public string Raza { get; set; }

        public decimal Peso { get; set; }

        public int Edad { get; set; }

        public string Colores { get; set; }

        public string Imagen { get; set; }
    }
}
