using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class QuickSort : Sorting
    {
        public void sort(int left, int right, int isort)
        {
            int i = left;
            int j = right;
            int pivotindex = (i + j) / 2;
            int pivotval = iarr[pivotindex];
            Console.WriteLine("pivot: " + pivotval);
            if (isort == 0) //sap xep tang dan
            {
                while (i <= j)
                {
                    while (iarr[i] < pivotval)
                    {
                        i++;
                    }
                    while (iarr[j] > pivotval)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        Console.WriteLine("i= " + i + " j= " + j);
                        Console.WriteLine("Doi cho " + iarr[i] + " va " + iarr[j]);
                        swap(i, j);
                        swapcnt++;
                        i++;
                        j--;
                    }
                }
                if (left < j)
                {
                    sort(left, j, isort);
                }
                if (i < right)
                {
                    sort(i, right, isort);
                }
            }
            else if(isort == 1) //sap xep giam dan
            {
                while (i <= j)
                {
                    while (iarr[i] > pivotval)
                    {
                        i++;
                    }
                    while (iarr[j] < pivotval)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        swap(i, j);
                        swapcnt++;
                        i++;
                        j--;
                    }
                }
                if (left < j)
                {
                    sort(left, j, isort);
                }
                if (i < right)
                {
                    sort(i, right, isort);
                }
            }
            
        }
    }
}
