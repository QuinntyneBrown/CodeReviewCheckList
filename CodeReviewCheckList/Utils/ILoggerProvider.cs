namespace CodeReviewCheckList.Utils
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
