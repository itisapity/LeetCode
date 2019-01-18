using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    class FlattenSolution {

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public void Flatten(TreeNode root) {
            if (root == null) {
                return;
            }

            Flatten(root.left);

            TreeNode temp = root.left;
            if (temp == null) {
                Flatten(root.right);
                return;
            }

            while(true) {
                if (temp.right == null) {
                    Flatten(root.right);
                    temp.right = root.right;
                    break;
                }

                temp = temp.right;

            }


            root.right = root.left;
            root.left = null;

        }




    }
}
