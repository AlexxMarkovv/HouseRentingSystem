using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.DataConstants.DataConstants;

namespace HouseRentingSystem.Data.Models
{
    [Comment("House Category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Category Name")]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of houses")]
        public List<House> Houses { get; set; } = new List<House>();
    }
}
