using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using MiniProjekt_API.Data;
using MiniProjekt_API.Models;
using MiniProjekt_API.ViewModels;
using System.Net;
using System.Text.Json;

namespace MiniProjekt_API.Handlers
{
    public class UsersHandler
    {
        public static IResult GetAllUsers(ApiContext context)
        {
            List<UsersView> test = new List<UsersView>();
            UsersView[] result = context.Users.Select(x => new UsersView { Firstname = x.Firstname, Lastname = x.Lastname, UserID = x.UserID }).ToArray();
            test.Add(result[1]);
            return Results.Json(test);
        }

        public static IResult AddUserToInterest(ApiContext context, int userId, int interestId)
        {
            context.RelationTable.Add(new RelationTable
            {
                FK_User = userId, 
                FK_Interest = interestId
            });
            context.SaveChanges();

            return Results.StatusCode((int)HttpStatusCode.Created);
        }
    }
}
