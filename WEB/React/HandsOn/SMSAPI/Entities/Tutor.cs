using System.ComponentModel.DataAnnotations;

namespace SMSAPI.Entities
{
    public class Tutor
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
       
    }
}
