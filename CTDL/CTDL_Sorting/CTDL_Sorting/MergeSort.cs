using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class MergeSort : Sorting
    {       
        public void sort(int left, int right)
        {
            if (right <= left) { return; }
            int mid = (right + left) / 2;
            sort(left, mid);
            sort(mid + 1, right);
            merge(left, mid, right);

        }

        public void merge(int left, int mid, int right)
        {
            int i, j;            
            int[] aux = new int[size];

            for (i = mid + 1; i > left; i--)
            {
                aux[i - 1] = iarr[i - 1];
            }
            for (j = mid; j < right; j++)
            {
                aux[right + mid - j] = iarr[j + 1];
            }
            for (int k = left; k <= right; k++)
            {
                if (aux[j] < aux[i])
                {
                    iarr[k] = aux[j--];
                    swapcnt++;
                }
                else
                {
                    iarr[k] = aux[i++];
                    swapcnt++;
                }
            }
        }
    }
}
