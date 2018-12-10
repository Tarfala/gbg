using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsAndLists.Core.Enums;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            throw new NotImplementedException();
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            throw new NotImplementedException();
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            throw new NotImplementedException();
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            throw new NotImplementedException();
        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            throw new NotImplementedException();
        }

        public List<List<int>> MultiplicationTable_Linq(int rowMax, int colMax)
        {
            throw new NotImplementedException();
        }


        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            if (sum)
                return ComputeSequence(toNumber, ComputeMethod.Sum);
            else
                return ComputeSequence(toNumber, ComputeMethod.Product);
        }

        public int ComputeSequence(int toNumber, ComputeMethod sum)
        {
            if (toNumber <= 0)
                throw new ArgumentException();

            var range = Enumerable.Range(1, toNumber).ToList();

            switch (sum)
            {
                case ComputeMethod.Sum:
                    return range.Sum();

                case ComputeMethod.Product:
                    return range.Aggregate((a, b) => a * b);

                default:
                    throw new NotImplementedException();
            }
        }

        public int[] CombineLists(int[] list1, int[] list2)
        {
            throw new NotImplementedException();
        }

        public int[] RotateList(int[] list, int rotation)
        {
            throw new NotImplementedException();
        }
    }
}
