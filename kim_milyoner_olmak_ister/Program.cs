int counter = 0;

Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?\r\n\r\na) Lama b) Deve ");
string cevap1 = Console.ReadLine().ToLower();
if (cevap1 == "a") {
    Console.WriteLine("Doğru Cevap!\n");
    counter +=1; }
else
    Console.WriteLine("Yanlış Cevap :( \n");



Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ? \r\n\r\na) Venüs b) Mars ");
string cevap2 = Console.ReadLine().ToLower();
if (cevap2 == "b") {
    Console.WriteLine("Doğru Cevap!\n");
    counter += 1; }
else
    Console.WriteLine("Yanlış Cevap :( \n");



if (counter == 2)
    Console.WriteLine("Tebrikler ! Büyük ödülü kazandınız");
else if (counter == 0)
    Console.WriteLine("Maalesef yarışmayı kaybettiniz :(");

else {
    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? \r\n\r\na) 7 b) 12 ");
    string cevap3 = Console.ReadLine().ToLower();
    if (cevap3 == "b")
    {
        Console.WriteLine("Doğru Cevap!\n");
        Console.WriteLine("Tebrikler ! Büyük ödülü kazandınız");
    }
    else
        Console.WriteLine("Maalesef yarışmayı kaybettiniz :(");

}


