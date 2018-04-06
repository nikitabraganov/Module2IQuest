using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementationOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Console.WriteLine(myStack.Peek());
            Stack<string> myStringStack = new Stack<string>();
            myStringStack.Push("I love coding");
            Console.WriteLine(myStringStack.Peek());
            myStringStack.Push("I love coding very much");
            myStringStack.Push("I love coding very much and i'm doing it");
            Console.WriteLine(myStringStack.Peek());
            myStringStack.Pop();
            Console.WriteLine(myStringStack.Peek());
            Person myPerson = new Person("Ion", "str. Unirii");
            Stack<Person> personStack = new Stack<Person>();
            personStack.Push(myPerson);
            Console.WriteLine(personStack.Peek());

            Console.ReadKey();
        }
    }
}
