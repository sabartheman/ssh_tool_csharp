using System;

namespace Simple_Inventory
{
    class Program
    {


        static void Main(string[] args)
        {
            Tunnel tun;

            tun = new Tunnel();


            if (tun.connect())
            {
                Console.WriteLine("Connected to SSH Tunnel.");
            }
            else
            {
                Console.WriteLine("Could not connect to ssh tunnel");
            }

            Console.WriteLine("Waiting for keypress");
            Console.ReadKey();


        }
    }
}
