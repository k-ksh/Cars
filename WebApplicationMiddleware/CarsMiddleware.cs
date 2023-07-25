namespace WebApplicationMiddleware
{
    public interface IManagementCars
    {
        string GetCarName();
        string GetCarEngine();
        int GetCarAge();
    }

    public class Car : IManagementCars
    {
        private string carName;
        private string carEngine;
        private int carAge;

        public Car(string name, string engine, int age)
        {
            carName = name;
            carEngine = engine;
            carAge = age;
        }

        public string GetCarName()
        {
            return carName;
        }

        public string GetCarEngine()
        {
            return carEngine;
        }

        public int GetCarAge()
        {
            return carAge;
        }
    }
}
