// See https://aka.ms/new-console-template for more information

using ConsoleApp.Services;

Console.WriteLine("Servislerimiz");
Console.WriteLine("1. Hesap Makinesi");
Console.WriteLine("2. Sayı İşareti Kontrol Etme");
Console.WriteLine("3. En Büyük Sayıyı Bulma");
Console.WriteLine("4. Şifre Gücünü Kontrol Etme");
Console.WriteLine("5. Gün İsmi Belirleme");
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
    case 4:
        Console.WriteLine("Şifre Gücünü Kontrol Etme Servisi Seçildi.");
        PasswordCheckerService.Run();
        break;
    case 5:
        Console.WriteLine("Gün İsmi Belirleme Servisi Seçildi.");
        DayNameService.Run();
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız!");
        break;
}
