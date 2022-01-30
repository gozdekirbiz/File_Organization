using System;
using System.Collections.Generic;
using System.Text;

namespace FileOrg
{
    public class Node
    {
        public int key, ind, occupy;
        public Node left, right, parent = null;
    }
}
