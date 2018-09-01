using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var newThing = new Thing1();
            var newerThing = new Thing2();
            var newestThing = new Thing3();
            var evenNewer = new Thing4();

            newThing.FirstThing();
            newerThing.SecondThing();
            newestThing.ThirdThing();
            evenNewer.FourthThing();
            Console.ReadLine();
        }
    }
}