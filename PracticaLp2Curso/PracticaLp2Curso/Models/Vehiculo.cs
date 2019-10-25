using System;
using System.Linq;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Models
{
  public class Vehiculo
  {
    [Key]
    public int Vehiculo_ID {get;set;}
    public int Modelo_ID {get;set;}
    public string Nombre {get;set;}
    [MaxLength(50)]
    public string Descripcion{ get; set; }
    public int numChasis {get;set;}
    public int Marca_ID {get;set;}
  }
}
