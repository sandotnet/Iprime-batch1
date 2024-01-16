using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("tbl_marks")]
    public class Marks
    {
        [Key]
        public Guid MarksId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Exam { get; set; }
        public int? TotalMarks { get; set; } //set column as null
        public int StudentId { get; set; } //set  as FK

        //Navigation property
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
