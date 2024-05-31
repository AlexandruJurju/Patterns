namespace Singleton;

// This Singleton implementation is called "double check lock". It is safe in multithreaded environment and provides lazy initialization for the Singleton object

public sealed class ThreadSafeSingleton
{
    // Use this lock object to synchronize threads during access to the singleton
    private static readonly object Lock = new object();

    private static ThreadSafeSingleton _instance;

    private ThreadSafeSingleton()
    {
    }

    public static ThreadSafeSingleton GetInstance()
    {
        // This conditional is needed to prevent threads stumbling over the lock once the instance is ready

        if (_instance == null)
        {
            // When the program has been launched there is no Singleton instance yet. Multiple threads can pass the previous condition to reach this point at the same time
            // The first of them will acquire the lock and will proceed further, while the rest will wait here
            lock (Lock)
            {
                // The first thread to acquire the lock, reaches this conditional, goes inside and creates the Singleton instance
                // Once it leaves the lock block, a thread that might have been waiting for the lock release may then enter this section. But since the Singleton field is
                // already initialized, the thread won't create a new object
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
            }
        }

        return _instance;
    }
}