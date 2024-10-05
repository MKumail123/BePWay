using BEPWay.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BEPWay.DataContext
{
    public class BEPContext : DbContext
    {
        public BEPContext(DbContextOptions<BEPContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Refference> Refferences { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserPackage> UserPackages { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var packages = new List<Package>
            {
                new Package
                {
                    Id = Guid.Parse("07da424c-1b7f-407e-be59-908884b25015"),
                    Name = "Basic Friendly",
                    Amount = 1500,
                    Points = 15,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    Value = 7.5,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Package
                {
                    Id = Guid.Parse("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                    Name = "Advance Pro Bundle",
                    Amount = 5250,
                    Points = 52.5,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    Value = 26.25,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Package
                {
                    Id = Guid.Parse("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                    Name = "Premium Max Bundle",
                    Amount = 9000,
                    Points = 90,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    Value = 45,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Package
                {
                    Id = Guid.Parse("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                    Name = "Alpha Leadership Bundle",
                    Amount = 19000,
                    Points = 190,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    Value = 95,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },

            };
            modelBuilder.Entity<Package>().HasData(packages);

            var accounts = new List<Bank>
            {
                new Bank
                {
                    Id = Guid.Parse("db8eb400-822e-4794-a176-42a3f4f93af6"),
                    BankName = "Easypaisa",
                    AccountNo = "03205001894",
                    AccountTitle = "Taimoor Haider Shah",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Bank
                {
                    Id = Guid.Parse("5e89ff39-452a-422b-9a70-de023150e2ec"),
                    BankName = "Jazzcash",
                    AccountNo = "03098379012",
                    AccountTitle = "Nalain Abbas",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Bank
                {
                    Id = Guid.Parse("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                    BankName = "Allied Bank",
                    AccountNo = "01210010080914760010",
                    AccountTitle = "Sohail Ahmed",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Bank
                {
                    Id = Guid.Parse("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                    BankName = "Sadapay",
                    AccountNo = "03098379012",
                    AccountTitle = "Nalain Abbas",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
            };

            modelBuilder.Entity<Bank>().HasData(accounts);

            var role = new List<Role>
            {
                new Role
                {
                    Id = Guid.Parse("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                    Name = "Admin",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                },
                new Role
                {
                    Id = Guid.Parse("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                    Name = "Customer",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                }
            };

            modelBuilder.Entity<Role>().HasData(role);

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.Parse("cdab35de-e131-484c-9b33-8cb210af0beb"),
                    Name = "Admin",
                    Password = "Admin",
                    FatherName = "Admin",
                    CNIC = "123132433231",
                    DateOfBirth = System.DateTime.Now,
                    MobileNo = "03005019767",
                    Email = "admin@gmail.com",
                    UserName = "Admin",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                }
            };

            modelBuilder.Entity<User>().HasData(users);

            var userRole = new List<UserRole>
            {
                new UserRole
                {
                    Id = Guid.Parse("b360eb40-3220-4a22-b5d9-d6b4625fda08"),
                    Active = true,
                    UserId = Guid.Parse("cdab35de-e131-484c-9b33-8cb210af0beb"),
                    RoleId = Guid.Parse("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin"
                }
            };

            modelBuilder.Entity<UserRole>().HasData(userRole);

        }
    }
}
