using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration : Controller
    {
        [Required]
        [MinLength(3)]
        public string FullName { get; set; }
       

        [Required]
        public string Email { get; set; }

        [Required] 
        [MaxLength(20)]
        public string EventCode { get; set; }
       

        [Range(1,10)]
        public int Tickets { get; set; }
        

      
    }
}