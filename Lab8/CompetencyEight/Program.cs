using System;

namespace MyNamespace
{
    //Add name, Course number, and CRN as a single line comment or multi-line comment at the beginning of the code.
    // Cornell Burts, IT 1050, 86411

    class Furniture //Given class Furniture with method FurnitureDetail( ) that outputs "The furniture is made of wood."
    {
        public virtual void FurnitureDetail()
        {
            Console.WriteLine("The furniture is made of wood");
        }
    }
    class Dresser : Furniture // Create a derived (child) class called Dresser. Add a method called FurnitureDetail( ) that outputs: "The dresser is made from cherry wood."
    {
        public override void FurnitureDetail()
        {
            Console.WriteLine("The dresser is made from cherry wood.");
        }
    }

    class Desk : Furniture //Create a derived (child) class called Desk. Add a method called FurnitureDetail( ) that outputs: "The desk is made from oak wood."
    {
        public override void FurnitureDetail()
        {
            Console.WriteLine("The desk is made from oak wood.");
        }
    }

    class Bed : Furniture //Create a derived (child) class called Bed. Add a method called FurnitureDetail( ) that outputs: "The bed is made from walnut wood."
    {
        public override void FurnitureDetail()
        {
            Console.WriteLine("The bed is made from walnut wood");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Furniture myDresser = new Dresser(); //Create an object of type Dresser.
            Furniture myDesk = new Desk(); //Create an object of type Desk.
            Furniture myBed = new Bed(); //Create an object of type Bed.

            myDresser.FurnitureDetail(); // Call its FurnitureDetail( ) method.
            myDesk.FurnitureDetail(); // Call its FurnitureDetail( ) method.
            myBed.FurnitureDetail(); // Call its FurnitureDetail() method.
        }
    }
}
