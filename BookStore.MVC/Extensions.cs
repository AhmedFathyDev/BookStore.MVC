using BookStore.MVC.Database;
using BookStore.MVC.Models;

namespace BookStore.MVC;

public static class Extensions
{
    public static void CreateDbIfItNotExist(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<IBookStoreContext>();
        context.Database.EnsureCreated();
        context.Initialize();
    }

    private static void Initialize(this IBookStoreContext context)
    {
        if (context.Books.Any())
        {
            return;
        }

        var books = new BookModel[]
        {
            new BookModel
            {
                Title = "C# 10 in a Nutshell",
                Author = "Joseph Albahari"
            },
            new BookModel
            {
                Title = "C# 10 and .NET 6",
                Author = "Mark J. Price"
            },
            new BookModel
            {
                Title = "The Linux Command Line",
                Author = "William Shotts"
            },
            new BookModel
            {
                Title = "Introduction To Algorithms",
                Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, and Clifford Stein"
            }
        };

        context.Books.AddRange(books);
        context.SaveChanges();
    }
}