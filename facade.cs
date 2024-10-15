public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV is now ON.");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is now OFF.");
    }
}

public class SoundSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Sound System is now ON.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Sound System is now OFF.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Sound System volume set to {level}.");
    }
}

public class StreamingService
{
    public void StartStreaming(string movie)
    {
        Console.WriteLine($"Starting to stream '{movie}'.");
    }

    public void StopStreaming()
    {
        Console.WriteLine("Stopped streaming.");
    }
}

public class HomeTheaterFacade
{
    private readonly TV _tv;
    private readonly SoundSystem _soundSystem;
    private readonly StreamingService _streamingService;

    public HomeTheaterFacade(TV tv, SoundSystem soundSystem, StreamingService streamingService)
    {
        _tv = tv;
        _soundSystem = soundSystem;
        _streamingService = streamingService;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _tv.TurnOn();
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(10);
        _streamingService.StartStreaming(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        _streamingService.StopStreaming();
        _soundSystem.TurnOff();
        _tv.TurnOff();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the subsystem components
        TV tv = new TV();
        SoundSystem soundSystem = new SoundSystem();
        StreamingService streamingService = new StreamingService();

        // Create a facade for the home theater
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, streamingService);

        // Use the facade to watch a movie
        homeTheater.WatchMovie("Inception");

        // End the movie
        homeTheater.EndMovie();
    }
}
