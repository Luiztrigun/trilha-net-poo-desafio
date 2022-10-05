using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "2345678", modelo: "Modelo55" ,imei: "5698MMPKL" , memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("Zapzap");

Console.WriteLine("Smartphone Nokia");
Smartphone Iphone = new Iphone(numero: "2345678", modelo: "Modelo55" ,imei: "5698MMPKL" , memoria: 128 );
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");





