﻿using Order.Domain.Core.Bus;

namespace Order.Application.Api.Installers
{
    public class BusInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            //AddBus
            services.AddScoped<IMediatorHandler, InMemoryBus>();
        }
    }
}
