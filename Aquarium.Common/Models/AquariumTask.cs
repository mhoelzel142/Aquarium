using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class AquariumTask
    {
        [Key]
        public int Id { get; set; }
        public virtual AquariumTaskFrequency Frequency { get; set; }
        public virtual AquariumTaskType Type { get; set; }
        public List<AquariumTask> ScheduledTasks { get; set; }
    }
}
