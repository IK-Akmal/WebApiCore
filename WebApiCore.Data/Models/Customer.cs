using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiCore.Data.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirtDate { get; set; }
    }
}