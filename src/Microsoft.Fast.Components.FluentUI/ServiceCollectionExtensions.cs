﻿using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Fast.Components.FluentUI;

public static class ServiceCollectionExtensions
{
    public static void AddFluentUIComponents(this IServiceCollection services)
    {
        services.AddScoped<IconService>();
    }
}