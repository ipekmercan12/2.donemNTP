// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[]args)
    {
        Hashtable ogrenciler = new Hashtable();
        // veri ekleme
        ogrenciler.Add(43, "damla");
        ogrenciler.Add("rüzgar",147);
        ogrenciler.Add("ipek", 203);
        ogrenciler.Add("burak", 45);
        ogrenciler.Add("ebrar"),1002;
        // silme
        ogrenciler.Remove(43);
        ogrenciler.Remove("burak");
        //güncelleme
        ogrenciler[147] = "emirhan";
        ogrenciler["ipek"] = 205;

        foreach (var anahtar in ogrenciler.Values)
        {
            Console.WriteLine(anahtar);
        }

        foreach (DictionaryEntry eleman in ogrenciler)
        {
            Console.WriteLine(eleman.Key + "-" + eleman.Value);

        }
        Console.ReadLine();
    }
}
