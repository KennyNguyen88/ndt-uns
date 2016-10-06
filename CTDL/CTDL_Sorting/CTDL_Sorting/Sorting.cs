using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class Sorting
    {
        public int[] iarr;
        public int size;
        public Sorting()
        {
            size = 0;
            iarr = new int[] { };
        }
        public Sorting(int[] a, int n)
        {
            size = n;
            iarr = a;
        }

        public void GhiDuLieu(String output)
        {
            Console.WriteLine("===Dang ghi du lieu...");
            Util.WriteFile(output, iarr, size);
            Console.WriteLine("===Hoan thanh ghi du lieu...");
        }
        public int  DocDuLieu(String input)
        {
            Console.WriteLine("===Doc du lieu dau vao...");
            int result = Util.ReadFile(input, ref iarr, ref size);
            Console.WriteLine("So luong phan tu: " + size);
            Console.WriteLine("===Hoan thanh doc du lieu dau vao...");
            return result;
        }


        public void swap(int index1, int index2)
        {
            int temp;
            temp = iarr[index1];
            iarr[index1] = iarr[index2];
            iarr[index2] = temp;
        }
    }
}
