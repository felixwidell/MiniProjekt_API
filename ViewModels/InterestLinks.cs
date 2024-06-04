namespace MiniProjekt_API.ViewModels
{
    public class InterestLinksView
    {
        public int LinkID { get; set; }
        public string LinkUrl { get; set; }
        public virtual int FK_InterestLinks_Interests { get; set; }
    }
}
