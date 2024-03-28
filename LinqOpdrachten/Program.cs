namespace LinqOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 6, 3,12, 1, 5, 6, 7, 8, 4,
                54, 14, 653, 3, 4, 5, 6, 47 };   

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
            foreach(var number in evengetallen)
            {
                Console.WriteLine(number);
            }
        }
    }
}
