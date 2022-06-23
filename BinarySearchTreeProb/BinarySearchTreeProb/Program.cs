// See https://aka.ms/new-console-template for more information

using BinarySearchTreeNameSpace;
using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Problem");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            ///UC1: Add the node in the tree

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);

            //UC2:Find the size of tree

            int Size = BinaryTree.GetSize();
            Console.WriteLine(Size);

            //UC3:Serach node through the tree

            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);


        }
    }
}

//UC-3
//Ability to search 63 in the Binary Tree
//- Implement Search method and recursively search left or right nodes to find 63

//Result
//Welcome To Binary Search Tree Problem
//UC_1 = Creating BST, no output.
//UC_2 =  13
//UC_3 = True