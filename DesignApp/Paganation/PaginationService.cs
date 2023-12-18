using Pagination.Models;

namespace Pagination.Paganation
{
    public class PaginationService : IPaginationService
    {
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
        public PaginationService()
        {
            pageSize = 3;
            pageIndex = 1;
        }
        public decimal pageCount
        {
            get
            {
                return Math.Round(Convert.ToDecimal(TotalElements / pageSize));
            }
        }
        public int TotalElements { get; set; }

        public List<Product> GetPage(List<Product> products)
        {
            TotalElements = products.Count;

            return products.OrderBy(p => p.ProductId).
                Skip((pageIndex - 1) * pageSize).
                Take(pageSize).ToList();
        }

        public bool InRange()
        {
            if (pageIndex >= 1 && pageIndex <= pageCount)
                return true;
            else
                return false;
        }
    }
}
