using core.Application.Interfaces;
using core.Application.Interfaces.Repositories;
using core.Infrastructure.Persistence;
using core.Infrastructure.Repositories;
using core.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace core.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IEmployeePhoneRepository, EmployeePhoneRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IClientPhoneRepository, ClientPhoneRepository>();
        services.AddScoped<IFinancialRepository, FinancialRepository>();
        services.AddScoped<ITasksRepository, TasksRepository>();
        services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();
        services.AddScoped<IUnitOfWork, global::core.Infrastructure.UnitOfWork.UnitOfWork>();

        return services;
    }
}