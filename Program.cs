using System;
using System.Collections.Generic;

namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 2;
            List<ISwitchable> devices = new List<ISwitchable>();
            Electronic microwave = new Microwave();
            Electronic washer = new Washer();
            devices.Add(new Microwave());
            devices.Add(new Music());
            devices.Add(new Washer());

            Console.WriteLine("Turn on devices");
            Console.ReadLine();
            foreach (ISwitchable device in devices)
            {
                device.SwitchOn();
            }
            Console.WriteLine("\nTurn off devices");
            Console.ReadLine();
            foreach (ISwitchable device in devices)
            {
                device.SwitchOff();
            }
            Console.WriteLine("\ncost off device");
            Console.ReadLine();
            microwave.ElConsumed(1.75f, cost);

            Console.WriteLine("\ncost off device");
            Console.ReadLine();
            washer.ElConsumed(2.15f, cost);

            Console.ReadKey();
        }
    }

    interface ISwitchable
    {
        void SwitchOn();
        void SwitchOff();
    }

    public abstract class Electronic
    {     
        protected float ElConsuming;

        public void ElConsumed(float power, int cost)
        {
            ElConsuming = cost * power;
            Console.WriteLine($"\n{GetType()} {ElConsuming}");
        }
    }

    public class Microwave : Electronic, ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Microwave is on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Microwave is off");
        }     
    }

    public class Music : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Music is on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Music is off");
        }
    }

    public class Washer : Electronic, ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Washer is on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Washer is off");
        }
    }
}
