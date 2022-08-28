using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class ArrayHelpers
    {
        public static T[,] Create2dArray<T>(int row, int col)
        {
            return new T[row, col];
        }

        public static T[,] Create2dArray<T>()
        {
            return Create2dArray<T>(new Random().Next(5, 10+1), new Random().Next(5, 10+1));
        }

        public static T[,,] Create3dArray<T>(int x, int y, int z)
        {
            return new T[x, y, z];
        }
    }
}
