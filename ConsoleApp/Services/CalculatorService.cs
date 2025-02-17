namespace ConsoleApp.Services;

public class CalculatorService
{
    public static void Run()
    {
        Console.WriteLine("İlk sayıyı giriniz: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı giriniz: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+,-,/,x): ");
        char operation = Convert.ToChar(Console.ReadLine().ToLower());
        
        switch (operation)
        {
            case '+':
                Console.WriteLine("Toplam: " + (number1 + number2));
                break;
            case '-':
                Console.WriteLine("Fark: " + (number1 - number2));
                break;
            case '/':
                Console.WriteLine("Bölüm: " + (number1 / number2));
                break;
            case 'x':
                Console.WriteLine("Çarpım: " + (number1 * number2));
                break;
            default:
                Console.WriteLine("Geçersiz işlem türü seçildi.");
                break;
        }
    }
}