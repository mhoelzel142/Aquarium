using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Waterlog.Common.Models
{
    /// <summary>
    /// The main Aquarium object, consisting of the Tank, Equipment, Livestock and Decorations
    /// </summary>
    public class Aquarium
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int TankId { get; set; }

        [ForeignKey(nameof(TankId))]
        public Tank Tank { get; set; }

        public IEnumerable<Equipment> Equipment { get; set; }

        public IEnumerable<Livestock> Livestock { get; set; }

        public IEnumerable<Decoration> Decorations { get; set; }

        public IEnumerable<Reading> Readings { get; set; }
    }
}
