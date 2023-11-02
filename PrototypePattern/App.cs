using PrototypePattern.Entities;

namespace PrototypePattern;

public abstract class App
{
    public static void Main(string[] args)
    {
        {
            Console.WriteLine(">> Performing Shallow Copy of objects...");
            Address address = new Address("Rua Urubici", "Itajai");
            Customer customer = new Customer("John Stamos", "11154328937", "johnstamos@gmail.com", address);
            Customer deepCopiedCustomer = customer.ShallowClone();
            Console.WriteLine(">> Using the clone from Prototype Pattern");
            Console.WriteLine("> Original: " + customer.ToString());
            Console.WriteLine("> Copied: " + deepCopiedCustomer.ToString());
            Console.WriteLine(">> Changing something in address... (checking shallow copy)");
            deepCopiedCustomer.Address.Street = "Rua Ituporanga";
            Console.WriteLine("> (2) Original: " + customer.ToString());
            Console.WriteLine("> (2) Copied: " + deepCopiedCustomer.ToString());
        }

        {
            Console.WriteLine(">> Performing Deep Copy of objects...");
            Address address = new Address("Rua Urubici", "Itajai");
            Customer customer = new Customer("John Stamos", "11154328937", "johnstamos@gmail.com", address);
            Customer deepCopiedCustomer = customer.Clone();
            Console.WriteLine(">> Using the clone from Prototype Pattern");
            Console.WriteLine("> Original: " + customer.ToString());
            Console.WriteLine("> Copied: " + deepCopiedCustomer.ToString());
            Console.WriteLine(">> Changing something in address... (checking deep copy)");
            deepCopiedCustomer.Address.Street = "Rua Ituporanga";
            Console.WriteLine("> (2) Original: " + customer.ToString());
            Console.WriteLine("> (2) Copied: " + deepCopiedCustomer.ToString());    
        }
        
    }
}