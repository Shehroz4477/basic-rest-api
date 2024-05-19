using basic_rest_api.Interfaces;

namespace basic_rest_api.Services;
public class TransientService : ITransientService
{
    private readonly Guid _serviceId;
    private readonly DateTime _createdAt;
    private readonly IScopedService _scopedService;
    private readonly ISingletonService _singletonService;
    public TransientService(IScopedService scopedService, ISingletonService singletonService)
    {
        _serviceId = Guid.NewGuid();
        _createdAt = DateTime.Now;
        _scopedService = scopedService;
        _singletonService = singletonService;
    }
    public string Name => nameof(TransientService);
    public string SayHello()
    {
        // return $"Hello! I am {Name}. My Id is {_serviceId}. I was created at {_createdAt:yyyy-MM-dd HH:mm:ss}.";
        var line = "================================================================================================";
        var transientServiceMessage = $"Hello! I am {Name}. My Id is {_serviceId}. I was created at {_createdAt:yyyy-MM-dd HH:mm:ss}."; 
        var scopedServiceMessage = $"{_scopedService.SayHello()} I am from {Name}."; 
        var singletonServiceMessage = $"{_singletonService.SayHello()} I am from {Name}."; 
        return $"{line}{Environment.NewLine}{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{singletonServiceMessage}{Environment.NewLine}{line}"; 
    }
}