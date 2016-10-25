using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_LinkedList
{
    class CIRCLE
    {
        public MEMBER head;
        public CIRCLE()
        {

        }
        public CIRCLE(MEMBER _head)
        {
            head = _head;
        }     
        public void AddLast(MEMBER item)
        {
            if (this.isEmpty())
            {
                head = item;
                item.next = head;                
            }
            else
            {
                MEMBER last = findLast();                
                last.next = item;
                item.next = head;                
            }            
        }
        public Boolean isEmpty()
        {
            return head == null;
        }
        public MEMBER findLast()
        {
            //find last MEMBER
            MEMBER last = head;
            while (last.next != head)
            {
                last = last.next;
            }
            return last;
        }
        public MEMBER findBeforeLast()
        {
            MEMBER last = head;
            MEMBER before = head;
            while (last.next != head)
            {
                before = last;
                last = last.next;
            }
            return before;
        }
        public MEMBER findNext(MEMBER x, int distance)
        {
            MEMBER result = x;            
            for (int i = 0; i <= distance; i++)
            {
                result = result.next;
            }
            return result;
        }
        public MEMBER find(int index)
        {
            index--;

            MEMBER result = head;
            for (int i = 0; i < index; i ++)
            {
                result = result.next;
            }
            return result;
        }
        public void DeleteFirst()
        {
            if (!this.isEmpty())
            {
                MEMBER temp = head;
                if (temp.next == head) //only 1 MEMBER in list
                {
                    head = null;
                }
                else
                {
                    MEMBER last = findLast();
                    last.next = head.next;
                    head = head.next;
                }
            }
        }
        public void DeleteLast()
        {
            if (!this.isEmpty())
            {
                MEMBER temp = head;
                if (temp.next == head) //only 1 MEMBER in list
                {
                    head = null;
                }
                else
                {
                    MEMBER before = findBeforeLast();
                    before.next = head;
                }
            }
        }
        public Boolean isFirst(MEMBER member)
        {
            if (!this.isEmpty())
            {
                if (head == member)
                    return true;
            }
            return false;
        }
        public Boolean isLast(MEMBER member)
        {
            if (!this.isEmpty())
            {
                if (member.next == head)
                    return true;
            }
            return false;
        }
        public void Delete(MEMBER d)
        {
            if (!this.isEmpty())
            {
                if (this.isFirst(d))
                {
                    DeleteFirst();
                }
                else if (this.isLast(d))
                {
                    DeleteLast();
                }
                else
                {
                    MEMBER temp = head;
                    //find member before member which want to be deleted
                    while(temp.next != d)
                    {
                        temp = temp.next;
                    }
                    temp.next = d.next;
                    d = null;
                }
            }
        }
        public void ReadInput(string filename)
        {
            int n = 0;
            String[] a = null;
            int x = Util.ReadFile(filename, ref a, ref n);
            if (x == 0)
            {
                Console.WriteLine("Xay ra loi khi doc file. Vui long kiem tra lai file input !");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                MEMBER member = new MEMBER(a[i]);
                this.AddLast(member);
            }
        }
        public void circlePrint()
        {
            if (!isEmpty())
            {
                int i = 1;
                MEMBER last = head;
                while (last.next != head)
                {
                    Console.WriteLine(i + ". " + last.name);
                    last = last.next;
                    i++;
                }
                Console.WriteLine(i + ". " + last.name);
            }                           
        }
        public int circleCnt()
        {
            int i = 0;
            if (head != null)
            {
                i++;
                MEMBER last = head;
                while (last.next != head)
                {
                    last = last.next;
                    i++;
                }
            }
            return i;
        }
        public Boolean canContinue(int distance)
        {
            if (circleCnt() <= distance)
            {
                return false;
            }
            return true;
        }
        public void play(MEMBER first, int distance)
        {
            MEMBER x = first;
            MEMBER y = first;
            while (canContinue(distance))
            {
                y = findNext(x, distance);
                Delete(x);
                x = y;
            }
        }

    }
}
