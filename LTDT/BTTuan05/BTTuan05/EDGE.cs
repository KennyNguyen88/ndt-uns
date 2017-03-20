using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan05
{
    class EDGE
    {
        public int vertex_start;
        public int vertex_end;
        public int value;
        public EDGE()
        {
            vertex_start = -1;
            vertex_end = -1;
            value = -1;
        }
        public EDGE(int v_start, int v_end, int v_value)
        {
            vertex_start = v_start;
            vertex_end = v_end;
            value = v_value;
        }
        public void print()
        {
            Console.WriteLine(vertex_start + " - " + vertex_end + ": " + value);
        }
    }
}
