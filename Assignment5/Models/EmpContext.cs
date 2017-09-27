using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext():base("MyConn")
        {

        }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Cty> Ctys { get; set; }
        public DbSet<State> States { get; set; }
    }
}