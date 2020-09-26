using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class AquariumTaskType
    {
        [Key]
        public int Id { get; set; }

        public string TaskName { get; set; }

        public string TaskDescription { get; set; }
    }
}
