﻿using Adnc.Shared.Application.Registrar;
using Adnc.Shared.Rpc.Http.Services;

namespace Adnc.Demo.Ord.Application;

public sealed class OrdApplicationDependencyRegistrar : AbstractApplicationDependencyRegistrar
{
    public override Assembly ApplicationLayerAssembly => Assembly.GetExecutingAssembly();

    public override Assembly ContractsLayerAssembly => typeof(IOrderAppService).Assembly;

    public override Assembly RepositoryOrDomainLayerAssembly => typeof(EntityInfo).Assembly;

    public OrdApplicationDependencyRegistrar(IServiceCollection services) : base(services)
    {
    }

    public override void AddAdnc()
    {
        AddApplicaitonDefault();
        AddDomainSerivces<IDomainService>();

        //rpc-rest
        var restPolicies = PollyStrategyEnable ? this.GenerateDefaultRefitPolicies() : new();
        AddRestClient<IAuthRestClient>(ServiceAddressConsts.UsrService, restPolicies);
        AddRestClient<IUsrRestClient>(ServiceAddressConsts.UsrService, restPolicies);
        AddRestClient<IMaintRestClient>(ServiceAddressConsts.MaintService, restPolicies);
        AddRestClient<IWhseRestClient>(ServiceAddressConsts.WhseService, restPolicies);
        //rpc-event
        AddCapEventBus<CapEventSubscriber>();
    }
}