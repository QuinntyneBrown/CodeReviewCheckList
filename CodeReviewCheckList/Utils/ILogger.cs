namespace CodeReviewCheckList.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
