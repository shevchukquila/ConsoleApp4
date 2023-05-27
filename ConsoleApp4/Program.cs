using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> collection = new List<double>();

        collection.Add(1.1);
        collection.Add(2.2);
        collection.Add(3.3);
        collection.Add(4.4);
        collection.Add(5.5);
        collection.Add(6.6);

        Console.WriteLine("Элементы коллекции:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        collection[0] = 0.0;

        Console.WriteLine("Элементы коллекции после замены первого элемента:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        double[] array = { 7.7, 8.8, 9.9, 10.10, 11.11 };
        collection.AddRange(array);

        Console.WriteLine("Элементы коллекции после добавления массива:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        int count = collection.Count;
        Console.WriteLine("Количество элементов в коллекции: " + count);

        collection.RemoveAt(0);

        Console.WriteLine("Элементы коллекции после удаления первого элемента:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        collection.Remove(3.3);

        Console.WriteLine("Элементы коллекции после удаления элемента со значением 3.3:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        count = collection.Count;
        Console.WriteLine("Количество элементов в коллекции: " + count);

        collection.Sort();

        Console.WriteLine("Элементы коллекции после сортировки по возрастанию:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        collection.Reverse();

        Console.WriteLine("Элементы коллекции после сортировки по убыванию:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}