// See https://aka.ms/new-console-template for more information
using Lab10ex2.Models;
using Microsoft.EntityFrameworkCore;

/*
 *Exercitiul 2
• Un autovehicul este caracterizat de urmatoarele proprietati
• Id:int
• Nume
• Serie de sasiu: string • An de fabricatie :int • Producator
• Producatorul va avea • Id:int
• Nume
• Adresa:string
• Creeati modelul, adaugati EF 3.1, Adaugati DB
• Creeati in clasa “main” o functie “Seed” care va popula DB-ul
• Afisatitoateautovehiculeleinordine descrescatoare a anului de fabricatie
• Suplimentar
• Afisati autovehiculele grupate in functie
de numele producatorului sub forma
“Autovehiculele producatorului Trabant”: Id, nume, serie, an de fabricatie
.
.
. etc
 * */


//Seed();
ShowAOrderedByYear();
ShowCarsByProducer();



static void Seed()
{

    using var ctx = new AutoDbContext();

    var mercedes = new Producer
    {
        Name = "Mercedes",
        Address = "address 1"
    };
    var audi = new Producer
    {
        Name = "Audi",
        Address = "address 2"
    };
    var volvo = new Producer
    {
        Name = "Volvo",
        Address = "address 3"
    };

    ctx.Cars.Add(new Car
    {
        Name = "EQE",
        SerieSasiu = "eqe123",
        Year = 2022,
        Producer = mercedes
    }); ;
    ctx.Cars.Add(new Car
    {
        Name = "CLE Cabriolet",
        SerieSasiu = "cle123",
        Year = 2021,
        Producer = mercedes
    }); ;
    ctx.Cars.Add(new Car
    {
        Name = "Q7",
        SerieSasiu = "q443",
        Year = 2020,
        Producer = audi
    }); ;
    ctx.Cars.Add(new Car
    {
        Name = "Q6",
        SerieSasiu = "q234",
        Year = 2019,
        Producer = audi
    }); ;

    ctx.Cars.Add(new Car
    {
        Name = "XC90 Recharge",
        SerieSasiu = "x7678",
        Year = 2021,
        Producer = volvo
    }); ;
    ctx.Cars.Add(new Car
    {
        Name = "EX30",
        SerieSasiu = "u889",
        Year = 2018,
        Producer = volvo
    }); ;


    ctx.SaveChanges();

}

static void ShowAOrderedByYear()
{
    using var ctx = new AutoDbContext();

    foreach (var car in ctx.Cars.OrderByDescending(e => e.Year))
    {
        Console.WriteLine(car.ToString());
    }


}

static void ShowCarsByProducer()
{
    using var ctx = new AutoDbContext();

     var producerList = ctx.Producers.Include(e => e.Cars);

    foreach (Producer producer in producerList)
    {
        Console.WriteLine($"Autovehiculele producatorului {producer.ToString()}:");
        foreach (Car car in producer.Cars)
        {
            Console.WriteLine(car.ToString());
        }


    }
    /*
    foreach (var producer in ctx.Producers)
    {
        Console.WriteLine($"Autovehiculele producatorului {producer.ToString()}:");

        ctx.Cars.Where(e => e.Producer.Id == producer.Id).ToList()
            .ForEach(e => Console.WriteLine(e.ToString()));

    }*/

}