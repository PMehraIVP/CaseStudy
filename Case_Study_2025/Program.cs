
using Case_Study_2025.EquitiesRepo;
using Case_Study_2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Case_Study_2025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<NewcsContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("server=192.168.0.13\\sqlexpress,49753; database=newcs; trustservercertificate=true; user id=sa; password=sa@12345678;")));
            builder.Services.AddScoped<IEquityTable, EquityTableOps>();
            builder.Services.AddScoped<IBondsTable, BondsTableOps>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           

            // Add CORS services
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
