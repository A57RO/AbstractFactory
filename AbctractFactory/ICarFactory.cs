namespace AbctractFactory
{
    public interface ICarFactory
    {
        IBody createBody();
        IEngine createEngine();
        IInterior createInterior();
        IWheels createWheels();
    }
}