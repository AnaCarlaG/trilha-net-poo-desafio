using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", imei: "12", modelo: "A71", memoria: 200);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "123", imei: "12", modelo: "X", memoria: 200);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");