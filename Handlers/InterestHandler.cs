using MiniProjekt_API.Data;
using MiniProjekt_API.Models;
using MiniProjekt_API.ViewModels;

namespace MiniProjekt_API.Handlers
{
    public class InterestHandler
    {
        public static IResult GetUserInterests(ApiContext context, int id)
        {
            RelationTableView[] relations = context.RelationTable.Select(x => new RelationTableView { RelationID = x.RelationID, FK_User = x.FK_User, FK_Interest = x.FK_Interest }).Where(x => x.FK_User == id).ToArray();

            var Interests = context.Interests;
            List<InterestsView> list = new List<InterestsView>();

            foreach (var relation in relations)
            {
                foreach (var interest in Interests)
                {
                    if(relation.FK_Interest == interest.InterestID)
                    {
                        list.Add(new InterestsView { InterestName = interest.InterestName, InterestDescription = interest.InterestDescription, InterestID = interest.InterestID });
                    }
                }
            }
            return Results.Json(list);
        }
    }
}
