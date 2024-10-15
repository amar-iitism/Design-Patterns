namespace Design.Builder
{
    public class Computer
    {
        // Required parameters
        private string HDD;
        private string RAM;

        // Optional parameters
        private bool isGraphicsCardEnabled;
        private bool isBluetoothEnabled;

        // Private constructor (only accessible by the builder)
        private Computer(ComputerBuilder builder)
        {
            this.HDD = builder.HDD;
            this.RAM = builder.RAM;
            this.isGraphicsCardEnabled = builder.IsGraphicsCardEnabled;
            this.isBluetoothEnabled = builder.IsBluetoothEnabled;
        }

        // Getters for the fields
        public string GetHDD()
        {
            return HDD;
        }

        public string GetRAM()
        {
            return RAM;
        }

        public bool IsGraphicsCardEnabled()
        {
            return isGraphicsCardEnabled;
        }

        public bool IsBluetoothEnabled()
        {
            return isBluetoothEnabled;
        }

        // Nested Builder Class
        public class ComputerBuilder
        {
            // Required parameters
            public string HDD { get; }
            public string RAM { get; }

            // Optional parameters - initialized to default values
            public bool IsGraphicsCardEnabled { get; private set; }
            public bool IsBluetoothEnabled { get; private set; }

            // Constructor for required parameters
            public ComputerBuilder(string hdd, string ram)
            {
                this.HDD = hdd;
                this.RAM = ram;
            }

            // Setter methods for optional parameters
            public ComputerBuilder SetGraphicsCardEnabled(bool isGraphicsCardEnabled)
            {
                this.IsGraphicsCardEnabled = isGraphicsCardEnabled;
                return this;
            }

            public ComputerBuilder SetBluetoothEnabled(bool isBluetoothEnabled)
            {
                this.IsBluetoothEnabled = isBluetoothEnabled;
                return this;
            }

            // Build method to create the final Computer object
            public Computer Build()
            {
                return new Computer(this);
            }
        }
    }
    class TestBuilderPattern
    {
        static void Main(string[] args)
        {
            // Using the builder to get the object in a single line of code
            Computer comp = new Computer.ComputerBuilder("500 GB", "2 GB")
                                    .SetBluetoothEnabled(true)
                                    .SetGraphicsCardEnabled(true)
                                    .Build();

            // Output to verify the object construction
            Console.WriteLine("HDD: " + comp.GetHDD());
            Console.WriteLine("RAM: " + comp.GetRAM());
            Console.WriteLine("Graphics Card Enabled: " + comp.IsGraphicsCardEnabled());
            Console.WriteLine("Bluetooth Enabled: " + comp.IsBluetoothEnabled());
        }
    }
}
