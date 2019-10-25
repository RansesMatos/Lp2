using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Models
{
  public class Vehiculo
  {
    [Primary Key]
    public int Vehiculo_ID {get;set;}
    public int Modelo_ID {get;set;}
    public string Nombre {get;set;}
    public int numChasis {get;set;}
    public int Marca_ID {get;set;}
  }
}
