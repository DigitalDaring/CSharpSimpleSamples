// A namespace is just a way to group together similar code and import it later into other files.
namespace carSamples {

    // An example of an interface.  Any class that implements this pinkie-swears to do burnouts.
    // Interfaces are always supposed to start with the letter "I".
    public interface IDoesSickBurnouts
    {
        // note that we don't declare ANY behavior in here, we just say what it could do...not how it does it.
        // you don't have to declare these as "public" because all interface methods are always public.
        string DoABurnout(); // do the burnout and tell us what sound it makes.
        float BlowUpTheTires(); // blowing up the tires costs money.  The tire price is returned when we blow them up as a "float".
    }

    // This is a base class / parent class.  (Same thing).  It outlines some basic "carness".
    // Because it is also "abstract" that means we can never create an object directly from it.
    // You can't make just a "car", you'll need to be a bit more specific about which type.
    public abstract class Car {
        // this is a property.  It stores stuff that belongs to any specific car.
        public string color;

        // This is a constructor.  You can tell because the name of the method (Car) is the same as the class (Car).
        public Car() {
            color = "red";
        }

        // This is a method.  It is "void" which means it doesnt return any info.  it just paints the car a new color.
        public void PaintCar(string newColor) {
            color = newColor;
        }

        // This is also a method.  It is of type "string" which means it returns some text.
        // because it is "virtual" it is designed to be overridden.
        public virtual string GoVroom() {
            return "vroom";
        }
    }

    // This is an inherited class.  You can see that it uses the ":" to say what it is a child of.  Children are always more
    // specific than their parents.
    class Camaro: Car {

        // This "overridden" version of the GoVroom method goes even vroomier.  
        // This is the most direct way to override a method, it replaces the virtual one underneath it.
        public override string GoVroom() {
            return "VROOM";
        }
    }

    // This is an even more specific inherited class.
    // it also has an interface so you can guarantee that it can do sick burnouts.
    class IROCZ: Camaro, IDoesSickBurnouts {
        private string vroomLevel = "VROOOOOOM";

        public IROCZ() {
            // The regular camaro uses the default car constructor, and results in red cars.
            // We want the IROCZ to have its own constructor that makes sure it always comes out white.
            color = "white";
        }

        // Once again we add even more vroom-ness.  But here's the crazy part, we tie that to a private property.
        // we will modify that private property so that someone else can upgrade the vroom.
        // here we use a different way of "overriding" a method (so you can see the other options).
        // by using the "new" keyword we override the child class's GoVroom by hiding it behind a newer version.
        public new string GoVroom() {
            return vroomLevel;
        }

        // Allow someone else to install a turbo charger and add more vroom plus some blow-off sound at the end.
        public void InstallTurboCharger() {
            vroomLevel = "VROOOOOOOOOM Pfffft";
        }

        // Methods declared in the interface (IDoesSickBurnouts) are written just like normal :-)
        public string DoABurnout()
        {
            return "SKKRREEEEEEEEEEEEE";
        }

        public float BlowUpTheTires()
        {
            return 500.25f; // return the price of new rear tires.  (500 dollars and 25 cents);
        }
    }
}