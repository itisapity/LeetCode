using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode {

    class Solution870 {

        //输入：A = [2,7,11,15], B = [1,10,4,11]
        //输出：[2,11,7,15]
        public int[] AdvantageCount(int[] A, int[] B) {

            int[] res = new int[A.Length];

            Array.Sort(A);

            List<int> lsA = new List<int>();
            for (int i = 0; i < A.Length; i++) {
                lsA.Add(A[i]);
            }

            for (int i = 0; i < B.Length; i++) {
                if (B[i] < lsA[0] || B[i] >= lsA[lsA.Count-1]) {
                    res[i] = lsA[0];
                    lsA.RemoveAt(0);
                }
                else {
                    for (int j = 0; j < lsA.Count; j++) {
                        if (B[i] < lsA[j]) {
                            res[i] = lsA[j];
                            lsA.RemoveAt(j);
                            break;
                        }
                    }
                }
            }

            return res;



        }

    }

       


}
