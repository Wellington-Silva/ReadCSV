/*using Microsoft.EntityFrameworkCore;
//using WebII.Model;

namespace WebII.Data
{
    public class WebII : DbContext
    {
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Prerequisito> Prerequisitos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String connectionString = @"Server=.; Database=WebII; Trusted_Connection=True; User Id=wellington; Password=;";
            options.UseSqlServer(connectionString);
        }
    }
}*/
