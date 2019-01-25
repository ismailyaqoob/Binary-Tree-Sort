using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSort
{
    //Class containing data with the reference of left node and right node.
    class BSTNode
    {
        public int data;
        public BSTNode leftnode, rightnode;
        public BSTNode()
        {
            leftnode = null;
            rightnode = null;
        }
    }
}
