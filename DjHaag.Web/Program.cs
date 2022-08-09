using DjHaag.Application.CompetenceMatrice;
using DjHaag.Application.Person.Commands;
using DjHaag.Application.Person.Queries;
using DjHaag.Persitence;
using Microsoft.EntityFrameworkCore;
using DjHaag.Web.Data;
using DjHaag.Web.Pages;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true;  });

builder.Services.AddDbContext<DjHaagDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<AddPersonCommand>();
builder.Services.AddTransient<GetPersonQuery>();
builder.Services.AddTransient<GetCompetenceMatrice>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();