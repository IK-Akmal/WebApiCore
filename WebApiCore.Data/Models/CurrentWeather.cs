using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiCore.Data.Models
{
    public class CurrentWeather
    {
        [Key]
        public Guid ID { get; set; }
        public string Status { get; set; }
        public float Temp { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
    }
}