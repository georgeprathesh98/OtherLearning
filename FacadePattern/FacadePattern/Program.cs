using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade carFacade = new CarFacade();
            carFacade.CreateCar();
            Console.ReadLine();
        }
    }
}
