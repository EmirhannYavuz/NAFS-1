namespace ConsoleApp.Services;

public class DayNameService
{
    public static void Run()
    {
        Console.WriteLine("Haftanın kaçıncı günü olduğunu giriniz (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Bugün günlerden Pazartesi");
                break;
            case 2:
                Console.WriteLine("Bugün günlerden Salı");
                break;
            case 3:
                Console.WriteLine("Bugün günlerden Çarşamba");
                break;
            case 4:
                Console.WriteLine("Bugün günlerden Perşembe");
                break;
            case 5:
                Console.WriteLine("Bugün günlerden Cuma");
                break;
            case 6:
                Console.WriteLine("Bugün günlerden Cumartesi");
                break;
            case 7:
                Console.WriteLine("Bugün günlerden Pazar");
                break;
            default:
                Console.WriteLine("Hatalı gün numarası girdiniz!");
                break;
        }
    }
}