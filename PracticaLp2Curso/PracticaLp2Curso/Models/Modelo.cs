using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLp2Curso.Models
{
    public class Modelo
    {
        [Key]
        public int Id_Modelo { get; set; }
        public string Nombre { get; set; }
    }
}
