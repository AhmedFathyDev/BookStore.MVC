var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("/", async (context) =>
    {
        await context.Response.WriteAsync("Hello, World!");
    });
});

app.Run();
