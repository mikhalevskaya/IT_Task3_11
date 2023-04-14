namespace C__3_11N
{
    using System;

    class Program
    {
        static void Main()
        {
            Array array1 = new Array(3);
            array1.SetElement(0, 1);
            array1.SetElement(1, 2);
            array1.SetElement(2, 3);


            Array array2 = new Array(3);
            array2.SetElement(0, 3);
            array2.SetElement(1, 5);
            array2.SetElement(2, 6);

            Console.WriteLine("Array 1:");
            array1.PrintArray();

            Console.WriteLine("Array 2:");
            array2.PrintArray();

            Console.WriteLine("Array 1 + Array 2:");
            Array sumArray = array1.AddArrays(array2);
            sumArray.PrintArray();

            Console.WriteLine("Array 1 - Array 2:");
            Array diffArray = array1.SubtractArrays(array2);
            diffArray.PrintArray();

            Console.WriteLine("Array 1 * Array 2:");
            Array multArray = array1.MultiplyArrays(array2);
            multArray.PrintArray();
        }
    }

}
