using System.ComponentModel.DataAnnotations;

namespace EddyCapellan_AP1_P2.Models;

public class Combos
{
    [Key]
    public int ComboId { get; set; }
    [Required(ErrorMessage = "Favor colocar la fecha")]
    public DateTime? Fecha { get; set; }
    [Required(ErrorMessage = "Favor colocar la descripcion")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "Favor colocar el precio")]
    public int Precio { get; set; }
    public bool Vendido { get; set; }

    public List<CombosDetalle> comboDetalle { get; set; } = new List<CombosDetalle>();


}