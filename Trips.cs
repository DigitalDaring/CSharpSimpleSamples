using carSamples;
using System; // Using "System" lets us write to the console.
using System.Collections.Generic; // Generic collections lets us use lists which are just like...well...lists of stuff

namespace tripSamples {
    public class RoadTrip {
        private Car whatWeWillDrive;
        private List<string> destinations;
        public RoadTrip(Car ourWhip) {
            whatWeWillDrive = ourWhip;
            destinations = new List<string>();
        }

        public void AddDestination(string name) {
            destinations.Add(name);
        }

        public void Travel() {
            // this is a "foreach".  You can also write a "for" loop.
            destinations.ForEach(destination => {
                Console.WriteLine("We went to: {0}, and the car went {1}!", destination, whatWeWillDrive.GoVroom());
            });

            // for loop (commented out, cuz we only need to run one type of loop).
            // for (var i = 0; i < destinations.Count; i++) {
            //     var nextDestination = destinations[i];
            //     Console.WriteLine("We went to: {0}, and the car went {1}!", destination, whatWeWillDrive.GoVroom());
            // }
        }
        
    }

    public class TripToDragStrip {
        private int numberOfSickBurnoutsYouDid = 0;
        private IDoesSickBurnouts whatYoureDriving;

        public TripToDragStrip(IDoesSickBurnouts ourWhip) {
            whatYoureDriving = ourWhip;
        }

        public void RockAndRoll() {
            if(numberOfSickBurnoutsYouDid > 3) {
                // when using "string interpolation", you can do :C to display a number (in this case a float) as local currency.
                Console.WriteLine("You burned those tires up!  That'll be {0:C}", whatYoureDriving.BlowUpTheTires());
                numberOfSickBurnoutsYouDid = 0;
            } else {
                Console.WriteLine("Your tires go {0}", whatYoureDriving.DoABurnout());
                // writing "++" is shorthand for numberOfSickBurnoutsYouDid = numberOfSickBurnoutsYouDid + 1;
                numberOfSickBurnoutsYouDid ++;           
            }
        }
    }
}