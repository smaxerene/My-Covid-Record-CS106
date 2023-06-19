using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        // public DbSet<UserDetails> UserDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=rosie.db.elephantsql.com;Database=zbjbtgnq;Username=zbjbtgnq;Password=PKNbH0np9lpE1enC8hxK4ye3X7xMeuf-");

    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
    }

    public class UserDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Passport { get; set; }
        public string DoseNo { get; set; }
        public string Date { get; set; }
        public string Vaccine { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
    }

}
