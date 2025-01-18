using day_06_G01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp
{
    public static class Helper2<T>
    {
        public static int SearchArray(T[] array, T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }

        public static int SearchArrayByDepartment(Employee[] array, Department department)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Department.Equals(department))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
