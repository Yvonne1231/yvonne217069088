using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmApp.NewDb
{
    public class FilmContext : DbContext
    {
        public DbSet<Filmtbl> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.FilmApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Filmtbl
    {
        [Key]
        public int FilmId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}