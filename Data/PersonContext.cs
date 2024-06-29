
using Microsoft.EntityFrameworkCore;
using crudApiApp.Models;

namespace crudApiApp.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options):base(options){}
        public DbSet<PersonModel> PersonModel{get;set;}

    }
    
}