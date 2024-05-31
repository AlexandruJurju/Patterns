namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        NaiveSingleton singleton = NaiveSingleton.GetInstance();
        NaiveSingleton singleton2 = NaiveSingleton.GetInstance();

        if (singleton == singleton2)
        {
            Console.WriteLine("YES");
        }

    }
}