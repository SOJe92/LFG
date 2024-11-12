using AutoMapper;
using Microsoft.Extensions.Options;
using SearchAndRescue;
using SearchAndRescue.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => $"{type.Name}_{System.Guid.NewGuid()}");
});

RepositoryRegistration.RegisterRepositories(builder.Services);
ServicesRegistration.RegisterServices(builder.Services);
Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    //app.UseHttpsRedirection();
} else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();
