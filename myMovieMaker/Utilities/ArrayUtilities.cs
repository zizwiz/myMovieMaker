using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMovieMaker.Utilities
{
    class ArrayUtilities
    {

        // Function to remove the last item from a string array
        public static string[] RemoveLastItem(string[] array)
        {
            // Handle edge case: empty array
            if (array == null || array.Length == 0)
            {
                return Array.Empty<string>(); // Return an empty array
            }

            // Create a new array with one less element
            string[] newArray = new string[array.Length - 1];

            // Copy all elements except the last one
            Array.Copy(array, newArray, array.Length - 1);

            return newArray;
        }
    }
}
