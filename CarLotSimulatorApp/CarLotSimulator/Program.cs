using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var CarLot = new CarLot();

            //TODO

            //Create a seperate class file called Car--DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable --DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()--DONE
            //The methods should take one string parameter: the respective noise property--DONE


            //Now that the Car class is created we can instanciate 3 new cars--DONE
            //Set the properties for each of the cars--DONE
            //Call each of the methods for each car--DONE


            var CarOne = new Car();
            CarOne.Model =  "El Camino";
            CarOne.Make = "Chevy";
            CarOne.Year = 1958;
            CarOne.IsDrivable = true;
            CarOne.EngineNoise = "Vroom Vroooooooom";
            //CarOne.MakeEngineNoise();
            CarOne.HonkNoise = "beep beep";
            //CarOne.MakeHonkNoise();
            CarLot.ListOfCars.Add(CarOne);

            var CarTwo = new Car()
            {
                Model = "L96 Wienermobile",
                Make = "Chevrolet",
                Year = 1936,
                IsDrivable = true,
                EngineNoise = "grumble grumble",
                HonkNoise = "beeeeeeeep",
        };
            //CarTwo.MakeEngineNoise();
            //CarTwo.MakeHonkNoise();
            CarLot.ListOfCars.Add(CarTwo);






            var CarThree = new Car() { Model = "Fleetwood 75", Make = "Cadillac", Year = 1973 , IsDrivable = false, EngineNoise = "bang!..click...click", HonkNoise = "beep" };
            //CarThree.Model = "Fleetwood 75";
            //CarThree.Make = "Cadillac";
            //CarThree.Year = 1973;
            //CarThree.IsDrivable = false;
            //CarThree.EngineNoise = "bang!..click...click";
            //CarThree.MakeEngineNoise();
            //// CarThree.HonkNoise = "beep";
            //CarThree.MakeHonkNoise();
            CarLot.ListOfCars.Add(CarThree);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car--DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach (var car in CarLot.ListOfCars)
            {
                Console.WriteLine($"We have this car a {car.Year} {car.Make} {car.Model}, Here we turned it on the engine sounds like {car.EngineNoise}... I will even show you the horn {car.HonkNoise}");
                Console.WriteLine("");
            }



            

           

        }
    }
}
