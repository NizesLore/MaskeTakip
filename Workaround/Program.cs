//Degiskenler
//string message = "Selam";
//double amount = 100000; // db den gelir
//int sayi = 100;
//bool girisYapmisMi = false;

//string name = "Engin";
//string lastName = "Demiroğ";
//int dogumYili = 1985;
//long identityNumber = 12345678910;


//Console.WriteLine(amount*0.18);
//Console.WriteLine(amount*0.18);
//Console.WriteLine(message);

Vatandas vatandas = new Vatandas();

SelamVer("Nizes");
SelamVer("Ayşe");
SelamVer("Engin");
SelamVer();

int sonuc = Topla(6);


//Diziler / Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Nizes";
string ogrenci3 = "Ayşe";


string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Nizes";
ogrenciler[2] = "Ayşe";

ogrenciler = new string[4];
ogrenciler[3] = "Lore";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] {"Ankara", "Artvin","İzmir" };
string[] sehirler2 = new[] {"Bursa", "Trabzon", "İstanbul" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//Mylist
List<string> yeniSehirler1 = new List<string> {"Ankara1", "Artvin1", "İzmir1"};
yeniSehirler1.Add("Adana1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
 
int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);


static void SelamVer(string name="noname")
{
    Console.WriteLine("Merhaba " + name);
}


static int Topla(int sayi1=5, int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;


}


public class Vatandas
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthDate { get; set; }
    public long IdentityNumber { get; set; }



}
