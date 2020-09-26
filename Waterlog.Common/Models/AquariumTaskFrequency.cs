using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class AquariumTaskFrequency
    {
        [Key]
        public int Id { get; set; }

        public int Frequency { get; set; }
        
        public string Interval { get; set; }
    }
}
