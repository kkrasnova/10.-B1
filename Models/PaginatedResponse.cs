namespace RestApi.Models
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
        public string? NextLink { get; set; }

        public PaginatedResponse(IEnumerable<T> items, int totalCount, string? nextLink = null)
        {
            Items = items;
            TotalCount = totalCount;
            NextLink = nextLink;
        }
    }
}