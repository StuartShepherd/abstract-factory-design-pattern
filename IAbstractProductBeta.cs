namespace AbstractFactoryDesignPattern;

public interface IAbstractProductBeta
{
    string UsefulFunctionBeta();

    string AnotherUsefulFunctionBeta(IAbstractProductAlpha collaborator);
}
