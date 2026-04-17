using phase_1.Models;
using Microsoft.EntityFrameworkCore;
using phase_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace phase_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-OSMEIU4\\SQLEXPRESS;Database=First_Phase_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
            }
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<OtpCode> OtpCodes { get; set; } = null!;
        public DbSet<PatientProfile> PatientProfiles { get; set; } = null!;
        public DbSet<StudentProfile> StudentProfiles { get; set; } = null!;
        public DbSet<LocationArea> LocationAreas { get; set; } = null!;
        public DbSet<ServiceType> ServiceTypes { get; set; } = null!;
        public DbSet<TreatmentCategory> TreatmentCategories { get; set; } = null!;
        public DbSet<Case> Cases { get; set; } = null!;
        public DbSet<Offer> Offers { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Conversation> Conversations { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;
        public DbSet<Reminder> Reminders { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<NoShowStrike> NoShowStrikes { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Load configurations from the Configurations folder
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}