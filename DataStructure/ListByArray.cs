using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class ListByArray
    {
        // data
        int[] array;
        int tail;

        // constructor
        public ListByArray(int size)
        {
            array = new int[size];
            tail = 0;
        }

        //  inserts the value to the end of list 
        public bool Append(int data)
        {
            bool result = false;
            if (tail < array.Length)
            {
                array[tail] = data;
                tail++;
                result = true;
            }
            return result;
        }
        //inserts the value X to list L at position
        public bool Insert(int data, int index)
        {
            bool result = false;
            if (tail < array.Length && index < tail)
            {
                for (int i = tail; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = data;
                tail++;
                result = true;
            }
            return result;
        }

        //removes all nodes with the value
        public int RemoveAll(int data)
        {
            int count = 0;
            // find value
            for (int i = 0; i < tail; i++)
            {
                if (array[i] == data)
                {
                    for (int j = i; j < tail - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    count++;
                    tail--;
                }
            }
            return count;
        }

        // remove first elemeent
        public int RemoveFirst(int data)
        {
            int index = -1;
            for (int i = 0; i < tail; i++)
            {
                if (array[i] == data)
                {
                    index = i;
                    for (int j = i; j < tail - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    tail--;
                    break;
                }

            }
            return index;
        }

        // remove index
        public bool RemoveIndex(int index)
        {
            bool result = false;
            if (index < tail)
            {
                for (int i = index; i < tail - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                tail--;

            }
            return result;
        }
        // get data from index

        public int GetElement(int index)
        {
            int result = int.MaxValue;
            if (index < tail)
            {
                result = array[index];
            }
            return result;
        }

        // swap
        public bool Swap (int index1,int index2)
        {
            bool result = false;
            if (index1 < tail && index2 <tail)
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;

                result = true;
            }
            return result;
        }
        public void Clear()
        {
            tail = 0;
        }
        public void PrintList()
        {
            Console.Write("List ");
            for (int i = 0; i < tail; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
