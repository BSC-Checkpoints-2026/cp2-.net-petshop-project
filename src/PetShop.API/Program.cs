using Microsoft.EntityFrameworkCore;
using PetShop.Application.Interfaces.Appointment;
using PetShop.Application.Interfaces.Customer;
using PetShop.Application.Interfaces.Employee;
using PetShop.Application.Interfaces.Pet;
using PetShop.Application.Interfaces.Product;
using PetShop.Application.Interfaces.Service;
using PetShop.Application.Services;
using PetShop.Infrastructure.Context;
using PetShop.Infrastructure.Repositories;

namespace petShop;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=petshop.db"));

        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddScoped<ICustomerService, CustomerService>();
        
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IProductService, ProductService>();

        builder.Services.AddScoped<IPetRepository, PetRepository>();
        builder.Services.AddScoped<IPetService, PetService>();
      
        builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        builder.Services.AddScoped<IAppointmentService, AppointmentService>();
        
        builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
        builder.Services.AddScoped<IServiceService, ServiceService>();
        
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();
        
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}