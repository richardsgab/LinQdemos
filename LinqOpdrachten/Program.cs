using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 6, 3,12, 1, 5, 6, 7, 8, 4,
                54, 14, 653, 3, 4, 5, 6, 47 };

            List<string> names = new List<string>() { "Rik", "Hugo", "Alba", "Olessia", "ANtu", "Dritin", "Mariela", "Leticia" };



            //1.Lijst van Getallen: 
            //Maak een lijst van gehele getallen. Gebruik LINQ om alle getallen die groter zijn dan 10 te vinden en druk deze af. 
            var groterdan10 = numbers.Where(x => x > 10).ToList();
            foreach (var number in groterdan10)
            {
                Console.WriteLine(number);
            }


            //2.Even Getallen: 
            //Gebruik dezelfde lijst van gehele getallen. Gebruik LINQ om alle even getallen te vinden en druk deze af. 
            var evengetallen = numbers.FindAll(n => n % 2 == 0);
            foreach (var number in evengetallen)
            {
                Console.WriteLine(number);
            }

            //3.Namen Zoeken: Maak een lijst van namen(strings).
            //Gebruik LINQ om alle namen te vinden die beginnen met de letter 'A' en druk deze af.            
            var nameswitha = names.Where(w => w.StartsWith("A"));
            foreach (var name in nameswitha)
            {
                Console.WriteLine(name);
            }

            //4.Gesorteerde Lijst: 
            //Neem een willekeurige lijst van gehele getallen.
            //Gebruik LINQ om de lijst in oplopende volgorde te sorteren en druk het resultaat af. 
            var sortednumbers = numbers.OrderBy(x => x).ToList();
            foreach (var number in sortednumbers)
            {
                Console.WriteLine(number);
            }

            //5.Aantal Elementen:
            //Gebruik LINQ om het aantal elementen in een lijst van strings te vinden
            //die een bepaalde letter bevatten.
            var contentsletter = names.Where(n => n.ToLower().Contains("r"));
            foreach (string name in contentsletter)
            {
                Console.WriteLine(name);
            }

            //6.Maximaal Getal: 
            //Vind het grootste getal in een lijst van gehele getallen met LINQ. 
            var grootstenumber = numbers.Max().ToString();            
            Console.WriteLine($"hello friends {grootstenumber}");

            //7.Gemiddelde Berekenen: 
            //Bereken het gemiddelde van een lijst van gehele getallen met behulp van LINQ. 
            var gemiddeldenumber = numbers.Average().ToString();
            Console.WriteLine(gemiddeldenumber);

            //8.Eerste en Laatste Element:
            //Gebruik LINQ om het eerste en het laatste element van een lijst
            //van gehele getallen af te drukken. 
            var firstnummer = numbers.First();
            var lastnummer = numbers.Last();
            Console.WriteLine(firstnummer +" "+ lastnummer);

        }
    }
}
