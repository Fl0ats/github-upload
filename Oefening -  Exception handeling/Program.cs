using Oefening____Exception_handeling;
using System;
using System.Collections.Generic;

var aantalSucessen = 0;
do
{
    try
    {

        var arr = new[] { 1, 2, 3 };
        Console.Write("Kies cijfer ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine($"Uw keuze was {arr[choice - 1]}");
        aantalSucessen++;
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }

} while (aantalSucessen < 2);
try
{
    var myCat = new Cat(6);
    var myCat2 = new Cat(2);
    var myCat3 = new Cat(-7);
    var catList = new List<Cat> { myCat, myCat2, myCat3 };
    controlAge(catList);
}
catch (CustomError)
{
    Console.WriteLine("Fout opgevangen");
    throw;
}
static void controlAge(List<Cat> catList)
{
    Cat[] cats = catList.ToArray();

    if (!Array.TrueForAll(cats, c => c.Age <= 0))
    {
        throw new CustomError($"Kat heeft een ongeldige leeftijd");
    }

}





