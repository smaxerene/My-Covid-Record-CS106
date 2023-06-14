using Microsoft.EntityFrameworkCore;


namespace My_Covid_Record
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
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
}
