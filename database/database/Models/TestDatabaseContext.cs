using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace database.Models
{
    public class TestDatabaseContext : DbContext
    {
        public TestDatabaseContext() : base("name=TestDb")
        {

        }

        public DbSet<Todo> Todoes { get; set; }
    }
}