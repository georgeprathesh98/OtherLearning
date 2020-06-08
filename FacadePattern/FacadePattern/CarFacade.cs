using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class CarFacade
    {
        CarEngine CarEngine;
        CarModel CarModel;

        public CarFacade()
        {
            CarEngine = new CarEngine();
            CarModel  = new CarModel();
        }

        public void CreateCar()
        {
            Console.WriteLine("Start Creating Car..");
            CarEngine.SetEngine();
            CarModel.SetModel();
            Console.WriteLine("Car Created..");
        }

    }
}
