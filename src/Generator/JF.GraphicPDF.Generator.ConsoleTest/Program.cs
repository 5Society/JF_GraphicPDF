// See https://aka.ms/new-console-template for more information
using JF.GraphicPDF.Generator.ConsoleTest;

Console.WriteLine("Hello, World!");

PdfJob.CreatePDF("..\\..\\..\\Examples\\Test1.xml", "..\\..\\..\\Examples\\Test1.json", "..\\..\\..\\Examples\\Result\\Test1.pdf");
