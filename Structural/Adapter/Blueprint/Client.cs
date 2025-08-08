namespace Adapter.Blueprint;

public class Client
{
    private readonly IService _service;

    public Client(IService service)
    {
        _service = service;
    }

    public void FooBar()
    {
        var data = new Data("Not so special");
        var response = _service.Method(data);

        Console.WriteLine($"My not so special name has a length of {response.Property}");
    }

}
