namespace CQRSDemoProjectNight.CQRSPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
