namespace TraversalCoreProject.CQRS.Queries.DestinationQueries
{
    public class GetAllDestinationQuery
    {
        public GetAllDestinationQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
