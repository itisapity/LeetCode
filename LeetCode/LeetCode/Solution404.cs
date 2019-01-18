using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    class Solution404 {

        

        public int SumOfLeftLeaves(TreeNode root) {


            return SumOfLeftLeaves(root, false);
        }

        public int SumOfLeftLeaves(TreeNode root, bool isLeft) {

            if (root == null) {
                return 0;
            }

            if ((root.left == null) && (root.right == null)) {
                if (isLeft) {
                    return root.val;
                } else {
                    return 0;
                }
            }

            return SumOfLeftLeaves(root.left, true) + SumOfLeftLeaves(root.right, false);


        }




    }
}
