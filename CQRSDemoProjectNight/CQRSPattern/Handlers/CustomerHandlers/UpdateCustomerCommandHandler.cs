using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CategoryCommands;
using CQRSDemoProjectNight.CQRSPattern.Commands.CustomerCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler
    {
        private readonly DemoContext _context;
        public UpdateCustomerCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCustomerCommand command)
        {
            var values = await _context.Customers.FindAsync(command.CustomerId);
            if (values != null)
            {
                values.CustomerName = command.CustomerName;
                values.CustomerSurname = command.CustomerSurname;
                values.CustomerCity = command.CustomerCity;
                await _context.SaveChangesAsync();
            }
        }
    }
}
