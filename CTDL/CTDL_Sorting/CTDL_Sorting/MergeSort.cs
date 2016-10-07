using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class MergeSort : Sorting
    {
        public int[] append(int[] a, int[] b)
        {
            int[] result = new int[(a.Length + b.Length)];
            int i = 0;
            for (int j = 0; j < a.Length; j++)
            {
                result[i] = a[j];
                i++;
            }

            for (int j = 0; j < b.Length; j++)
            {
                result[i] = b[j];
                i++;
            }
            return result;
        }

        public int[] merge(int[] a, int[] b, int isort)
        {
            int[] s = new int[a.Length+b.Length];
            int al = a.Length;
            int bl = b.Length;
            int acurrent = 0;
            int bcurrent = 0;
            int i = 0;
            while (al > 0 && bl > 0)
            {
                if (isort == 0)
                {
                    if (a[acurrent] < b[acurrent])
                    {
                        s[i] = a[acurrent];
                        acurrent++;
                        al--;
                        i++;
                    }
                    else
                    {
                        s[i] = b[bcurrent];
                        bcurrent++;
                        bl--;
                        i++;
                    }
                }
                else
                {
                    if (a[acurrent] > b[acurrent])
                    {
                        s[i] = a[acurrent];
                        acurrent++;
                        al--;
                        i++;
                    }
                    else
                    {
                        s[i] = b[bcurrent];
                        bcurrent++;
                        bl--;
                        i++;
                    }
                }
            }
            while(al >0)
            {
                s[i] = a[acurrent];
                acurrent++;
                al--;
                i++;

            }
            return s;
        }

        public int[] sort(int[] input, int isize, int isort)
        {
            
            int[] result = new int[isize];
            int[] leftArr;
            int[] rightArr;
            int middle = isize / 2;
            leftArr = new int[middle];
            rightArr = new int[isize - middle];

            int i = 0; //input index
            for (int j = 0; j < middle; j++)
            {
                leftArr[j] = input[i];
                i++; 
            }
            for (int j = 0; j < isize - middle; j ++)
            {
                rightArr[j] = input[i];
                i++;
            }
            leftArr = sort(leftArr, leftArr.Length, isort);
            rightArr = sort(rightArr, rightArr.Length, isort);
            if (isort==0) //sap xep tang dan
            {
                if (leftArr[leftArr.Length - 1] <= rightArr[0])
                {
                    return append(leftArr, rightArr);
                }
            }
            else //sap xep giam dan
            {
                if (leftArr[leftArr.Length - 1] >= rightArr[0])
                {
                    return append(leftArr, rightArr);
                }
            }
            result = merge(leftArr, rightArr, isort);
            return result;
        }
    }
}
