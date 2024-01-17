using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandsOnEFCodeFirst_Demo2
{
    public class StudentMarks
    {
        public string Exam { get; set; }
        public int? TotalMarks { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Std { get; set; }
        public string Section { get; set; }
    }
}
