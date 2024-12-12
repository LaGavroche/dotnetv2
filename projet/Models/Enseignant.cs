using System.ComponentModel.DataAnnotations;

namespace Projet.Models
{
    public class Enseignant
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Specialite { get; set; }
        public string Email { get; set; }
    }
}
