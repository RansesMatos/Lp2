using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Models
{
  public class Modelo
  {
    [Key]
    public int Id_Modelo {get;set;}

    [MaxLength(50)]
    public string Nombre {get;set;}
    public int Marca_ID {get;set;}
  }
}
