using System;
using System.Collections.Generic;

namespace _20Ocak2021Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> customerManager = new MyDictionary<string, string>();
            customerManager.Add("Customer A", "12345154154");
            customerManager.Add("Customer B", "30565045454");
            customerManager.List();


        }
    }

    class MyDictionary<T1, T2>
    {
        T1[] _name;
        T1[] _tempName;
        T2[] _number;
        T2[] _tempNumber;
        public MyDictionary()
        {
            _name = new T1[0];
            _number = new T2[0];
        }
        public void Add(T1 customerName, T2 creditNumber)
        {
            _tempName = _name;
            _name = new T1[_name.Length + 1];
            _tempNumber = _number;
            _number = new T2[_number.Length + 1];
            for (int i = 0; i < _tempNumber.Length; i++)
            {
                _number[i] = _tempNumber[i];
            }
            _number[_number.Length - 1] = creditNumber;

            for (int i = 0; i < _tempName.Length; i++)
            {
                _name[i] = _tempName[i];
            }
            _name[_name.Length - 1] = customerName;
        }
        public void List()
        {
            for (int i = 0; i < _name.Length; i++)
            {
                Console.WriteLine("Customer Name: {0} and Credit Number: {1}", _name[i], _number[i]);

            }
        }
    }
}
