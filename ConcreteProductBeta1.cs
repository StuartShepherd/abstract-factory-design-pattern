namespace AbstractFactoryDesignPattern;

public class ConcreteProductBeta1 : IAbstractProductBeta
{
    public string UsefulFunctionBeta() =>
        "The result of the product Beta1.";

    public string AnotherUsefulFunctionBeta(IAbstractProductAlpha collaborator)
    {
        var result = collaborator.UsefulFunctionAlpha();

        return $"The result of the Beta1 collaborating with the ({result})";
    }
}
