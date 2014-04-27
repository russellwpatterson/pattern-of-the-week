public sealed class Singleton
{
    // Private constructor so that other classes can't instantiate it.
    private Singleton()
    {
    }

    // Object to ensure that there aren't multiple instantiations going on.
    private static readonly object LockObj = new object();

    // Backing store variable for the current instance.
    private static Singleton _instance;

    // Public property to access the instance.
    public static Singleton Instance
    {
        get
        {
            lock (LockObj)
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }

    // Some property to use.
    public string SomeProperty { get; set; }
}

