
using SMSAPI.Entities;
using SMSAPI.Repositories;

namespace SMSAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<StudentRepository>();
            builder.Services.AddDbContext<MyContext>();
            builder.Services.AddControllers();
            //enable cors to the project
            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options =>
                {
                    options.AllowAnyOrigin()    //allow any client url
                    .AllowAnyMethod() //allow any http method
                    .AllowAnyHeader(); //allow any header
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            //add cors middleware
            app.UseCors("AllowOrigin");
            app.MapControllers();

            app.Run();
        }
    }
}
