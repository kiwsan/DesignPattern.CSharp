namespace FactoryPattern
{

    public abstract class Vehicle
    {

        protected int fuelLevel;

        public abstract void Refuel();

        public abstract int GetFuel() => 0;

        public abstract void Move();

    }
}