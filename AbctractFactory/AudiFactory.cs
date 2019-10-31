namespace AbctractFactory
{
    public class Audi : ICarFactory
    {
        public IBody createBody()
        {
            return new AudiBody();
        }

        public IEngine createEngine()
        {
            return new AudiEngine();
        }

        public IInterior createInterior()
        {
            return new AudiInterior();
        }

        public IWheels createWheels()
        {
            return new AudiWheels();
        }
    }

    public class AudiBody : IBody
    {
    }

    public class AudiEngine : IEngine
    {
    }

    public class AudiInterior : IInterior
    {
    }

    public class AudiWheels : IWheels
    {
    }
}