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
            var result = new List<string>();
            int index = 0;
            foreach (var word in list)
            {
                if (toUpper[index] == true)
                    result.Add(word.ToUpper());
                else
                    result.Add(word);
                index++;
            }

            return result;
        }

        public List<string> SomeToUpper_Linq(List<string> list, List<bool> toUpper)
        {
            return list.Select((x, index) => toUpper[index] ?

                    list[index].ToUpper() :
                    list[index]

            ).ToList();
        }

        public List<string> SomeToUpper_Zip(List<string> list, List<bool> toUpper)
        {
            return list.Zip(toUpper, (x, up) => up ? x.ToUpper() : x).ToList();
        }
        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
                throw new ArgumentException();

            var result = new List<double>();
            foreach (var number in numbers)
            {
                result.Add(number * factor);
            }

            return result;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            if (numbers == null)
                throw new ArgumentException();

            return numbers.Select(n => n * factor).ToList();
        }


        public List<string> NearbyElements(int position, List<string> list)
        {
            if (position < 0 || position > list.Count - 1)
                throw new ArgumentException();

            var result = new List<string>();

            if (position > 0)
                result.Add(list[position - 1]);

            result.Add(list[position]);

            if (position < list.Count - 1)
                result.Add(list[position + 1]);

            return result;
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
