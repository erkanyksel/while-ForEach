using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {

        // .while
        // 1 den baslayarak console dan girilen sayuya kadar sayi dahil ortalama hesaplayıp console a yazan program.
        Console.WriteLine("lütfen bir sayi giriniz");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine(toplam / sayi);

        // a dan z ye kadar tüm harfleri console a yazdır.
        char Character = 'a';

        while (Character < 'z')
        {
            Console.WriteLine(Character);
            Character++;
        }

        Console.Write("*****************   ForEach  **************");

        string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}