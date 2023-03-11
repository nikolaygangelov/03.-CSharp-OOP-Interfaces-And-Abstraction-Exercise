using FoodShortage.Core;
using FoodShortage.Core.InterFaces;
using System;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
