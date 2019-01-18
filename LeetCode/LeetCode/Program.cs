using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode {
    class Program {


        static void Main(string[] args) {

            TreeNode tree0 = new TreeNode(0);
            TreeNode tree1 = new TreeNode(5);
            TreeNode tree2 = new TreeNode(2);

            tree0.left = tree1;
            tree0.right = tree2;

            Solution870 solution = new Solution870();
            int[] res = solution.AdvantageCount(new int[] { 2,0,4,1,2}, new int[] { 1,3,0,0,2});

        }

        

    }
}
