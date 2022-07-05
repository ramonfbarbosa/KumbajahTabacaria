using System.Collections.Generic;

namespace KumbajahTabacaria.Infra.Pagination
{
    public class PaginationResponse<T> where T : class
    {
        public int ResultsCount { get; set; }
        public List<T> Results { get; set; }

        public PaginationResponse(int resultCount, List<T> results)
        {
            ResultsCount = resultCount;
            Results = results;
        }
    }
}
