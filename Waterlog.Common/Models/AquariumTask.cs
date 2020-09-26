using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Waterlog.Common.Models
{
    public class AquariumTask
    {
        [Key]
        public int Id { get; set; }

        public int AquariumTaskTypeId { get; set; }

        public int AquariumTaskFrequencyId { get; set; }

        [ForeignKey(nameof(AquariumTaskFrequencyId))]
        public virtual AquariumTaskFrequency Frequency { get; set; }

        [ForeignKey(nameof(AquariumTaskTypeId))]
        public virtual AquariumTaskType Type { get; set; }

        public List<AquariumTask> ScheduledTasks { get; set; }
    }
}
