namespace CQRSDemoProjectNight.CQRSPattern.Queries.CustomerQueries
{
    public class GetCustomerByIdQuery
    {
        public int CustomerId { get; set; }

        public GetCustomerByIdQuery(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
