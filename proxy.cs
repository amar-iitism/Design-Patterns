// Step 1: Define the Subject Interface

public interface IImage
{
    void Display();
}

// Step 2: Create Real Subject Class
public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading {_fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_fileName}");
    }
}

// Step 3: Create Proxy Class
public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display();
    }
}

// Step 4: Client Code
class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("image1.jpg");
        IImage image2 = new ProxyImage("image2.jpg");

        // Image will be loaded from disk and displayed
        image1.Display();
        
        // Image will be displayed without loading from disk again
        image1.Display();
        
        // Image will be loaded from disk and displayed
        image2.Display();
    }
}



