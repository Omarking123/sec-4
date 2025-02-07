namespace sec_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  video 2
            //Hashtable phonebook = new Hashtable();
            //phonebook.Add("ahmed", 111111);
            //phonebook.Add("ali", 22222);
            //phonebook.Add("amr", 33333);
            ////phonebook.Add(null, 111111);

            ////Console.WriteLine(phonebook.IsFixedSize);
            ////Console.WriteLine(phonebook.IsReadOnly);

            //phonebook["ahmessed"] = 123123123;
            //var flag =  phonebook.Contains("ahmed");
            //Console.WriteLine(flag);


            //foreach (var item in phonebook.Keys)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //foreach (var item in phonebook)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region  video 3
            //Dictionary<string, long> phoneBook = new Dictionary<string, long>();


            //phoneBook.Add("ahmed", 111111);
            //phoneBook.Add("ali", 22222);
            //phoneBook.Add("amr", 33333);
            ////phonebook.Add(2222, "amr");


            ////var flag = phoneBook.Remove("ahmesddd", out long result);

            ////Console.WriteLine(flag);
            ////Console.WriteLine(result);
            //foreach (KeyValuePair<string, long > item in phoneBook)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region video 4

            //HashSet<string> Names = new HashSet<string>();

            //Names.Add("ahmed");
            //Names.Add("ali");
            //Names.Add("amr");

            //foreach(var item in Names)
            //{
            //    Console.WriteLine(Names);
            //}

            #endregion

            #region video 5

            //SortedDictionary<int, string> paris = new SortedDictionary<int, string>();

            //paris.Add(23 ,"omar");
            //paris.Add(12, "ahmed");
            //paris.Add(10, "ali");
            //paris.Add(1, "mohamed");

            //foreach(var item in paris)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region video 6 

            SortedList<int, string> paris = new SortedList<int, string>();
            //paris.SetValueAtIndex(1);
            paris.Add(1,"ahmed");
            paris.Add(2, "alio");
            paris.Add(3, "omar");
            paris.Add(4, "mohead");

            //SortedList<int> value = new SortedList<int>();

            #endregion
        }
    }
}
