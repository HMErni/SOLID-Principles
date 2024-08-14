namespace OpenClosedPrinciple;


public interface IEncryption
{
    string Encrypt(string data);
}

public class RSAEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "RSA Encrypted data";
    }
}

public class AESEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "AES Encrypted data";
    }
}


public class anotherEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "anotherEncryption Encrypted data";
    }
}

