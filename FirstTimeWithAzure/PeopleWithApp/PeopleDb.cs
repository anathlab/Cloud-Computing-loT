using Microsoft.EntityFrameworkCore;
using PeopleWithApp.Models;

namespace PeopleWithApp {
    public class PeopleDb : DbContext {
        public PeopleDb(DbContextOptions<PeopleDb> options) : base(options) {
        }

        public DbSet<Person> People { get; set; }
    }
}
