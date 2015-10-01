namespace mmoManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MMORPGModel : DbContext
    {
        public MMORPGModel()
            : base("name=MMORPGModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Guild> Guilds { get; set; }
        public virtual DbSet<Serve> Serves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guild>()
                .Property(e => e.GuildName)
                .IsUnicode(false);

            modelBuilder.Entity<Serve>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Serve>()
                .Property(e => e.ServerRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Serve>()
                .HasMany(e => e.Guilds)
                .WithRequired(e => e.Serve)
                .WillCascadeOnDelete(false);
        }
    }
}
