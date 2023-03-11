using BirthdayCelebrations.Core;
using BirthdayCelebrations.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
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
