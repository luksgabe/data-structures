using binary_tree_sample.Models;

namespace binary_tree_sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(3);
            binaryTree.Add(5);
            binaryTree.Add(2);
            binaryTree.Add(4);
            binaryTree.Add(6);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(5);
            binaryTree.Remove(3);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{

        //    FizzBuss.fizzBuzz(15);
        //}
    }
}