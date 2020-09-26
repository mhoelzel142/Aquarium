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
    }
}
