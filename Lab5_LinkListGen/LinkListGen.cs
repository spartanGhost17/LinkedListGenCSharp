using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkListGen
{
    class LinkListGen<T> where T : IComparable
    {

        private LinkGen<T> list;

        public LinkListGen()
        {


        }

        public void AddItem(T item)
        {

            list = new LinkGen<T>(item, list);

        }

        public string DisplayList()
        {
            LinkGen<T> temp = list;

            string space = "";

            while (temp != null)
            {

                space += Convert.ToString(temp.Data) + " ";

                //System.Console.WriteLine(space);

                temp = temp.Next;

            }


            return space;


        }

        public int NumberOfItems()
        {
            LinkGen<T> temp = list;

            int nbrItems = 0;

            while (temp != null)
            {

                nbrItems++;

                temp = temp.Next;

            }

            return nbrItems;

        }
        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;

            Boolean istrue = false;

            while (temp != null)
            {
                if (temp.Data.CompareTo(item) == 0)
                {

                    istrue = true;

                }
                temp = temp.Next;
            }

            return istrue;

        }
        public void RemoveItem(T item)
        {

            LinkGen<T> temp = list;

            LinkGen<T> previous = null;
            if (IsPresentItem(item))
            {

                while (temp != null)
                {
                    if (item.CompareTo(temp.Data) == 0)
                    {

                        if (previous == null)
                        {

                            list = temp.Next;

                            System.Console.WriteLine("item was deleted at the start of the list");

                        }

                        else
                        {

                            previous.Next = temp.Next;

                            System.Console.WriteLine("item was found and deleted");


                        }
                    }

                    previous = temp;

                    temp = temp.Next;


                }
            }

            else
            {
                System.Console.WriteLine("the requested item is not in this list ");

            }


        }

        public void AppendItem(T item)//adds item at the end of the list check if next node is null
        {

            LinkGen<T> temp = list;
            if (temp == null)
            {

                temp = new LinkGen<T>(item);

            }
            else
            {
                while (temp.Next != null)
                {

                    temp = temp.Next;

                }

                temp.Next = new LinkGen<T>(item);
            }


        }

        public void Concat(LinkListGen<T> list2)
        {
            LinkGen<T> temp = list2.list;
            while (temp != null)
            {

                AppendItem(temp.Data);
                temp = temp.Next;

            }



        }

        public void Copy(LinkListGen<T> list2)
        {

            LinkGen<T> temp = list2.list;
            System.Console.WriteLine("our data " + temp.Data);
            LinkGen<T> temp2 = list;
            System.Console.WriteLine("our data "+temp2.Data);
             while ((temp != null))
             {

                 temp2.Data = temp.Data;
                 temp2 = temp2.Next;
                 temp = temp.Next;

             }

        }

        public void InsertInOrder(T item)
        {

            LinkGen<T> temp = list;

            LinkGen<T> previous = null;


            //if == 0 than objects are equal
            //
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) < 0)
                {

                    if (previous == null)
                    {

                        AddItem(item);//adds item if at start of the list
                        break;

                    }

                    else
                    {
                        previous.Next = new LinkGen<T>(item, temp);
                        //AddItem(item);

                        break;
                    }


                }
                    previous = temp;

                    temp = temp.Next;
            }

        }

        public void Sort()
        {

           // LinkGen<T> temp = list;
            LinkGen<T> temp2 = list;
            T Swapp ;  // don't forget T item is used instead of int because T is a generic type 
            //int count = NumberOfItems();
            bool restartCount = true;
            //int i = 0;
            while(restartCount)//while still need to check keep going 
            {
                restartCount = false; //set switch to false in case we no longer have to check
                System.Console.WriteLine("new count");
                while(!restartCount && temp2.Next !=null)
                {
                    
                   // System.Console.WriteLine("current " +temp2.Data);
                   // System.Console.WriteLine("next item "+temp2.Next.Data);
                    //if current data is greater or equal to next data
                    //increment count
                        if (temp2.Data.CompareTo(temp2.Next.Data) <= 0)
                        {

                          temp2 = temp2.Next;

                        }

                        //else if current data is less than next one in terms of succesion 
                        //do this

                         else //(temp2.Data.CompareTo(temp2.Next.Data) < 0)
                         {
                              Swapp = temp2.Data; //store current data in generic T variable
                              //set currrent data to next data and not the whole link!
                              //don't forget link is an object if we altere it we lose the pointer the other items 
                              //inside the collection
                              temp2.Data = temp2.Next.Data;  
                              //set next link data to 'swapp' which is the temp Generic T item
                             // System.Console.WriteLine("this is temp2 before the end of the cound " + temp2.Data);
                              temp2.Next.Data = Swapp;
                              //System.Console.WriteLine("this is temp2 before the end of the cound " + temp2.Next.Data);
                              restartCount = true; //if the count restart is true then restart while loop
                         }
                   // temp2 = temp2.Next;
                    
                }

                temp2 = list; //reset list 

            }



        }

    }
}
