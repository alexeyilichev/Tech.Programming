namespace TelerikMvcApp1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }

        public virtual DbSet<Sellers> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Build(Database.Connection);
        }
    }
}
