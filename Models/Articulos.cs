using System.ComponentModel.DataAnnotations;

namespace EddyCapellan_AP1_P2.Models;

public class Articulos
{
    [Key]
    public int ArticuloId { get; set; }
    public string Descripcion { get; set; }
    public decimal? Costo { get; set; }
    public decimal? Ganancia { get; set; }
    public decimal? Precio { get; set;}

}