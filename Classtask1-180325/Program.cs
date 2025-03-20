using Classtask1_180325.DATA;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conf = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(conf.GetConnectionString("afsahString"));
// nothing
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
