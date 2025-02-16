namespace ConsoleApp.Services;

public class LargestNumberService
{
    public static void Run()
    {
        Console.WriteLine("Birinci Sayıyı Giriniz: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Üçüncü Sayıyı Giriniz: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("En büyük sayı: " + number1);
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine("En büyük sayı: " + number2);
        }
        else
        {
            Console.WriteLine("En büyük sayı: " + number3);
        }
    }
}