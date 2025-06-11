using Microsoft.Extensions.DependencyInjection;
using NextGenGamingStore.DL.Interfaces;
using NextGenGamingStore.DL.Repositories;
using NextGenGamingStore.DL.Repositories.MongoDb;
using NextGenGamingStore.DL.Cache;
using NextGenGamingStore.DL.Kafka.KafkaCache;
using NextGenGamingStore.DL.Kafka;
using NextGenGamingStore.Models.Configurations.CachePopulator;
using NextGenGamingStore.Models.DTO;
using Microsoft.Extensions.Configuration;
using MovieStoreB.DL.Cache;
using NextGenGamingStore.DL.Gateways;
using Microsoft.AspNetCore.DataProtection.KeyManagement;


namespace NextGenGamingStore.DL
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddDataDependencies(
                this IServiceCollection services)
        {
            services.AddSingleton<IGameRepository, GamesRepository>();
            services.AddSingleton<IPublisherRepository, PublisherMongoRepository>();
            services.AddSingleton<IPublisherBioGateway, PublisherBioGateway>();


            return services;
        }


        //
    }
}
