using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp_Part02
{
    internal class GenericStack<T>
    {
        private List<T> _stack;

        public GenericStack()
        {
            _stack = new List<T>();
        }

        // Push an item onto the stack
        public void Push(T item)
        {
            _stack.Add(item);
        }

        // Pop an item from the stack
        public T Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T item = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return item;
        }

        // Peek the top item without removing it
        public T Peek()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _stack[_stack.Count - 1];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }

        // Get the number of items in the stack
        public int Count()
        {
            return _stack.Count;
        }
    }
}
