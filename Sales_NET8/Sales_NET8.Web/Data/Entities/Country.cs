using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no mínimo {1} caractéres. ")]
        public string? Name { get; set; }
    }
}
