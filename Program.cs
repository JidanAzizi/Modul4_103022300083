// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using Jurnal4;

kodeProduk[] listKode = new kodeProduk[10];

String input = Console.ReadLine();

listKode[0] = new kodeProduk("Laptop", "E100");
listKode[1] = new kodeProduk("Smartphone", "E101");
listKode[2] = new kodeProduk("Tablet", "E102");
listKode[3] = new kodeProduk("Headset", "E103");
listKode[4] = new kodeProduk("Keyboard", "E104");
listKode[5] = new kodeProduk("Mouse", "E105");
listKode[6] = new kodeProduk("Printer", "E106");
listKode[7] = new kodeProduk("Monitor", "E107");
listKode[8] = new kodeProduk("Smartwatch", "E108");
listKode[9] = new kodeProduk("Kamera", "E109");


for (int i = 0; i < listKode.Length; i++)
{
    if (Equals(listKode[i].nama, input))
    {
        Console.WriteLine(listKode[i].kode);
        break;
    }
}

//FanLaptop fan = new FanLaptop();
//String input = Console.ReadLine();
//while (input != "OFF") {
//    if (input == "UP")
//    {
//        fan.modeUp();
//    }
//    else if (input == "DOWN")
//    {
//        fan.modeDown();
//    }
//    else if (input == "TURBO") { 
//        fan.turboShortcut();
//    }

//    input = Console.ReadLine();
//}