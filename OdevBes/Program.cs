using System;

namespace OdevBes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("3858494785" ,"Merve");
            dictionary.Add("3874987329" ,"Zeliha");
            dictionary.Add("9890239322","Oğuz");

            Console.WriteLine(dictionary.Count);


            
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("3858494785","Merve");
            myDictionary.Add("3874987329","Zeliha");
            myDictionary.Add("9890239322","Oğuz");
            myDictionary.Add("9890239322","Oğuz"); 

            Console.WriteLine(myDictionary.Count);
        }
    }
}
