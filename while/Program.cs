int i = 0;
while (i < 10)  // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
{
    Console.WriteLine(i + "Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

int a = 1;
while (a <= 20) //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
{
    Console.WriteLine(a);
    a++;
}


int b = 2;
while (b <= 20)   //  1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
{
    Console.WriteLine(b);
    b += 2;
}

int toplam = 0;// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int c = 50;
while (c <= 150)
{
    toplam += c;
    c++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);



int d = 1;// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int toplamTek = 0;
int toplamCift = 0;

while (d <= 120)
{
    if ((d % 2) == 0)
        toplamCift += d;
    else
        toplamTek += d;
    d++;
}

Console.WriteLine("1den 120e kadar olan tek sayilarin toplami: " + toplamTek);
Console.WriteLine("1den 120ye kadar olan cift sayilarin toplami: " + toplamCift);