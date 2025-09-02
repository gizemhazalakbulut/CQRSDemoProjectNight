using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Results.CategoryResults;
using CQRSDemoProjectNight.CQRSPattern.Results.CustomerResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class GetCustomerQueryHandler
    {
        private readonly DemoContext _context;

        public GetCustomerQueryHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task<List<GetCustomerQueryResult>> Handle() //Handle ismi standart olarak kullanılır. İşlemek demektir.
        {
            var values = await _context.Customers.ToListAsync();
            return values.Select(x => new GetCustomerQueryResult
            {
                CustomerId = x.CustomerId,
                CustomerCity = x.CustomerCity,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname
            }).ToList();
        }
    }
}
