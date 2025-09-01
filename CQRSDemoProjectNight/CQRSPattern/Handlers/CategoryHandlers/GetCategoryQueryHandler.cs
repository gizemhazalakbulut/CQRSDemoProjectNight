using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Results.CategoryResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly DemoContext _context;

        public GetCategoryQueryHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task<List<GetCategoryQueryResult>> Handle() //Handle ismi standart olarak kullanılır. İşlemek demektir.
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
