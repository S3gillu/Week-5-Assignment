using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class EmpVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }
        public int StateId { get; set; }
        public int CtyId { get; set; }
        public IEnumerable<Cty> City { get; set; }
        public IEnumerable<State> State { get; set; }
        public Emp Employee { get; set; }
    }
}