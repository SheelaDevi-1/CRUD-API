using System.ComponentModel.DataAnnotations;

namespace CurdProject.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Adresses { get; set; }
        public int Phoneno { get; set; }
    }
}
