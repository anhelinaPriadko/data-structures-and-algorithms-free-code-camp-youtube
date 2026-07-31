using System;
namespace DynamicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new DynamicArray<int>();
            Console.WriteLine("Initialized array");
            Console.WriteLine(arr1.ToString());

            var len1 = arr1.Size();
            Console.WriteLine("Check if the array has length 0");
            Console.WriteLine(len1);

            var isEmpty1 = arr1.IsEmpty();
            Console.WriteLine("Check if the array is empty");
            Console.WriteLine(isEmpty1);

            for(int i = 0; i < 10; i++)
            {
                arr1.Add(i * 2);
            }
            Console.WriteLine("Add values 0, 2, 4, 6, 8, 10, 12, 14, 16, 18");
            Console.WriteLine(arr1.ToString());

            arr1.Set(0, 1);
            arr1.Set(1, 0);
            Console.WriteLine("Change values so it should be 1, 0, 4, 6, 8, 10, 12, 14, 16, 18");
            Console.WriteLine(arr1.ToString());

            arr1.Set(0, 0);
            arr1.Set(1, 2);
            Console.WriteLine("Change values back so it should be 0, 2, 4, 6, 8, 10, 12, 14, 16, 18");
            Console.WriteLine(arr1.ToString());

            arr1.RemoveAt(1);
            Console.WriteLine("Remove 2 from the array");
            Console.WriteLine("So the values should be 0, 4, 6, 8, 10, 12, 14, 16, 18");
            Console.WriteLine(arr1.ToString());

            var indexOf6 = arr1.IndexOf(6);
            Console.WriteLine("Want to reach for value 6 position, should return 2");
            Console.WriteLine(indexOf6);

            var indexOfWrongNumber = arr1.IndexOf(100);
            Console.WriteLine("Want to reach for value 100 position, should return -1, because there is no such value in the array");
            Console.WriteLine(indexOfWrongNumber);

            arr1.RemoveAt(6);
            Console.WriteLine("Remove 14 from the array");
            Console.WriteLine("So the values should be 0, 4, 6, 8, 10, 12, 16, 18");
            Console.WriteLine(arr1.ToString());

            try
            {
                arr1.RemoveAt(100);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Trying to remove value at index 100, which is out of range, should throw an exception");
                Console.WriteLine(e.Message);
            }

            var contains6 = arr1.Contains(6);
            Console.WriteLine("Check if the array contains value 6, should return true");
            Console.WriteLine(contains6);

            var contains100 = arr1.Contains(100);
            Console.WriteLine("Check if the array contains value 100, should return false");
            Console.WriteLine(contains100);

            Console.WriteLine("Iterate through the array and print each value");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            arr1.Clear();
            Console.WriteLine("Clear the array");
            Console.WriteLine("So the values should be empty");
            Console.WriteLine(arr1.ToString());

        }
    }  
}

