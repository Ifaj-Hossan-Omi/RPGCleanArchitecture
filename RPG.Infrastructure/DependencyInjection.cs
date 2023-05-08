using Microsoft.Extensions.DependencyInjection;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Application.Service;
using RPG.Infrastructure.Repository;

namespace RPG.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICharacterRepository, CharacterRepository>();

        return services;
    }
}