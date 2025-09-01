using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Results.ProductResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly DemoContext _context;
        public GetProductQueryHandler(DemoContext context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _context.Products.ToListAsync();
            return values.Select(x=>new GetProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice
            }).ToList();
        }
    }
}
