using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia nokia = new Nokia("12345", "1º Geração", "0101010", 20);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone("98765", "11", "0909009", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");