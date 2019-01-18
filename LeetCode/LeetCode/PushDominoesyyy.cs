using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    class PushDominoesyyy {



        public string PushDominoes(string dominoes) {
            int start, end;
            int bbbb = 0;



            char[] arr = dominoes.ToArray();


            while (true) {

                start = findFirst(bbbb, arr);

                if (start < 0) {
                    break;
                }

                end = findFirst(start + 1, arr);
                if (end < 0) {
                    break;
                }

                if ('R'.Equals(arr[start]) && 'L'.Equals(arr[end])) {
                    int i = start;
                    int j = end;

                    while (i < j) {

                        arr[i] = 'R';
                        arr[j] = 'L';

                        i++;
                        j--;
                    }

                    if (i == j) {
                        arr[i] ='M';
                    }

                    bbbb = end + 1;
                }

                bbbb = end;

            }




            for(int i = 1; i < arr.Length; i++) {
                if ('.'.Equals(arr[i]) && 'R'.Equals(arr[i - 1])) {
                    arr[i] = 'R';
                }
            }

            for (int i = arr.Length - 2; i >= 0; i--) {
                if ('.'.Equals(arr[i]) && 'L'.Equals(arr[i + 1])) {
                    arr[i] = 'L';
                }
            }





            String result = "";

            for (int i = 0; i < arr.Length; i++) {
                if ('M'.Equals(arr[i])) {
                    arr[i] = '.';
                }
                result = result + arr[i];
            }


            return result;


        }

        public int findFirst(int point, char[] arr) {

            for (int i = point; i < arr.Length; i++) {
                if (!'.'.Equals(arr[i]) && !'M'.Equals(arr[i])) {
                    return i;
                }
            }

            return -1;

        }

        
    }
}
