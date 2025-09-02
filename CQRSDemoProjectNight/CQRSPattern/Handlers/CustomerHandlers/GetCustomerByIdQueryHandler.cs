using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Queries.CustomerQueries;
using CQRSDemoProjectNight.CQRSPattern.Results.CustomerResults;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class GetCustomerByIdQueryHandler
    {
        private readonly DemoContext _context;
        public GetCustomerByIdQueryHandler(DemoContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery query)
        {
            var values = await _context.Customers.FindAsync(query.CustomerId);
            return new GetCustomerByIdQueryResult
            {
                 CustomerId = values.CustomerId,
                    CustomerName = values.CustomerName,
                    CustomerSurname = values.CustomerSurname,
                    CustomerCity = values.CustomerCity
            };
        }
    }
}
