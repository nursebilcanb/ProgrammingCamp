using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerHomework
{
    class CustomerManager
    {
        public void Add(string name,string surName,int ıd)
        {
            Console.WriteLine($"{name} {surName} has added");

        }

        public void List(string name,string surName)
        {
         Console.WriteLine($"Our customers: {name} {surName}");

        }


        public void Cancel(string name,string surName)
        {
            Console.WriteLine($"{name} {surName} has canceled!");

        }


    }
}
