using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CategoryCommands;
using CQRSDemoProjectNight.CQRSPattern.Commands.ProductCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly DemoContext _context;
        public RemoveProductCommandHandler(DemoContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand command)
        {
            var values = await _context.Products.FindAsync(command.ProductId);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
