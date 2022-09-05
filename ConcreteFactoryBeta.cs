namespace AbstractFactoryDesignPattern;

public class ConcreteFactoryBeta : IAbstractFactory
{
    public IAbstractProductAlpha CreateProductAlpha() =>
        new ConcreteProductAlpha2();

    public IAbstractProductBeta CreateProductBeta() =>
        new ConcreteProductBeta2();
}
