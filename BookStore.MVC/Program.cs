using BookStore.MVC;
using BookStore.MVC.Database;
using BookStore.MVC.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSqlite<BookStoreContext>("Data Source=BookStore.db");

builder.Services.AddTransient<IBookRepository, BookRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapDefaultControllerRoute();

app.CreateDbIfItNotExist();

app.Run();
