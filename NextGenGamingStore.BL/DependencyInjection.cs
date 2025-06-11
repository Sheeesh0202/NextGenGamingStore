using NextGenGamingStore.BL.Interfaces;
using NextGenGamingStore.BL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenGamingStore.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IGameService, GameService>();
            services.AddSingleton<IPublisherService, PublisherService>();
            return services;
        }
    }
}
