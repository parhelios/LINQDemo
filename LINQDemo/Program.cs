using System.Runtime.InteropServices;
using LINQDemo.Data;

var db = new DataSource();

//Dictionary<string, Action> doSomething = new Dictionary<string, Action>();

////Lambda uttryck
//var hello = () =>
//{
//    return "Hello!";
//};

//var text = () => "Hello!";

//var printHej = () =>
//{
//    Console.WriteLine("Hej");
//};

//var printDå = () =>
//{
//    Console.WriteLine("Då");
//};

//string textOne = Hello();
//string textTwo = hello();

//Console.WriteLine(hello());
//Console.WriteLine(textOne);
//Console.WriteLine(textTwo);

//printHej();

//doSomething.Add("hej", printHej);
//doSomething.Add("då", printDå);

//string input = Console.ReadLine();

//doSomething[input]();

//string Hello()
//{
//    return "Hello!";
//}

//_____________________________

//var sum = 0D;

//foreach (var product in db.Stock)
//{
//    sum += product.Price;
//}

var prices1 = new List<double>();

foreach (var product in db.Stock)
{
    prices1.Add(product.Price);
}

foreach (var d in prices1)
{
    Console.WriteLine(d);
}

Console.WriteLine("--------------");

var prices = db.Stock.Select(p => p.Price);

foreach (var price in prices)
{
    Console.WriteLine(price);
}

Console.WriteLine("--------------");

Console.WriteLine(prices.Max());
Console.WriteLine(db.Stock.Select(p => p.Price).Max());

Console.WriteLine("--------------");

var names = db.People.Select(p => p.Name);

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("--------------");

var namesQ = 
    from person in db.People
    select person.Name;

foreach (var nameQ in namesQ)
{
    Console.WriteLine(nameQ); 

}

Console.WriteLine("--------------");

var peopleStartingWithA = db.People.Where(p => p.Name[0] == 'A');

var peopleStartingWithS =
    from p in db.People
    where p.Name[0] == 'S'
    select p;

Console.WriteLine(peopleStartingWithA.Count());

foreach (var person in peopleStartingWithA)
{
    Console.WriteLine(person.Name);
}

Console.WriteLine("--------------");

foreach (var person in peopleStartingWithS)
{
    Console.WriteLine(person.Name);
}

Console.WriteLine("--------------");

var peopleAge = db.People.Where(p => p.Age > 50);

Console.WriteLine(peopleAge.Count());

foreach (var person in peopleAge)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
    Console.WriteLine("-----");
}

Console.WriteLine(peopleAge.Min(p => p.Age));

Console.WriteLine("--------------");
Console.WriteLine("--------------");


var peopleOrderedByAge = db.People.OrderBy(p => p.Age);

foreach (var person in peopleOrderedByAge)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
    Console.WriteLine("-----");
}