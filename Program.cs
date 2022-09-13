using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"(81)9425-7309",modelo:"nokia", imei:"123456", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"(81)9425-0009",modelo:"11", imei:"113436", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
