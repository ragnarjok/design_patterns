namespace AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract Animal CreateBird();
        public abstract Animal CreateFish();
        public abstract Animal CreateMammal();
    }

    public abstract class Animal
    {
    }

    public class AfricanAnimalFactory : AnimalFactory
    {
        public override Animal CreateFish()
        {
            return new Reedfish();
        }

        public override Animal CreateBird()
        {
            return new Flamingo();
        }

        public override Animal CreateMammal()
        {
            return new Lion();
        }
    }

    public class Lion : Animal
    {
    }

    public class Flamingo : Animal
    {
    }

    public class Reedfish : Animal
    {
    }
}
