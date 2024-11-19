using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EddyCapellan_AP1_P2.Models;

public class CombosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    [Required(ErrorMessage ="Favor colocar combo")]
    public int ComboId { get; set; }
    [ForeignKey("ComboId")]
    public Combos combos { get; set; }
    [Required(ErrorMessage = "Favor colocar el articulo")]
    public int? ArticuloId { get; set; }
    [ForeignKey("ArticuloId")]
    public Articulos Articulos { get; set; }
    [Required(ErrorMessage = "Favor colocar la cantidad")]
    public int? Cantidad { get; set; }
    [Required(ErrorMessage = "Favor colocar el costo")]
    public decimal? Costo { get; set; }
}