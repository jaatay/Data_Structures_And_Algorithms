﻿using System;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree values");
			TestBuzz();
			Console.WriteLine("Press any key to exit");
        }

		/// <summary>
		/// test tree method
		/// </summary>
		public static void TestBuzz()
		{
			BinaryTree testTree = new BinaryTree();

			Node node1 = new Node("1");
			Node node2 = new Node("3");
			Node node3 = new Node("4");
			Node node4 = new Node("5");
			Node node5 = new Node("7");
			Node node6 = new Node("15");

			node1.LeftChild = node2;
			node1.RightChild = node3;
			node2.LeftChild = node4;
			node3.RightChild = node5;
			node5.LeftChild = node6;

			testTree.FizzBuzzTree(node1);
		}
    }
}
