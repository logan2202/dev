using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace agenda
{
    public partial class agenda2 : DbContext
    {
        public agenda2()
            : base("name=agenda2")
        {
        }

        public virtual DbSet<qsdfg__customers> qsdfg__customers { get; set; }
        public virtual DbSet<qsdfg_appointments> qsdfg_appointments { get; set; }
        public virtual DbSet<qsdfg_brokers> qsdfg_brokers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<qsdfg__customers>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg__customers>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg__customers>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg__customers>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg__customers>()
                .HasMany(e => e.qsdfg_appointments)
                .WithRequired(e => e.qsdfg__customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<qsdfg_appointments>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .HasMany(e => e.qsdfg__customers)
                .WithRequired(e => e.qsdfg_brokers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<qsdfg_brokers>()
                .HasMany(e => e.qsdfg_appointments)
                .WithRequired(e => e.qsdfg_brokers)
                .WillCascadeOnDelete(false);
        }
    }
}
