namespace OpenClosedPrinciple;

public class Program
{
    public static void Main()
    {

        var Encryption = new Encryption();
        Encryption.Type = "AES";
        Console.WriteLine(Encryption.Encrypt("AES"));

        var anotherEncryption = new anotherEncryption();
        Console.WriteLine(anotherEncryption.Encrypt("Hello World"));

    }
}