
using System.Runtime.Intrinsics.X86;
// (1.Soru) Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i;
i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim  !");
    i++;
}



// (2.Soru)  1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int a;
a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;    
}



// (3.Soru) 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int b;
b = 2;
while (b <= 20)
{
    Console.WriteLine(b);
    b+=2;
}





// (4.Soru) 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int start = 50;
int end = 150;
int toplam = 0;

while (start <= end)
{
    toplam += start;
    start++;
}
{
    Console.WriteLine("50 ile 150 arasındaki sayıların toplamı:" + toplam);
}





// (5.Soru)  1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int baslangic = 1;
int evenSum = 0;
int oddSum = 0;

while (baslangic <= 120)
{
    if (baslangic % 2 == 0)
    {
        evenSum += baslangic;
    }
    else
    {
        oddSum += baslangic;
    }
    baslangic++;
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenSum);
Console.WriteLine("1 ile 120 arassındaki tek sayıların toplamı: " + oddSum);

