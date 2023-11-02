namespace SingletonPattern;

public class Connection
{
    
    public Guid ConnectionId { get; set; }
    private static Connection _instance;
    private Connection() { }

    public static Connection GetInstance()
    {
        if (_instance is null)
        {
            _instance = new Connection();
            _instance.ConnectionId = Guid.NewGuid();
        }
        return _instance;
    }
    
}