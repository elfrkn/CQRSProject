using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly Context _context;

        public UpdateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.EmployeeID);
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.Salary = request.Salary;
            await _context.SaveChangesAsync();
        }
    }
}
