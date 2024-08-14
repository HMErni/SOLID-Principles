namespace OpenClosedPrinciple;


public interface IEncryption
{
    string Encrypt(string data);
}

public class Encryption : IEncryption
{
    public string Type { get; set; } = string.Empty;

    public string Encrypt(string data)
    {
        if (Type == "AES")
        {
            // AES encryption logic
            return "AES Encrypted data";
        }
        else if (Type == "RSA")
        {
            // RSA encryption logic
            return "RSA Encrypted data";
        }
        else
        {
            throw new Exception("Encryption type not supported");
        }
    }
}


public class anotherEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "anotherEncryption Encrypted data";
    }
}

