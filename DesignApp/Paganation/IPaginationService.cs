using Pagination.Models;

namespace Pagination.Paganation
{
    public interface IPaginationService
    {
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
        public decimal pageCount { get; }
        public int TotalElements { get; set; }


        public List<Product> GetPage();
        public bool InRange();
    }
}
