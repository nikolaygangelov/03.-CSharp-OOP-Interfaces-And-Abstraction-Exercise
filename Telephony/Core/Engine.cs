using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Core.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<string> contactNumbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            IPhone iphone; ;
            foreach (string number in contactNumbers)
            {
                if (number.Length == 7)
                {
                    iphone = new StationaryPhone();
                }
                else
                {
                    iphone = new Smartphone();
                }

                try
                {
                    Console.WriteLine(iphone.CallNumbers(number));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

            List<string> websites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            IWeb iWeb = new Smartphone();
            foreach (string site in websites)
            {
                try
                {

                    Console.WriteLine(iWeb.Browse(site));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}
