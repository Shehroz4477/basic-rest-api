using basic_rest_api.Interfaces;

namespace basic_rest_api.Services;
public class SingletonService : ISingletonService 
{ 
    private readonly Guid _serviceId; 
    private readonly DateTime _createdAt; 
    // private readonly IScopedService _scopedService;
    // private readonly ITransientService _transientService;
    public SingletonService() 
    { 
        // IScopedService scopedService, ITransientService transientService
        _serviceId = Guid.NewGuid(); 
        _createdAt = DateTime.Now;
        // _scopedService = scopedService;
        // _transientService = transientService; 
    } 
    public string Name => nameof(SingletonService); 
    public string SayHello() 
    { 
        return $"Hello! I am {Name}. My Id is {_serviceId}. I was created at {_createdAt:yyyy-MM-dd HH:mm:ss}."; 
        // var line = "================================================================================================";
        // var singletonServiceMessage = $"Hello! I am {Name}. My Id is {_serviceId}. I was created at {_createdAt:yyyy-MM-dd HH:mm:ss}."; 
        // var transientServiceMessage = $"{_transientService.SayHello()} I am from {Name}."; 
        // var scopedServiceMessage = $"{_scopedService.SayHello()} I am from {Name}."; 
        // return $"{line}{Environment.NewLine}{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{singletonServiceMessage}{Environment.NewLine}{line}"; 
    } 
}