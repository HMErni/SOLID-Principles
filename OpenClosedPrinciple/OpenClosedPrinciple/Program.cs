namespace OpenClosedPrinciple;

public class Program
{
    public static void Main()
    {

        var RSAEncryption = new RSAEncryption();
        Console.WriteLine(RSAEncryption.Encrypt("Hello World"));

        var AESEncryption = new AESEncryption();
        Console.WriteLine(AESEncryption.Encrypt("Hello World"));

        var anotherEncryption = new anotherEncryption();
        Console.WriteLine(anotherEncryption.Encrypt("Hello World"));

    }
}