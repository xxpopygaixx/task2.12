using System;
using System.Collections.Generic;
using System.Linq;

namespace hac3
{
    public enum DataType
    {
        None = 0,
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');
            List<string> err = new List<string>(); 
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (DataType d in Enum.GetValues(typeof(DataType)))
            {
                count.Add(d.ToString(), 0);
            }
            foreach (var item in input)
            {
                int t;
                if (Int32.TryParse(item,out t))
                {
                    switch ((DataType)t)
                    {
                        case DataType.None:
                            count[DataType.None.ToString()]++;
                            break;
                        case DataType.First:
                            count[DataType.First.ToString()]++;
                            break;
                        case DataType.Second:
                            count[DataType.Second.ToString()]++;
                            break;
                        case DataType.Third:
                            count[DataType.Third.ToString()]++;
                            break;
                        case DataType.Fourth:
                            count[DataType.Fourth.ToString()]++;
                            break;
                        default:
                            err.Add(item);
                            break;
                    }
                    continue;
                }
                if (count.Keys.Contains(item))
                {
                    count[item]++;
                }
                else
                {
                    err.Add(item);
                }

            }
            Console.WriteLine("Input data types:");
            foreach (DataType d in Enum.GetValues(typeof(DataType)))
            {
                Console.WriteLine($"{d.ToString()}({(int)d})-{count[d.ToString()]}");
            }
            if (err.Count == 0) return;
            Console.WriteLine("Errors:");
            Console.WriteLine($"Not valid input strings: {string.Join(",",err)}");

        }
    }
}
