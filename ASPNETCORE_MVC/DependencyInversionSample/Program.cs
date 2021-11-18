using System;

namespace DependencyInversionSample
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Programmierer B kann seinen Service testen: 

    //        ICarService service = new BetterCarService(); ///Dependency Inversion -> SOLID Prinzipien -> Regel 4 

    //        ICar testCarObj = new MockCar();

    //        service.Repair(testCarObj); //Repair Methode kann einen Funktionstest erfahren mit festen Testwerten. (MockObject) 

    //        //Programmierer A ist fertig mit BetterCar

    //        ICar car = new BetterCar();
    //        service.Repair(car);        
    //    }
    //}


    #region BadCode Sample
    // Entities.dll oder DomainModel.dll 

    //Teamarbeit: Programmierer A: 5 Tage (Starte am Tag 1 -> Projekt geht bis Tag 5) 
    public class Car 
    {
        public int Id { get; set; } 
        public string Marke { get;set; }
        public string Modell { get; set; }  
        public int Baujahr { get; set; }
    }

    //Service.dll -> verwendet die Entites.dll (fest gekoppelt) 

    //Teamarbeit: Programmierer B: 3 Tage (Starte Tag 5 = Tag 7/8 (fertig) 
    public class CarService 
    {
        public void Reapir(Car car)
        {
            //Repariere Auto
        }
    }
    #endregion


    #region Better Code
    //Code First Manier: 

    //Seperat Interface.dll -> Beispiel: Repository-Interface in DDD (DomainModel(SericeLayer)) 
    public interface ICar
    {
         int Id { get; set; }
         string Marke { get; set; }
         string Modell { get; set; }
         int Baujahr { get; set; }
    }

    public interface ICarService
    {
        void Repair(ICar car);
    }


    //Programmierer A -> 5 Tage (Fertig am Tag 5)

    //BetterCar -> Entities.dll
    public class BetterCar : ICar
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
    }


    //Programmierer B -> 3 Tage (Fertig am Tag 3)
    //service.dll
    public class BetterCarService : ICarService
    {
        public void Repair(ICar car) //<- Dependency Injection (Methode) 
        {
            //Repariere Auto
        }
    }

    
    public class MockCar : ICar
    {
        public int Id { get; set; } = 123;
        public string Marke { get; set; } = "VW";
        public string Modell { get; set; } = "Polo";
        public int Baujahr { get; set; } = 2019;
    }




    #endregion
}
