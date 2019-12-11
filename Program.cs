using System;
// import the namespace we created.
using carSamples;
using tripSamples;

namespace samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I bought a new Camaro!");
            var myCamaro = new Camaro();  // Instantiate an object from the Camaro class (which is a child of "Car")
            Console.WriteLine("It goes {0}", myCamaro.GoVroom());
            Console.WriteLine("It is the color {0}", myCamaro.color);

            var brothersIrocz = new IROCZ();  // instantiate an object from the IROCZ class (which is a child of Camaro)
            Console.WriteLine("When I was at the dealership, they tried to sell my brother an IROCZ with low miles.");
            Console.WriteLine("It went {0}", brothersIrocz.GoVroom());
            Console.WriteLine("And it was the color {0}", brothersIrocz.color);
            Console.WriteLine("My brother bought it, and he wanted to change the color.");

            var newPaintColor = "yellow";
            Console.WriteLine("So we painted it");
            brothersIrocz.PaintCar(newPaintColor);
            Console.WriteLine("And now it is {0}", brothersIrocz.color);

            Console.WriteLine("I told him it needed to be even faster, so we installed a turbo.");
            brothersIrocz.InstallTurboCharger();
            Console.WriteLine("And now it goes {0}", brothersIrocz.GoVroom());

            Console.WriteLine("But mine is still the color {0}", myCamaro.color);
            Console.WriteLine("And only goes {0}", myCamaro.GoVroom());

            Console.WriteLine("We decided to take my car on a road trip (it got better gas mileage).");
            var ourRoadtrip = new RoadTrip(myCamaro); // create a new RoadTrip and pass in ANY car.  Liskov subsitution example.  A Camaro is a Car.
            ourRoadtrip.AddDestination("Las Vegas");
            ourRoadtrip.AddDestination("Seattle");
            ourRoadtrip.AddDestination("Juno");

            Console.WriteLine("We marked off the cities on the map, bought some snacks, and drove off!");
            ourRoadtrip.Travel();

            Console.WriteLine("When we got home, we took my brother's IROCZ to the dragstrip to do burnouts in the parkinglot!");
            var dragstripTrip = new TripToDragStrip(brothersIrocz);
            Console.WriteLine("We decided to do 7 burnouts.  This is what happened:");
            for(var i = 0; i < 7; i++) {
                dragstripTrip.RockAndRoll();
            }

        }
    }
}
