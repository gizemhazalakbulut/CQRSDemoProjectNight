using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CategoryCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly DemoContext _context;
        public UpdateCategoryCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var values = await _context.Categories.FindAsync(command.CategoryId);
            if (values != null)
            {
                values.CategoryName = command.CategoryName;
                await _context.SaveChangesAsync();
            }
        }
    }
}
