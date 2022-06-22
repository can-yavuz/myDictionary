using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        public void Main(string[] args)
        {
            //usage of original dictionary
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>();
            dictionaryExample.Add(1, "key1");
            dictionaryExample.Add(2, "key2");

            //now I'm gonna call my own dictionary MyDictionary
            //first I will create a class that named MyDictionary

            MyDictionary<int, string> myDictionaryExample = new MyDictionary<int, string>();
            myDictionaryExample.Add(3, "Can Yavuz");



        }
    }

}