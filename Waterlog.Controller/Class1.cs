using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterlog.Common.Models;
using Waterlog.Database;

namespace Waterlog.Controller
{
    public class AquariumController
    {
        public List<Aquarium> Aquaria { get; set; }
        public SqliteContext context; 
        public AquariumController(SqliteContext _context)
        {
            context = _context;
        }
        
    }
}
