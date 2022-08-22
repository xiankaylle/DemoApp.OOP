
using System.Collections;

namespace DemoConsole.Collections
{
    public class SampleCollections
    {
        public void ExecuteArrayList()
        {
            //Sample A
            //using collection-initializer syntax
            var arraylist = new ArrayList(){
                1,
                "CJ",
                "Felix",
                "Programmer"
            };

            //Sample B
            
            // var arraylist = new ArrayList();

            // arraylist.Add(1);
            // arraylist.Add("CJ");
            // arraylist.Add("Felix");
            // arraylist.Add("Programmer");

            for (int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

        }

        public void ExecuteList()
        {

            var cities = new List<string>();

            cities.Add("Marikina");
            cities.Add("Valenzuela");
            cities.Add("Quezon City");
            cities.Add("Taguig");
            cities.Add(null);// nulls are allowed for reference type list

            string[] newCities = new string[3] { "Tagaytay", "Surigao", "Davao" };

            cities.AddRange(newCities);

            cities.ForEach((city) => {
                Console.WriteLine(city);
            });

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


        }

        public void ArrayListVsList()
        {

             //int total = 0;
             //ArrayList array1 = new ArrayList();
             //array1.Add(1);
             //array1.Add("String"); //No error at compile process

             //foreach (int num in array1)
             //{
             //    total += num; //-->Runtime Error
             //}

             //List<int> list1 = new List<int>();
             //list1.Add(1);
             //list1.Add("String"); //<-- Error at compile process

             //foreach (int num in list1) { 
             
             //    total += num;
             //}

        }
        public void ExecuteSortedList()
        {

            //SortedList of int keys, string values 

            // SortedList<int, string> numberNames = new SortedList<int, string>();
            // numberNames.Add(3, "Three");
            // numberNames.Add(1, "One");
            // numberNames.Add(2, "Two");
            // numberNames.Add(4, null);
            // numberNames.Add(10, "Ten");
            // numberNames.Add(5, "Five");


            /*Creating a SortedList of string keys, string values 
            using collection-initializer syntax*/
            var numberNames = new SortedList<int, string>(){
                {3,"Three"},
                {1,"One"},
                {2,"Two"},
                {4,null},
                {10,"Ten"},
                {5,"Five"}
            };

            foreach (var item in numberNames) Console.WriteLine(item);

        }

        public void ExecuteDictionary()
        {
            var sortedListA = new SortedList<int, string>(){
                {3,"Three"},
                {1,"One"},
                {2,"Two"},
                {4,null},
                {10,"Ten"},
                {5,"Five"}
            };
            var sortedListB = new SortedList<int, string>(){
                {3,"Thredsfse"},
                {1,"asdasdas"},
                {2,"asdasdsa"},
                {4,null},
                {10,"asda"},
                {5,"Fisdasdve"}
            };

            IDictionary<int, SortedList<int, string>> numberNames = new Dictionary<int, SortedList<int,string>>();
            numberNames.Add(1, sortedListA); //adding a key/value using the Add() method
            numberNames.Add(2, sortedListB);
            //numberNames.Add(3, "Three");
            //numberNames.Add(1, "One");

            foreach (var kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }


    }
}
