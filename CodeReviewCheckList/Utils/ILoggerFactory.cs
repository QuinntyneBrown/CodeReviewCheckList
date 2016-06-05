using System.Collections.Generic;

namespace CodeReviewCheckList.Utils
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
