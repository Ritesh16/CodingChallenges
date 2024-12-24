using StackDataType.Types.Interfaces;

namespace StackDataType.Types
{
    public class StackUsingLinkedList : IStack<int> 
    {
        private LinkedListDataType.Types.Interfaces.ILinkedList<int> linkedList;
        private int _count = 0;
        public int Count
        {
            get
            {
                return _count;
            }
        }

        public StackUsingLinkedList()
        {
            linkedList = new LinkedListDataType.Types.LinkedList<int>();
        }
        public bool IsEmpty()
        {
            if (linkedList.Count() == 0)
            {
                return true;
            }

            return false;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return default(int);
            }

            return linkedList.Head.Value;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return default(int);
            }

            var head = linkedList.Head;
            linkedList.Head = linkedList.Head.Next;
            _count--;

            return head.Value;
        }

        public void Push(int value)
        {
            linkedList.Add(value);
            _count++;
        }
    }
}
