using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLp2Curso.Models
{
    public class Marca
    {
        [Key]
        public int ID_marca { get; set; }
        public string Nombre_marca { get; set; }

    }
}
