using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CategoryCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly DemoContext _context;
        public RemoveCategoryCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCategoryCommand command)
        {
            var values = await _context.Categories.FindAsync(command.CategoryId);
            _context.Categories.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
