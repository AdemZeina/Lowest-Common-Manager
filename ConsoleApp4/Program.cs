using System;
using System.Collections;
using System.Collections.Generic;
using static ConsoleApp4.Program;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("write a function to find out the lowest common manager between two employees");


            BinaryTree tree = new BinaryTree();

            tree.root = new Node("VP");

            tree.root.left = new Node("GM1");
            
            tree.root.left.left = new Node("TM1");
            tree.root.left.left.left = new Node("IC1");
            tree.root.left.left.right = new Node("IC2");

            tree.root.left.right = new Node("TM2");
            tree.root.left.right.left = new Node("IC3");
   

            tree.root.right = new Node("GM2");
            tree.root.right.right = new Node("TM3");
            tree.root.right.right.right = new Node("IC4");
            
            //tree.root.right = new Node("GM3");
            //tree.root.right.right = new Node("TM4");


            tree.root.Print();
            Console.WriteLine();
            Console.WriteLine("write a function to find out the lowest common manager between two employees");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("findOutLCM(IC1, IC2) = " +
                              tree.findOutLCM("IC1", "IC2").data);
            Console.WriteLine("findOutLCM(IC1, IC3) = " +
                              tree.findOutLCM("IC1", "IC3").data);
            Console.WriteLine("findOutLCM(IC1, IC4) = " +
                              tree.findOutLCM("IC1", "IC4").data);
            Console.WriteLine("findOutLCM(IC3, IC4) = " +
                              tree.findOutLCM("IC3", "IC4").data);


            Console.ReadKey();


        }
    }
}



