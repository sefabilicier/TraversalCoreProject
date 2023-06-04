using MediatR;
using System.Threading.Tasks;
using System.Threading;
using TraversalCoreProject.CQRS.Commands.GuideCommands;
using DataAccessLayer.Concretes;
using EntityLayer.Concretes;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommanHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommanHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });

            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        Task IRequestHandler<CreateGuideCommand>.Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

}
