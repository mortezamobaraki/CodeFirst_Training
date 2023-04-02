using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.Entity;

namespace CodeFirst_Training.Models
{
    public class DbCodeFirstContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}