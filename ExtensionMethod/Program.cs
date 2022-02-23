//ExtensionMethod Assignment 

namespace ExtensionMethod
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 50, 9, 887, 7, 9, 4, 2 };
            List<int> list = new List<int>() { 190, 76, 988, 9, 11, 6, 0};

            //Pass an array to our method and return the maximum value
           
            int max = numbers.MaxArrayElement(i => i);
          
            int maxList = list.MaxArrayElement(i => i);

            //Call FirstOrDefault 
            var max2 = numbers.FirstOrDefault(x => x.Equals(2));
            var max3 = list.FirstOrDefault(x => x > 200);

            //string function to display strings with formating
            Console.WriteLine($"The maximum value in the array of numbers {{{string.Join(", ", numbers)}}} is: {max}");
            Console.WriteLine($"The maximum value in the collection of numbers {{{string.Join(", ", list)}}} is: {maxList}");

            Console.WriteLine("\n xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine($"Your collection {{{string.Join(", ", numbers)}}} contains {max2}");
            Console.WriteLine($"The first element of your collection {{{string.Join(", ", list)}}} greater than 200 is:   {max3}");



        }
    }



    public static class ExtensionMethod
    {

        //This methods takes a collection of numbers and returns the maximum element
        public static int MaxArrayElement<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            //MinValue is a field of integer class. It's the default minimun value of integers
            int maxArrayElement = int.MinValue;
           
            foreach(TSource item in source)
            {
                if(selector(item) > maxArrayElement)
                {
                    maxArrayElement = selector(item);
                }
            }
            return maxArrayElement;
        }

        //This method takes an IEnumarable and returns the first element 
        public static TSource? FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach(TSource item in source) 
            {
                if (predicate(item))
                {
                    return (item);
                }
            }

            return default(TSource);
        }



    }
}