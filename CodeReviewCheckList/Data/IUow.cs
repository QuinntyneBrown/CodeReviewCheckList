namespace CodeReviewCheckList.Data
{
    public interface IUow
    {
        IRepository<Models.CodeReviewCheckList> CodeReviewCheckLists { get; }
        void SaveChanges();
    }
}
