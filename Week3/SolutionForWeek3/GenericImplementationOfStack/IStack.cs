using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementationOfStack
{
    public interface IStack<T>
    {
        void Push(T element);
        void Pop();
        T Peek();
        bool IsEmpty();
    }
}
