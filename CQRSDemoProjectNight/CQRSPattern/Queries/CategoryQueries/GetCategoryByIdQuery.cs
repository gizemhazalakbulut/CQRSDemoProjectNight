namespace CQRSDemoProjectNight.CQRSPattern.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
