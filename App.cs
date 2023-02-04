using ConsoleAppWithDI.Services;

namespace ConsoleAppWithDI;

public class App
{
    private readonly ICustomerService _customerService;
    
    public App(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    public void Run(string[] args)
    {
        _customerService.CalculateCustomerAge(1);
    }
}