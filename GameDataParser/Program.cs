// See https://aka.ms/new-console-template for more information
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using GameDataParser.App;
using GameDataParser.FileRepository;
using GameDataParser.UserInteraction;
using GameDataParser.ExceptionHandling;

Console.WriteLine("Hello, World!");


var gameDataParserProgram = new GameDataParserProgram(new UserInteraction(), new FileRepository());
try
{
    gameDataParserProgram.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    Logger.log(ex);
}













