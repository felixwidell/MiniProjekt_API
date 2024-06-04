using MiniProjekt_API.Data;
using MiniProjekt_API.Models;
using MiniProjekt_API.ViewModels;
using System.Net;

namespace MiniProjekt_API.Handlers
{
    public class LinkHandler
    {
        public static IResult GetUserLinks(ApiContext context, int id)
        {
            RelationTableView[] relations = context.RelationTable.Select(x => new RelationTableView { RelationID = x.RelationID, FK_User = x.FK_User, FK_Interest = x.FK_Interest }).Where(x => x.FK_User == id).ToArray();

            var Interests = context.Interests;
            var InterestLinks = context.InterestLinks;
            List<InterestsView> interestlist = new List<InterestsView>();
            List<InterestLinksView> linkList = new List<InterestLinksView>();

            foreach (var relation in relations)
            {
                foreach (var interest in Interests)
                {
                    if (relation.FK_Interest == interest.InterestID)
                    {
                        interestlist.Add(new InterestsView { InterestName = interest.InterestName, InterestDescription = interest.InterestDescription, InterestID = interest.InterestID });
                    }
                }
            }

            foreach (var interest in interestlist)
            {
                foreach (var link in InterestLinks)
                {
                    if (interest.InterestID == link.FK_InterestLinks_Interests)
                    {
                        linkList.Add(new InterestLinksView { LinkID = link.LinkID, LinkUrl = link.LinkUrl, FK_InterestLinks_Interests = link.FK_InterestLinks_Interests});
                    }
                }
            }

            return Results.Json(linkList);
        }

        public static IResult AddLinkToInterest (ApiContext context, int interestId, string linkUrl)
        {
            context.InterestLinks.Add(new InterestLinks
            {
                LinkUrl = linkUrl,
                FK_InterestLinks_Interests = interestId
            });
            context.SaveChanges();

            return Results.StatusCode((int)HttpStatusCode.Created);
        }
    }
}
