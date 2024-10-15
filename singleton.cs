public class ThreadSafeSingleton
{
    // Private static instance of the class
    private static ThreadSafeSingleton instance = null;

    // Lock object for thread safety
    private static readonly object lockObject = new object();

    // Private constructor to prevent instantiation
    private ThreadSafeSingleton() {}

    // Public static method to get the singleton instance
    public static ThreadSafeSingleton GetInstanceUsingDoubleLocking()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }
            }
        }
        return instance;
    }
}
