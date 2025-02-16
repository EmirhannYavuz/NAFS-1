// See https://aka.ms/new-console-template for more information

using ConsoleApp.Services;

Console.WriteLine("Servislerimiz");
Console.WriteLine("1. Hesap Makinesi");
Console.WriteLine("2. Sayı İşareti Kontrol");
Console.WriteLine("3. En Büyük Sayıyı Bulma");
Console.WriteLine("Kullanmak istediğiniz servisi seçiniz (1-5): ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Hesap Makinesi Servisi Seçildi.");
        CalculatorService.Run();
        break;
    case 2:
        Console.WriteLine("Sayı İşareti Kontrol Servisi Seçildi.");
        SignCheckerService.Run();
        break;
    case 3:
        Console.WriteLine("En Büyük Sayıyı Bulma Servisi Seçildi.");
        LargestNumberService.Run();
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız!");
        break;
}
