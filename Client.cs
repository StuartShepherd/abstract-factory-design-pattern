namespace AbstractFactoryDesignPattern;

public class Client
{
    public void Main()
    {
        Console.WriteLine("Client: Testing Alpha");
        ClientMethod(new ConcreteFactoryAlpha());
        Console.WriteLine();

        Console.WriteLine("Client: Testing Beta");
        ClientMethod(new ConcreteFactoryBeta());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productAlpha = factory.CreateProductAlpha();
        var productBeta = factory.CreateProductBeta();

        Console.WriteLine(productBeta.UsefulFunctionBeta());
        Console.WriteLine(productBeta.AnotherUsefulFunctionBeta(productAlpha));
    }
}
