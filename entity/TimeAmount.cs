using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace congestion.calculator.entity
{
    public class TimeAmount
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        public TimeSpan EndTime { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
