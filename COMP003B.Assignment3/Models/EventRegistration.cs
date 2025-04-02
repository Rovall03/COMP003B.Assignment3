using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration : Controller
    {
        [Required]
        public string FullName { get; set; }
        [MinLength(3)]

        [Required]
        public string Email { get; set; }

        [Required]
        public string EventCode { get; set; }
        [MaxLength(20)]
        public int Tickets { get; set; }
        [Range(1,10)]

        public string ReferralCode { get; set; }
    }
}