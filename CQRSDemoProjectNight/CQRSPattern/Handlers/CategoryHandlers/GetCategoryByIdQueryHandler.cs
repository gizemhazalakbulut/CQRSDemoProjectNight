using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Queries.CategoryQueries;
using CQRSDemoProjectNight.CQRSPattern.Results.CategoryResults;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly DemoContext _context;
        public GetCategoryByIdQueryHandler(DemoContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _context.Categories.FindAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = values.CategoryId,
                CategoryName = values.CategoryName
            };
        }
    }
}
