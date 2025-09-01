using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.ProductCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly DemoContext _context;
        public UpdateProductCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand command)
        {
            var values = await _context.Products.FindAsync(command.ProductId);
            if (values != null)
            {
                values.ProductName = command.ProductName;
                values.ProductStock = command.ProductStock;
                values.ProductPrice = command.ProductPrice;
                await _context.SaveChangesAsync();
            }
        }
    }
}
