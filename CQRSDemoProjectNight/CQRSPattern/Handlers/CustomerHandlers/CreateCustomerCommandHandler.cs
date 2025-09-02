using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CategoryCommands;
using CQRSDemoProjectNight.CQRSPattern.Commands.CustomerCommands;
using CQRSDemoProjectNight.Entities;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class CreateCustomerCommandHandler
    {
        private readonly DemoContext _context;
        public CreateCustomerCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateCustomerCommand command)
        {
            _context.Customers.Add(new Customer //Burada dto görevi gören CreateCustomerCommand ile  Customer entitysini mapliyoruz.
            {
                    CustomerName = command.CustomerName,
                    CustomerSurname = command.CustomerSurname,
                    CustomerCity = command.CustomerCity
            });
            await _context.SaveChangesAsync();
        }
    }
}
