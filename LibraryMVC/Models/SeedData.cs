using LibraryMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Models
{
    public class SeedData
    {  
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                // if the database empty then add these two books
                // if it is not then return with the current books 
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(new Book { Title = "Asp.net Developing", CallNumber = "ASQ 2000" },
                    new Book { Title = "C sharp", CallNumber = "ASQ 2122" }
                );
                context.SaveChanges();
            }
        }
    }
}
