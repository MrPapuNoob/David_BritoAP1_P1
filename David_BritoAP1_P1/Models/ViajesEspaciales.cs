
using System.ComponentModel.DataAnnotations;
namespace David_BritoAP1_P1.Models;

public class ViajesEspaciales
{
    [Key]
    public int ViajeId { get; set; }
    public string Fecha { get; set; }
  
    public string Descripcion { get; set; }

    

    public int Costo { get; set; }

}

