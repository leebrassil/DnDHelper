using System.Data.Entity;

namespace DnDHelper.Models
{
    public class DnDHelperContext : DbContext
    {
        public DnDHelperContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DnDHelperContext>());
        }        
        public DbSet<Character> Characters { get; set; }
    }
}