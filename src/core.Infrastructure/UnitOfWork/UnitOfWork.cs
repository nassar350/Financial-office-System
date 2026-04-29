using core.Application.Interfaces;
using core.Application.Interfaces.Repositories;
using core.Infrastructure.Persistence;
using core.Infrastructure.Repositories;

namespace core.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(
        AppDbContext context,
        IRoleRepository roles,
        IEmployeeRepository employees,
        IEmployeePhoneRepository employeePhones,
        IClientRepository clients,
        IClientPhoneRepository clientPhones,
        IFinancialRepository financials,
        ITasksRepository tasks,
        IEmployeeRoleRepository employeeRoles)
    {
        _context = context;

        Roles = roles;
        Employees = employees;
        EmployeePhones = employeePhones;
        Clients = clients;
        ClientPhones = clientPhones;
        Financials = financials;
        Tasks = tasks;
        EmployeeRoles = employeeRoles;
    }

    public IRoleRepository Roles { get; }

    public IEmployeeRepository Employees { get; }

    public IEmployeePhoneRepository EmployeePhones { get; }

    public IClientRepository Clients { get; }

    public IClientPhoneRepository ClientPhones { get; }

    public IFinancialRepository Financials { get; }

    public ITasksRepository Tasks { get; }

    public IEmployeeRoleRepository EmployeeRoles { get; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}