﻿using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Lists
    {
        public List<int> List { get; set; }

        public Lists(List<int> list)
        {
            List = list;
        }

        public List<int> CreateNewList(int n)
        {
            List<int> list = List.Distinct().ToList();
            list.Sort();
            List<int> result = new List<int>();
            if (n > list.Count) return list;
            for (int i = 0; i < n; i++)
            {
                result.Add(list[i]);
            }
            return result;
        }

        public static List<int> StrToList(string str)
        {
            return new ArraysHelp().StrToArray<int>(str).ToList();
        }

        public static string ListToStr(List<int> list)
        {
            return new ArraysHelp().ArrayToStr(list.ToArray());
        }
    }
}

