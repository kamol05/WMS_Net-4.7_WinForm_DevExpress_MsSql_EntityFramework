using SKLAD.MODEL.Event;
using System.Data.Entity;
using System.Linq;

namespace SKLAD.EF
{
    public static class QueryExtensionHelperClass
    {
        public static IQueryable<Event> BuildEventIncludedAllRelationships(this IQueryable<Event> query)
        {
            return query.Include(x => x.Customer)
                        .Include(x => x.Warehouse)
                        .Include(x => x.Product)
                        .Include(x => x.Product.Quality)
                        .Include(x => x.Product.Design)
                        .Include(x => x.Product.Color)
                        .Include(x => x.Invoice)
                        .Include(x => x.User);
        }
        public static IQueryable<SaleEvent> BuildSaleEventIncludedAllRelationships(this IQueryable<SaleEvent> query)
        {
            return query.Include(x => x.Customer)
                        .Include(x => x.Product)
                        .Include(x => x.Product.Quality)
                        .Include(x => x.Product.Design)
                        .Include(x => x.Product.Color)
                        .Include(x => x.Invoice);
        }
    }
}
