using Microsoft.EntityFrameworkCore;
namespace HandsonAPIWithEFCodeFirst_Demo1.Entities
{
    public class MyContext:DbContext
    {
        //define entity set
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@123;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
