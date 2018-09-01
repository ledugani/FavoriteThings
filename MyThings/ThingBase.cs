using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class ThingBase
    {
        private readonly string _whichThing;

        public string Thing { get; private set; }

        public ThingBase(string whichThing)
        {
            _whichThing = whichThing;
        }

        public void GetThing()
        {
            Console.WriteLine("");
            Thing = Console.ReadLine();
        }
    }
}
