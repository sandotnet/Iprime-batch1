using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    public class MyContext:DbContext
    {
        //define entity set
        public DbSet<Student> Students { get; set; }
        public DbSet<Marks> Markets { get; set; }
        public DbSet<Staff> Staff { get; set; }
        //confire connect
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=SMSDB;User ID=sa;Password=pass@123;Trust Server Certificate=True");
        }

    }
}
