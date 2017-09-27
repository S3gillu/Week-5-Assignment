using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class Cty
    {
        public int CtyId { get; set; }
        public string CtyName { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}