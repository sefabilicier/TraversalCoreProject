using DataAccessLayer.Concretes;
using System;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQueryResult query)
        {
            var values = _context.Destinations.Find(query.DestinationID);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price,
            };
        }

        internal object Handle(GetDestinationByIDQuery getDestinationByIDQuery)
        {
            throw new NotImplementedException();
        }
    }
}
