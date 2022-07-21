using BookStore.MVC;
using BookStore.MVC.Database;
using BookStore.MVC.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IBookStoreContext, BookStoreContext>(optionsAction =>
    optionsAction.UseSqlite("Data Source=BookStore.db"));

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
