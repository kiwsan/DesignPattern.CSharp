namespace FactoryPattern.Example1.Abstracts
{

    public abstract class Vehicle
    {

        protected int fuelLevel;

        public abstract void Refuel();

        public abstract int GetFuel();

        public abstract void Move();

    }
}