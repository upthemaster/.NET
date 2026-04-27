using BillingSystem.Application.Interfaces;
using BillingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BillingSystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<BillingDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)), 
            ServiceLifetime.Scoped);

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<BillingDbContext>());

        return services;
    }
}
