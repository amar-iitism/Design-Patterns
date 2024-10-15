using System;

namespace DesignPatternExample
{
    // Interface IComputer
    public interface IComputer
    {
        string GetRAM();
        string GetHDD();
        string GetCPU();
    }

    // PC class implements IComputer interface
    public class PC : IComputer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public string GetRAM()
        {
            return this.ram;
        }

        public string GetHDD()
        {
            return this.hdd;
        }

        public string GetCPU()
        {
            return this.cpu;
        }

        public override string ToString()
        {
            return $"RAM= {this.GetRAM()}, HDD= {this.GetHDD()}, CPU= {this.GetCPU()}";
        }
    }

    // Server class implements IComputer interface
    public class Server : IComputer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public string GetRAM()
        {
            return this.ram;
        }

        public string GetHDD()
        {
            return this.hdd;
        }

        public string GetCPU()
        {
            return this.cpu;
        }

        public override string ToString()
        {
            return $"RAM= {this.GetRAM()}, HDD= {this.GetHDD()}, CPU= {this.GetCPU()}";
        }
    }

    // Factory class for creating IComputer objects
    public static class ComputerFactory
    {
        public static IComputer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if (type.Equals("PC", StringComparison.OrdinalIgnoreCase))
                return new PC(ram, hdd, cpu);
            else if (type.Equals("Server", StringComparison.OrdinalIgnoreCase))
                return new Server(ram, hdd, cpu);

            return null;
        }
    }

    // Test class to demonstrate the Factory Pattern
    class Program
    {
        static void Main(string[] args)
        {
            // Create a PC using the factory
            IComputer pc = ComputerFactory.GetComputer("PC", "16 GB", "1 TB", "Intel i7");
            Console.WriteLine("PC Config: " + pc);

            // Create a Server using the factory
            IComputer server = ComputerFactory.GetComputer("Server", "32 GB", "2 TB", "AMD Ryzen 9");
            Console.WriteLine("Server Config: " + server);
        }
    }
}
