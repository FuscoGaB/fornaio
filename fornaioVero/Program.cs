using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fornaioVero
{
    internal class Program
    {
        static int customersDisplay = 1;
        static int customersTicket = 1;
        static int customersCount = 0;
        static void Main(string[] args)
        {
            Thread[] customers = new Thread[10];
            
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Thread(Customer);
                customers[i].Start();
            }

            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].Join();
            }

            Console.WriteLine("Clienti finiti.");
        }

        static void Customer()
        {
            int personalTicket = customersTicket++;

            while(personalTicket != customersDisplay)
            {
                Thread.Sleep(3000);
            }

            while (true)
            {
                if (customersCount < 2)
                {

                }
            }
        }
    }
}
