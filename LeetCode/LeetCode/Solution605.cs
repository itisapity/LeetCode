using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode {
    class Solution605 {

        public bool CanPlaceFlowers(int[] flowerbed, int n) {
            if (n==0) {
                return true;
            }

            if(flowerbed.Length == 1) {
                return flowerbed[0] == 0 && n <= 1;
            }

            if (flowerbed[0] == 0 && flowerbed[1] == 0) {
                flowerbed[0] = 1;
                n--;
            }

            for(int i = 1; i < flowerbed.Length - 1; i++) {
                if (flowerbed[i] == 0 & flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0) {

                    flowerbed[i] = 1;
                    n--;
                    i++;
                }
            }

            if (flowerbed[flowerbed.Length-1] == 0 && flowerbed[flowerbed.Length-2] == 0) {
                flowerbed[flowerbed.Length - 1] = 1;
                n--;
            }

            return n <= 0;

        }

    }
}
