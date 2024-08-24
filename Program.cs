// See https://aka.ms/new-console-template for more information
using NeopixelControlDesktop;

var res = await AdafruitIOService.SendValue("a");

Console.Write(res);

Console.WriteLine("Hello, World!");
Console.Read();