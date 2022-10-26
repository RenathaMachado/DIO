using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("21982162835", "Nokia C20", "1728473842947324", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("2185934934", "Iphone 6", "74274834782347", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");

