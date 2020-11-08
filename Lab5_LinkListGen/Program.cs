using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkListGen
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkListGen <int> myList = new LinkListGen<int>();

            LinkListGen<int> myList2 = new LinkListGen<int>();

            LinkListGen<int> test = new LinkListGen<int>();

            myList.AddItem(90);
            myList.AddItem(86);
            myList.AddItem(57);

            myList2.AddItem(102);
            myList2.AddItem(100);
            myList2.AddItem(97);

            test.AddItem(41);
            test.AddItem(52);
            test.AddItem(57);
            test.AddItem(82);
            test.AddItem(90); //41 52 57 82 90

            System.Console.WriteLine(myList.IsPresentItem(8));
            myList.RemoveItem(86);
            //myList.AppendItem(88);
            System.Console.WriteLine(myList.DisplayList());
            System.Console.WriteLine(myList.NumberOfItems());
            //myList.Concat(myList2);
            //System.Console.WriteLine(myList.DisplayList());
            //System.Console.WriteLine(myList.NumberOfItems());
          //  myList.InsertInOrder(83);
             System.Console.WriteLine(myList.DisplayList());
             System.Console.WriteLine(test.DisplayList());
             test.Sort();
             System.Console.WriteLine(test.DisplayList());
            //  
             myList2.Copy(myList);
             System.Console.WriteLine("this is the new list "+myList2.DisplayList());
             System.Console.WriteLine("old altered list "+myList.DisplayList());
             Console.ReadKey();

        }
    }
}
