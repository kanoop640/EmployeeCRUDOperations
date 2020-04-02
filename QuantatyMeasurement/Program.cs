using System;

namespace QuantatyMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FeetIntoInches ab = new FeetIntoInches();
            Feet ft = new Feet(2);
            var val=ab.FeetToInchConverter(ft);
            Console.WriteLine(val.GetValue());
        }
    }
}
