using System;
using System.Collections.Generic;

namespace Goo.Extension.System.Collections.Generic
{
    public static class ListRandomExtension
    {
        private static Random rnd = new();

        public static T RandomGet<T>(this List<T> list)
        {
            return list[rnd.Next(0, list.Count)];
        }

        public static List<T> NonRepeatingRandomGet<T>(this List<T> list, int number)
        {
            if (number >= list.Count)
            {
                return list;
            }

            var result = new List<T>();
            var tmp = new List<T>();

            foreach (var l in list)
            {
                tmp.Add(l);
            }

            for (int i = 0; i < number; i++)
            {
                var l = tmp.RandomGet();
                result.Add(l);
                tmp.Remove(l);
            }

            return result;;
        }
    }
}