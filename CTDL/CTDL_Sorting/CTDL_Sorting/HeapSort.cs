using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class HeapSort: Sorting
    {      
        public void sort()
        {
            int i, temp;
            for (i = (size / 2) - 1; i >= 0; i--)
                siftDown(iarr, i, size);
            for (i = size - 1; i >= 1; i--)
            {
                swap(0, i);
                swapcnt++;
                siftDown(iarr, 0, i - 1);
            }
        }
        void siftDown(int[] numbers, int root, int bottom)
        {
            int done, maxChild, temp;
            done = 0;
            while ((root * 2 <= bottom) && (done == 0))
            {
                if (root * 2 == bottom)
                    maxChild = root * 2;
                else if (numbers[root * 2] > numbers[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;
                if (numbers[root] < numbers[maxChild])
                {
                    swap(root, maxChild);
                    swapcnt++;
                    root = maxChild;
                }
                else
                    done = 1;
            }
        }
    }
}
