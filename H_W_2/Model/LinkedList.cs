using System.Collections;

namespace Home_work_linked_list.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count = 1;
            }
        }

        public delegate void RemoveDelegat(T data);

        public event RemoveDelegat AddToRemoveList;

        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                }

                var current = Head;
                var previous = Head;

                while (current.Next != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                    }
                    previous = current;
                    current = current.Next;
                }
                AddToRemoveList?.Invoke(data);
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
