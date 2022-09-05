namespace AbstractFactoryDesignPattern;

public class ConcreteFactoryAlpha : IAbstractFactory
{
    public IAbstractProductAlpha CreateProductAlpha() =>
        new ConcreteProductAlpha1();

    public IAbstractProductBeta CreateProductBeta() =>
        new ConcreteProductBeta1();
}
