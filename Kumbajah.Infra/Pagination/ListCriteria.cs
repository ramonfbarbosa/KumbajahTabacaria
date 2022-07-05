using System.Collections.Generic;

namespace Kumbajah.Infra.Pagination
{
    public class ListCriteria
    {
        public Filter Filter { get; set; }
        public List<SortingPage> Sortings { get; set; }
        public PagedResponse Pagination { get; set; }
    }
}
