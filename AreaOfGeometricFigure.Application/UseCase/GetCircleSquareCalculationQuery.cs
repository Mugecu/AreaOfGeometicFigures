using AreaOfGeometicFigures.Domain.Entities;
using MediatR;

namespace AreaOfGeometricFigure.Application.UseCase
{
    public class GetCircleSquareCalculationQuery : IRequest<double>
    {
        public AbstractGeometricEntity? Entity { get; set; }
    }
    public class GetCircleSquareCalculationQueryHandler
        : IRequestHandler<GetCircleSquareCalculationQuery, double>
    {
        public async Task<double> Handle(GetCircleSquareCalculationQuery request, CancellationToken cancellationToken)
        {
            if(request.Entity != null && request.Entity is Сircle)
                return ((Сircle)request.Entity).GetSquareOfFigure();
            return default(double);
        }
    }
}
