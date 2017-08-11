using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BackToSuccess.OopsConcepts
{
    /// <summary>
    /// You use a yield return statement to return each element one at a time.
    /// You consume an iterator method by using a foreach statement or LINQ query. 
    /// Each iteration of the foreach loop calls the iterator method. 
    /// When a yield return statement is reached in the iterator method, expression is returned, and the current location in code is retained. 
    /// Execution is restarted from that location the next time that the iterator function is called.
    /// You can use a yield break statement to end the iteration.
    ///For more information about iterators, see Iterators.
    /// </summary>
    public class LearnYield
    {
        IEnumerable<int> numbers = new[] { 3, 4, 7, 1, 8, 10, 21, 5, 9, 11, 14, 19 };

        public IEnumerable<int> GetNumbers(IEnumerable<int> numbers, Func<int, bool> numberResolver)
        {
            foreach (int number in numbers)
            {
                if (numberResolver(number))
                    yield return number;
            }
            yield return 55;
            yield return 65;

        }

        public void PrintResult()
        {
            IEnumerable<int> greaterThanTen = GetNumbers(numbers, x => x > 10);
            greaterThanTen.ToList().ForEach(Console.WriteLine);
        }
        public static void Execute() {
            LearnYield y = new LearnYield();
            y.PrintResult();
            GalaxyClass.ShowGalaxies();
        }

    }

    public static class GalaxyClass
    {
        public static void ShowGalaxies()
        {
            var theGalaxies = new Galaxies();
            foreach (Galaxy theGalaxy in theGalaxies.NextGalaxy)
            {
                Debug.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears.ToString());
            }
        }

        public class Galaxies
        {

            public System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
            {
                get
                {
                    yield return new Galaxy { Name = "Tadpole", MegaLightYears = 400 };
                    yield return new Galaxy { Name = "Pinwheel", MegaLightYears = 25 };
                    yield return new Galaxy { Name = "Milky Way", MegaLightYears = 0 };
                    yield return new Galaxy { Name = "Andromeda", MegaLightYears = 3 };
                }
            }

        }

        public class Galaxy
        {
            public String Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
