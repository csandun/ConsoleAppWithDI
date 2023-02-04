namespace ConsoleAppWithDI.Services;

public class CustomerService: ICustomerService
{
    public void CalculateCustomerAge(int id)
    {
        Console.WriteLine("CustomerService:CalculateCustomerAge runs");
    }
}