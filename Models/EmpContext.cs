using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GitTaskEx.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("Connection")
        {

        }
        public DbSet<Emp> Emps { get; set; }
    }
}