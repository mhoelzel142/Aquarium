using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class Aquarium
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Equipment> Equipment { get; set; }
        public List<Livestock> Livestock { get; set; }
        public List<Decoration> Decoration { get; set; }
    }
}
