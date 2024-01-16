using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("tbl_staff")]
    public class Staff
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }
        
    }
}
