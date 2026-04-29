using core.Application.Interfaces.Repositories;

namespace core.Application.Interfaces;

public interface IUnitOfWork
{
    IRoleRepository Roles { get; }

    IEmployeeRepository Employees { get; }

    IEmployeePhoneRepository EmployeePhones { get; }

    IClientRepository Clients { get; }

    IClientPhoneRepository ClientPhones { get; }

    IFinancialRepository Financials { get; }

    ITasksRepository Tasks { get; }

    IEmployeeRoleRepository EmployeeRoles { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}