using BookStore.MVC.Database;

namespace BookStore.MVC;

public static class Extensions
{
    public static void CreateDbIfItNotExist(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<BookStoreContext>();
        context.Database.EnsureCreated();
        context.Initialize();
    }

    private static void Initialize(this BookStoreContext context)
    {
        if (context.Books.Any())
        {
            return;
        }
        
        // TODO: Complete Initialize method.
    }
}