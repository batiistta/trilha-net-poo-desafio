using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia1 = new Nokia(numero: "4877", modelo:"15s", imei: "4587441", memoria: 256);

nokia1.InstalarAplicativo("Facebook");
nokia1.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Iphone iphone1 = new Iphone(numero: "1542", modelo:"X", imei: "15154151", memoria: 128);


iphone1.InstalarAplicativo("Instagram");
iphone1.ReceberLigacao();

