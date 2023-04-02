using System;
using System.Collections.Generic;
using Leetcode_Tasks.Array;
using Leetcode_Tasks.BinaryTree;
using Leetcode_Tasks.String;

namespace Leetcode_Tasks
{
    interface IAnimal
    {

    }

    class Cat : IAnimal
    {
        void Meow() { }
    }

    class Dog : IAnimal
    {
        void Woof() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MergeSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }
    }
}
