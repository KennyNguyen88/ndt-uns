using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class RadixSort : Sorting
    {
        public void sort()
        {
            bool ketthuc = false;
            int vitrihang = 0;

            List<Queue<int>> thunglist = new List<Queue<int>>();
            for (int i = 0; i < 10; i++)
            {
                Queue<int> q = new Queue<int>();
                thunglist.Add(q);
            }

            while (!ketthuc)
            {
                ketthuc = true;

                foreach (int value in iarr)
                {
                    int soThung = getSoThung(value, vitrihang);
                    if (soThung > 0)
                    {
                        ketthuc = false;
                    }

                    thunglist[soThung].Enqueue(value);
                }

                int i = 0;
                foreach (Queue<int> thung in thunglist)
                {
                    while (thung.Count > 0)
                    {
                        iarr[i] = thung.Dequeue();
                        i++;
                    }
                }

                vitrihang++;
            }
        }

        private int getSoThung(int value, int vitrihang)
        {
            int soThung = (value / (int)Math.Pow(10, vitrihang)) % 10;
            return soThung;
        }
    }
}
