namespace ConsoleApp.Services;

public class PasswordCheckerService
{
    public static void Run()
    {
        Console.WriteLine("Şifreniz en az 8 karakterden oluşmalıdır.");
        Console.WriteLine("Şifrenizde en az bir büyük harf olmalıdır.");
        Console.WriteLine("Şifrenizde @, #, $, % karakterlerinden en az biri olmalıdır.");
        Console.WriteLine("Şifrenizi giriniz: ");
        string password = Console.ReadLine(); 
        if (password.Length >= 8 &&
            password.IndexOfAny(new char[] { '@', '#', '$', '%' }) != -1 &&
            password.Any(char.IsUpper))
        {
            Console.WriteLine("Şifreniz güçlü!");
        }
        else
        {
            Console.WriteLine("Şifreniz kriterleri karşılamıyor.");
        }
    }
}