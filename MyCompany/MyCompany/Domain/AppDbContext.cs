using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            }, new IdentityRole
            {
                Id = "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                Name = "student",
                NormalizedName = "STUDENT"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            }, new IdentityUser
            {
                Id = "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                UserName = "student",
                NormalizedUserName = "STUDENT",
                Email = "myStudent@email.com",
                NormalizedEmail = "MYSTUDENT@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            }, new IdentityUserRole<string>
            {
                RoleId = "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                UserId = "5b62452e-4f66-49fa-a20f-e7521b1355d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField { 
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), 
                CodeWord = "PageIndex", 
                Title = "Главная"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), 
                CodeWord = "PageServices", 
                Title = "Наши новости"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), 
                CodeWord = "PageContacts", 
                Title = "Контакты"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                CodeWord = "PageSchedule",
                Title = "Страница студента"
            });
        }
    }
}
