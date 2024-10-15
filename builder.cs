// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Computer
{
    public string CPU {get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GPU { get; set; }

    public override string ToString()
    {
        return $"Computer Specifications:\nCPU: {CPU}\nRAM: {RAM}\nStorage: {Storage}\nGPU: {GPU}";
    }
}


public interface IComputerBuilder
{
    void SetCPU();
    void SetRAM();
    void SetStorage();
    void SetGPU();
    Computer GetComputer();
}


public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer;
    
    public GamingComputerBuilder()
    {
        _computer = new Computer();
    }
    
    public void SetCPU()
    {
        _computer.CPU = "Intel i9";
    }

    public void SetRAM()
    {
        _computer.RAM = "32GB";
    }

    public void SetStorage()
    {
        _computer.Storage = "1TB SSD";
    }

    public void SetGPU()
    {
        _computer.GPU = "NVIDIA RTX 3080";
    }
    public Computer GetComputer()
    {
        return _computer;
    }
}



public class ComputerBuilder
{
    private IComputerBuilder _computerBuilder;
    
    
    public ComputerBuilder(IComputerBuilder builder)
    {
        _computerBuilder = builder;
    }
    
    public void BuildComputer()
    {
        _computerBuilder.SetCPU();
        _computerBuilder.SetRAM();
        _computerBuilder.SetStorage();
        _computerBuilder.SetGPU();
    }
    
    public Computer GetComputer()
    {
        return _computerBuilder.GetComputer();
    }
    
}


public class Program
{
     static void Main(string[] args)
     {
         IComputerBuilder gamingBuilder = new GamingComputerBuilder();
         ComputerBuilder director = new ComputerBuilder(gamingBuilder);
         
         director.BuildComputer();
         Computer gamingComputer = director.GetComputer();
         
         Console.WriteLine(gamingComputer);
     }
}
