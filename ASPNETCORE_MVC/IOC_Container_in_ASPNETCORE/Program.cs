using Microsoft.Extensions.DependencyInjection;
using System;

namespace IOC_Container_in_ASPNETCORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car Object 

            ICar car = new Car() { Id = 1, Marke = "Porsche", Modell = "GT3", Baujahr = 2020 };
            ICar mockCar = new MockCar();
            
            //Shortcut  für das Auflösen von Klassen -> STRG + . (also Punkt) -> PopupFenster
            ServiceCollection collection = new (); //C# 9
            
            //Legen einen Service in die ServiceCollection (IOC Container) 
            collection.AddSingleton<IMockCar, MockCar>(); 
            collection.AddTransient<ICar, Car>(); //geht das? 
            //collection.AddTransient<ICar, MockCar>();   


            //Am Ende der Befüllung wird der Provier erstellt.
            ServiceProvider provider = collection.BuildServiceProvider();

            ICar myCar = provider.GetRequiredService<ICar>();

            ICar myMockCar = provider.GetRequiredService<IMockCar>();

            Console.WriteLine($"{myCar.Id} {myCar.Marke} {myCar.Modell} {myCar.Baujahr} ");


            Console.ReadLine();
        }

       
    }


    public interface ICar
    {
        int Id { get; set; }
        string Marke { get; set; }
        string Modell { get; set; }
        int Baujahr { get; set; }
    }

    public interface IMockCar :ICar
    {

    }


    public class MockCar : IMockCar
    {
        public int Id { get; set; } = 123;
        public string Marke { get; set; } = "VW";
        public string Modell { get; set; } = "Polo";
        public int Baujahr { get; set; } = 2019;
    }


    public class Car : ICar
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
    }
}
