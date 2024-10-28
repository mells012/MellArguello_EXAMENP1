using System.ComponentModel.DataAnnotations;

namespace MellArguello_EXAMENP1.Models
{
    public class MA_Burger
    {
        [Key]
        public int MA_Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string? MA_Nombre { get; set; }



        [Display(Name = "Consumidor Final")]
        public bool MA_ConsumidorFinal { get; set; }



        [Range(0.01, 9999.99, ErrorMessage = "El precio debe estar entre 0.01 y 9999.99.")]
        [DataType(DataType.Currency)]
        public decimal MA_Precio { get; set; }



        [Required]
        [DataType(DataType.Date)]
        public DateTime MA_Fecha { get; set; }
        


    }
}
