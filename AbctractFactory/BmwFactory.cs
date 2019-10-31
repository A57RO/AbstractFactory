namespace AbctractFactory
{
    public class Bmw : ICarFactory
    {
        public IBody createBody()
        {
            return new BmwBody();
        }

        public IEngine createEngine()
        {
            return new BmwEngine();
        }

        public IInterior createInterior()
        {
            return new BmwInterior();
        }

        public IWheels createWheels()
        {
            return new BmwWheels();
        }
    }

    public class BmwBody : IBody
    {
    }

    public class BmwEngine : IEngine
    {
    }

    public class BmwInterior : IInterior
    {
    }

    public class BmwWheels : IWheels
    {
    }
}