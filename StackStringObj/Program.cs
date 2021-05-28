using System;
using System.Collections.Generic;
/*
 * first we will take the string from the user
 * then we will take the display the elemts 
 * then we dont have insertion method in stacks so we will do that manually 
 * so first we will ask the user where we want to insert the element 
 * then we will use another stack to keep then elements then we will use the user to given the element to insert 
 * after that we will add the elements in temp to our main stack 
 * */

namespace StackStringObj
{
    class Program
    {
       static  Stack<string> s = new Stack<string>();
        static void Main(string[] args)
        {
            s.Push("string1");
            s.Push("string2");
            s.Push("string4");
            s.Push("string5");
            s.Push("stringFeature6");

            Display(s);
            //after displaying we got the string5 as first input
            Console.WriteLine("please enter where we want to element the elemet ");
            string ele = Console.ReadLine();
            Stack<string> tempStr = ElementInsertion(ele, s);
            Console.WriteLine("===========================");
            Display(tempStr);
            Console.WriteLine("===========================");
            //displaying the tempary list
            Display(s);
            Console.WriteLine("please enter the element to insert in list");
            string insert = Console.ReadLine();
            InsertingElement(tempStr, insert);
            //to display the list with inserted elements
            Display(s);


        }
        //this method is used for displaying the elements
        static void Display(Stack<String> s) { 
            foreach(string s1 in s)
            {
                Console.WriteLine(s1);
            }
        }

        //this method is used for creating the temp stack
        static Stack<string> ElementInsertion(string str, Stack<String> s)
        {
            Stack<String> temp = new Stack<string>();
            if (s.Contains(str))
            {
                Boolean flag = true;
                do
                {
                    String str1 = s.Pop();
                    if (str.Equals(str1))
                    {
                        temp.Push(str);
                        flag = false;
                    }
                    else
                    {
                        temp.Push(str1);
                        flag = true;
                    }
                } while (flag);
                
                   
            }
            return temp;

        }
        //this method is used fo the inserting and combinig the stack  
        static void InsertingElement(Stack<string> temp,string str)
        {
            s.Push(str);
            int count = temp.Count;
            
            for(int i=0;i<count;i++)
            {
                String ele=temp.Pop();
                s.Push(ele);
                
            }

        }
       
    }
}
