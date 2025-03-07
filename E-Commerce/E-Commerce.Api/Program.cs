
using E_Commerce.Api.Constants;
using E_Commerce.Api.Data;
using Microsoft.EntityFrameworkCore;
namespace E_Commerce.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<DataContext>(options=>
                options.UseSqlServer(builder.Configuration.GetConnectionString(DatabaseConstants.GroceryConnectionStringKey)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            var mastersGroup = app.MapGroup("/masters").AllowAnonymous();
            mastersGroup.MapGet("/categories", async (DataContext context) =>
                await context.Categories.AsNoTracking().ToArrayAsync()

            );
            mastersGroup.MapGet("/offers", async (DataContext context) =>
                await context.Offers.AsNoTracking().ToArrayAsync()

            );
            app.UseStaticFiles();
            app.Run("https://localhost:12345");
        }
    }
}
