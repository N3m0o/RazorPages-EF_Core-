using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Model

{
    public class NotesDbContext:DbContext
    {
       public NotesDbContext(DbContextOptions<NotesDbContext> options) : base (options)
        {
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Note>().ToTable("Notes");
        }
        public DbSet<WebApplication1.Model.Note> Note { get; set; } = default!;


    }
}
