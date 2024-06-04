namespace MiniProjekt_API.ViewModels
{
    public class RelationTableView
    {
        public int RelationID { get; set; } 
        public virtual int FK_User { get; set; }
        public virtual int FK_Interest { get; set; }
    }
}
