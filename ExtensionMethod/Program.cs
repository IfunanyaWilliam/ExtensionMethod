//ExtensionMethod Assignment 

namespace ExtensionMethod
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 5, 1, 887, 10009937, 9, 4 };
            List<int> list = new List<int>() { 76, 988, 9, 3987, 6098765, 0};

            //Pass an array to our method and return the maximum value
           
            int max = numbers.MaxArrayElement(i => i);
          
            int maxList = list.MaxArrayElement(i => i);

            Console.WriteLine($"The maximum value in the array of numbers {{10, 5, 1, 887, 10009937, 9, 4}} is: {max}");
            
            Console.WriteLine($"The maximum value in the collection of numbers {{76, 909, 9, 3, 63, 0}} is: {maxList}");


        }
    }



    public static class ExtensionMethod
    {

        //This methods takes a collection of numbers and returns the maximum element
        public static int MaxArrayElement<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int maxArrayElement = 0;
           
            foreach(TSource item in source)
            {
                if(selector(item) > maxArrayElement)
                {
                    maxArrayElement = selector(item);
                }
            }
            return maxArrayElement;
        }





    }
}