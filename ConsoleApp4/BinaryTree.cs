using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

    // A Binary Tree node
    public class Node
    {
        public string data;
        public Node left, right;

        public Node(string value)
        {
            data = value;
            left = right = null;
        }
    }
    public class BinaryTree
    {

        // Root of the Binary Tree
        public Node root;

        public Node findOutLCM(string e1, string e2)
        {
            return findOutLCM(root, e1, e2);
        }

        // This function returns pointer to LCM (Lowest Common Manager)
        // of two given employyes e1 and e2. This
        // function assumes that e1 and e2 are
        // present in Binary Tree
        Node findOutLCM(Node node, string e1, string e2)
        {

            // Base case
            if (node == null)
                return null;

            // If either e1 or e2 matches with
            // root's key, report the presence
            // by returning root (Note that if
            // a key is ancestor of other,
            // then the ancestor key becomes LCM
            if (node.data == e1 || node.data == e2)
                return node;

            // Look for keys in left and right subtrees
            Node left_lcm = findOutLCM(node.left, e1, e2);
            Node right_lcm = findOutLCM(node.right, e1, e2);

            // If both of the above calls return Non-NULL,
            // then one key is present in once subtree
            // and other is present in other, So this
            // node is the LCM
            if (left_lcm != null && right_lcm != null)
                return node;

            // Otherwise check if left subtree or
            // right subtree is LCM
            return (left_lcm != null) ? left_lcm : right_lcm;
        }
    }
}
