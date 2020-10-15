using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach (var item in Todos)
            {
                Console.WriteLine(item);
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}