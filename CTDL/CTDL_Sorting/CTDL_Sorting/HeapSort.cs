using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class HeapSort : Sorting
    {
        public void sort(int sorttype) //0: tang dan , 1: giam dan
        {
            int i,j;
            for (i = (size / 2) - 1; i >= 0; i--)
            {                
                siftDown(iarr, i, size - 1, sorttype);
            }
            for (j = size - 1; j > 0; j--)
            {                
                swap(0, j);
                swapcnt++;
                siftDown(iarr, 0, j - 1, sorttype);
            }
        }
        void siftDown(int[] numbers, int root, int bottom, int sorttype)
        {            
            int tmp = iarr[root];
            int succ = root * 2 + 1;
            if (sorttype == 0)
            {
                if (succ < bottom && iarr[succ] < iarr[succ + 1])
                {
                    succ++;
                }
                while (succ <= bottom && tmp < iarr[succ])
                {
                    iarr[root] = iarr[succ];
                    root = succ;
                    succ = succ * 2 + 1;
                    if (succ < bottom && iarr[succ] < iarr[succ + 1])
                    {
                        succ++;
                    }
                }
                iarr[root] = tmp;
            }
            else
            {
                if (succ < bottom && iarr[succ] > iarr[succ + 1])
                {
                    succ++;
                }
                while (succ <= bottom && tmp > iarr[succ])
                {
                    iarr[root] = iarr[succ];
                    root = succ;
                    succ = succ * 2 + 1;
                    if (succ < bottom && iarr[succ] > iarr[succ + 1])
                    {
                        succ++;
                    }
                }
                iarr[root] = tmp;
            }

            
        }
    }
}
