using System.ComponentModel.DataAnnotations;

namespace MellArguello_EXAMENP1.Models
{
    public class MA_Burger
    {
        public int MA_Id { get; set; }
        public string? MA_Nombre { get; set; }
        public bool MA_ConsumidorFinal { get; set; }
        public decimal MA_Precio { get; set; }
        public DateTime MA_Fecha { get; set; }
    }
}
