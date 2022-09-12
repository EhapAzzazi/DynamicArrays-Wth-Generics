using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays_Wth_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics<int> DArr = new Generics<int>();
            Generics<Person> People = new Generics<Person>();

            #region Using Dynamic-Arryas With Generics
            Console.WriteLine(DArr.IsEmpty());
            DArr.Add(0);
            DArr.Add(1);
            DArr.Add(2);
            DArr.Add(3);
            DArr.Add(4);
            DArr.RemoveAt(2);
            DArr.Print();
            Console.WriteLine($"Elements Conunt: {DArr.Count()}");
            #endregion
            #region Class like struct With Generics                      
                                                                            //Index
            People.Add(new Person { Fname = "Ehap", Lname = "Azazi" });     // 0
            People.Add(new Person { Fname = "Ali", Lname = "Azazi" });      // 1
            People.Add(new Person { Fname = "Saber", Lname = "Muhammed" }); // 2
            People.Add(new Person { Fname = "Mostafa", Lname = "A7med" });  // 3
            People.Print();
            People.RemoveAt(1);
            People.Print();
            Console.WriteLine($"Elements Conunt: {People.Count()}");
            #endregion
        }
    }
}
