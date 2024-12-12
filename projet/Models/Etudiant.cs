using System;
using System.ComponentModel.DataAnnotations;

namespace Projet.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
    }
}
