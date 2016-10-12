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
        //Add Last        
        public void AddLast(MEMBER item)
        {
            //LinkedList empty ?
            if (this.isEmpty())
            {
                head = item;                
            }
            else
            {
                MEMBER last = findLast();                
                last.next = item;
                item.next = head;                
            }            
        }
        //check list is empty
        public Boolean isEmpty()
        {
            return head == null;
        }
        public MEMBER findLast()
        {
            //find last MEMBER
            MEMBER temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Delete First
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
                    head = null;
                }
            }
        }
        //Delete Last
        //public void DeleteLast()
        //{
        //    if (!this.isEmpty())
        //    {
        //        MEMBER temp = head;
        //        if (temp.next == head) //only 1 MEMBER in list
        //        {
        //            head = null;
        //        }
        //        else
        //        {
        //            MEMBER last = findLast();                    
        //        }
        //    }
        //}
    }
}
