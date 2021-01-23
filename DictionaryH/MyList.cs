using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryH
{
    class MyList<T>
    {
        T[] books;
        T[] tempBooks;

        //constructor
        public MyList()
        {
            books = new T[0];
        }

        public void Add(T item)
        {
            tempBooks = books;
            books = new T[books.Length + 1];

            for (int i = 0; i < tempBooks.Length; i++)
            {
                books[i] = tempBooks[i];
            }

            books[books.Length - 1] = item;

            //Console.WriteLine($"{item} added!");
        }

    }
}
