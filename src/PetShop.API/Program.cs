using Microsoft.EntityFrameworkCore;
using PetShop.Application.Interfaces;
using PetShop.Infrastructure.Context;
using PetShop.Infrastructure.Repositories;

namespace petShop;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=petshop.db"));

        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}