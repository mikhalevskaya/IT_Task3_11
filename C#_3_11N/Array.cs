using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__3_11N
{
    internal class Array
    {
        private Element[] elements;

        public Array(int size)
        {
            this.elements = new Element[size];
        }

        public void SetElement(int index, int value)
        {
            this.elements[index] = new Element(value);
        }

        public int GetElement(int index)
        {
            return this.elements[index].GetValue();
        }

        public void PrintArray()
        {
            Console.Write("[ ");
            for (int i = 0; i < this.elements.Length; i++)
            {
                Console.Write(this.elements[i].GetValue() + " ");
            }
            Console.WriteLine("]");
        }

        public Array AddArrays(Array array)
        {
            if (this.elements.Length != array.elements.Length)
            {
                Console.WriteLine("Error: Arrays have different lengths");
                return null;
            }

            Array resultArray = new Array(this.elements.Length);

            for (int i = 0; i < this.elements.Length; i++)
            {
                resultArray.SetElement(i, this.elements[i].GetValue() + array.elements[i].GetValue());
            }

            return resultArray;
        }

        public Array SubtractArrays(Array array)
        {
            if (this.elements.Length != array.elements.Length)
            {
                Console.WriteLine("Error: Arrays have different lengths");
                return null;
            }

            Array resultArray = new Array(this.elements.Length);

            for (int i = 0; i < this.elements.Length; i++)
            {
                resultArray.SetElement(i, this.elements[i].GetValue() - array.elements[i].GetValue());
            }

            return resultArray;
        }

        public Array MultiplyArrays(Array array)
        {
            if (this.elements.Length != array.elements.Length)
            {
                Console.WriteLine("Error: Arrays have different lengths");
                return null;
            }

            Array resultArray = new Array(this.elements.Length);

            for (int i = 0; i < this.elements.Length; i++)
            {
                resultArray.SetElement(i, this.elements[i].GetValue() * array.elements[i].GetValue());
            }

            return resultArray;
        }
    }
}
