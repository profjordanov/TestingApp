using TestingApp.Models;

namespace TestingApp.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TestingAppContext : DbContext
    {

        public TestingAppContext()
            : base("TestingAppContext")
        {
        }

        public virtual DbSet<FirstTest> FirstTests { get; set; }
    }


}