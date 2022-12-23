using AreaOfGeometicFigures.Domain.Entities;
using MediatR;

namespace AreaOfGeometricFigure.Application.UseCase
{
    public class GetTriangleSquareCalculationQuery : IRequest<double>
    {
        public AbstractGeometricEntity? Entity { get; set; }
    }
    public class GetTriangleSquareCalculationQueryHandler
        : IRequestHandler<GetTriangleSquareCalculationQuery, double>
    {
        public async Task<double> Handle(GetTriangleSquareCalculationQuery request, CancellationToken cancellationToken)
        {
            if (request.Entity != null && request.Entity is Triangle)
                return ((Triangle)request.Entity).GetSquareOfFigure();
            return default(double);
        }
    }
}
