using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode {
    class Solution856 {

        // (()(())) 6
        public int ScoreOfParentheses(string S) {

            S = "(" + S + ")";

            Stack<string> st = new Stack<string>();

            for(int i = 0; i < S.Length; i++) {

                string item = S.Substring(i, 1);

                if (item == "(") {
                    st.Push(item);
                } else   {

                    int temp = 0;

                    while(true) {
                        string pp = st.Pop();

                        if (pp == "(") {
                            if (temp == 0) {
                                st.Push("1");
                                break;
                            } else {
                                st.Push(Convert.ToString(temp * 2));
                                break;
                            }
                            
                        } else {
                            temp = temp + Convert.ToInt32(pp);
                        }
                    }


                }
            }




            return Convert.ToInt32(st.Pop()) / 2;
        }

    }
}
