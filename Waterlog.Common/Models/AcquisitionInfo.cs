using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Waterlog.Common.Models
{
    public class AcquisitionInfo
    {
        [Key]
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string MethodDescription { get; set; }
    }
}
