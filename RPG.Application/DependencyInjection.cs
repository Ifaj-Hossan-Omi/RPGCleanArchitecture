using Microsoft.Extensions.DependencyInjection;
using RPG.Application.Abstraction.Service;
using RPG.Application.Service;

namespace RPG.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICharacterService, CharacterService>();
        services.AddScoped<IFightService, FightService>();

        return services;
    }
}