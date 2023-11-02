namespace SingletonPattern;

public abstract class App
{
    public static void Main(string[] args)
    {
        {
            Connection conn = Connection.GetInstance(); // Here the object is created. "_instance" is null.
            Console.WriteLine(conn.ConnectionId);
            // Connection will return the "_instance" already created above. Singleton will always return the same instance of the object.
            Connection otherConn = Connection.GetInstance();
            Console.WriteLine(otherConn.ConnectionId);
        }
    }
}