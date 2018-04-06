using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementationOfStack
{
    public class Stack<T>
    {
        internal class Element
        {
            public Element next;
            public T data;
        }
        Element head;

        public T Peek()
        {
            Element current = head;
            return current.data;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing to pop");
            }
            else
            {
                Element temporaryElement = head;
                head = head.next;
                temporaryElement.next = null;
            }
        }

        public void Push(T value)
        {
            Element toAdd = new Element();
            toAdd.data = value;
            toAdd.next = head;

            head = toAdd;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else return false;
        }
    }
}
