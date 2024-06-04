using Microsoft.EntityFrameworkCore;
using MiniProjekt_API.Data;
using System.Globalization;
using MiniProjekt_API.Handlers;


namespace MiniProjekt_API
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

            string connectionString = builder.Configuration.GetConnectionString("ApiContext");
            builder.Services.AddDbContext<ApiContext>(options => options.UseSqlServer(connectionString));

            var app = builder.Build();


            //H�mta alla anv�ndare
            app.MapGet("/GetAllUsers", async (ApiContext db) =>
            {
                var users = await db.Users.ToListAsync();
                return Results.Ok(users);
            });

            //H�mta alla intressen kopplade till anv�ndare
            app.MapGet("/GetUserInterests/{id}", InterestHandler.GetUserInterests);

            //H�mta alla l�nkar till person
            app.MapGet("/GetUserLinks/{id}", LinkHandler.GetUserLinks);

            //L�nka person till intresse
            app.MapPost("/AddPersonToInterest/{userId}/{interestId}", UsersHandler.AddUserToInterest);

            //L�gg till l�nk till ett intresse
            app.MapPost("/AddLinkToInterest/{interestId}/{linkUrl}", LinkHandler.AddLinkToInterest);

            // Configure the HTTP request pipeline.
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
}
