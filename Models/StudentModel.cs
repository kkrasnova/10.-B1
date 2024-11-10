using System;
using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public string PhoneNumber { get; set; }

        public StudentModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
        }
    }
}