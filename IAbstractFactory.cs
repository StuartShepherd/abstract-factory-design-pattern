namespace AbstractFactoryDesignPattern;

public interface IAbstractFactory
{
    IAbstractProductAlpha CreateProductAlpha();

    IAbstractProductBeta CreateProductBeta();
}
