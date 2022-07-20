using BookStore.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.MVC.Database;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public DbSet<BookModel> Books => Set<BookModel>();
}