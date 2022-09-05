namespace AbstractFactoryDesignPattern;

public class ConcreteProductBeta2 : IAbstractProductBeta
{
    public string UsefulFunctionBeta() =>
        "The result of the product Beta2.";

    public string AnotherUsefulFunctionBeta(IAbstractProductAlpha collaborator)
    {
        var result = collaborator.UsefulFunctionAlpha();

        return $"The result of the Beta2 collaborating with the ({result})";
    }
}
