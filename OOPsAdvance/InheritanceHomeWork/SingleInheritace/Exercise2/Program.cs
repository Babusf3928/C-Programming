using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        AccountInfo account1 = new AccountInfo("Babu","Periyasamy",9894007401,"babu20010704@gmail.com",new DateTime(2001,04,07),Gender.Male,"HDFC","SBHDFC3534543",0);
        account1.AccountDetails();
    }
}