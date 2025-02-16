namespace ConsoleApp.Services;

public class SignCheckerService
{
    public static void Run()
    {
        Console.WriteLine("İşaretini öğrenmek istediğiniz sayıyı giriniz: ");
        long number = Convert.ToInt64(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Girdiğiniz Sayı Pozitif.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Girdiğiniz Sayı Negatif.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz Sayı Sıfır.");
        }
    }
}