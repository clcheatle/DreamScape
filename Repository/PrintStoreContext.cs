using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PrintStoreContext: DbContext
    {
        public PrintStoreContext(DbContextOptions<PrintStoreContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ManyToManyRelationshipConfiguration(modelBuilder);
        }

        private void ManyToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {
            
        }
    }
}