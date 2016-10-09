using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class SelectionSort: Sorting
    {
        public void sort(int sort)
        {
            Console.WriteLine("===Dang sap xep du lieu...");
            if (sort == 0) //Sap xep tang dan
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (iarr[i] > iarr[j])
                        {
                            swap(i, j);
                            swapcnt++;
                        }
                    }
                }
            }
            else if (sort == 1) //Sap xep giam dan
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (iarr[i] < iarr[j])
                        {
                            swap(i, j);
                            swapcnt++;
                        }
                    }
                }
            }
            Console.WriteLine("===Hoan Thanh sap xep du lieu...");
        }
    }
}
