/**********************************************************************************/
// Project 1 from Data Structures (Summer 2018)
// Class: "High Array"
// This program's original purpose was to demonstrate typical Data Structure such as
// searching and inserting. This version is modified to take in a text file containing 
// values, inserting them, then asking the user for values to search.
/**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUno
{
    public class HighArray
    {
        #region Private Variables
        private long[] arr;
        private int _numElems;
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////
        #region Constructors
        public HighArray(int maxElements)
        {
            arr = new long[maxElements];
            _numElems = 0;
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////
        #region Public Methods
        public void Insert(long value)
        {
            if (value >= 0)
            {
                arr[_numElems] = value;
                _numElems++;
            }
            else if (_numElems == arr.Length)
            {
                Console.WriteLine("Error: Array is full. Delete items in order to insert more.");
            }
            else
            {
                Console.WriteLine("Error: Current value ({0}) not inserted");
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        // -1 indicates a value that has been deleted, as array does not accept negative values.
        public void Delete(long value)
        {
            for (int i = 0; i < _numElems; i++)
            {
                if (arr[i] == value)
                    arr[i] = -1;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        public bool Find(long value)
        {
            foreach (long l in arr)
            {
                if (l == value)
                {
                    Console.WriteLine("Found {0}.", value);
                    return true;
                }
                else
                    Console.WriteLine("{0} not found.", value);
            }

            return false;
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        // Displays all values not deleted from the array
        public void Display()
        {
            foreach (long l in arr)
            {
                if (l != -1)
                    Console.WriteLine("{0} ", l);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        public long GetMax()
        {
            long max = arr[0];

            for (int i = 1; i < _numElems; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        public long GetMin()
        {
            long min = arr[0];

            for (int i = 0; i < _numElems; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        public int GetSize()
        {
            return arr.Length;
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////
    }
}
