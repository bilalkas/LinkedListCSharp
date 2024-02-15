using System;

namespace List
{
	public class LinkedList<T>
	{
		
		Values? Anfang = null;
		Values? Ende = null;

		public class Values
		{
			public T Data { get; set; }
			public Values? Next { get; set; }

			public Values (T Data)
			{
				this.Data = Data;
			}
		}

        public class ListIterator : Iterator<T>
        {
            private Values? temp { get; set; }

            public bool HasNext()
            {
                return temp != null;
            }

            public T Next()
            {
                Values? current = temp;

                if (current == null)
                {
					throw new Exception();
                }

                temp = temp.Next;

                return current.Data;
            }

            public ListIterator(Values? Anfang)
			{
				temp = Anfang;
			}
        }

		public ListIterator GetIterator()
		{
			return new ListIterator(Anfang);
		}


		public void AddFirst(T Data)
		{
			if(Anfang == null)
			{
				Ende = Anfang = new Values(Data);
				return;
			}

			Values newValue = new Values(Data);
			newValue.Next = Anfang;
			Anfang = newValue;
		}

        public void Remove(int i)
        {
            Values PreDelete = Anfang;

            if (Anfang == null) return;

            if (i == 0)
            {
                Anfang = Anfang.Next;
                return;
            }

            for (int y = 0; y < i - 1; y++)
            {
                if (PreDelete.Next == null)
                {
                    return; 
                }
                PreDelete = PreDelete.Next;
            }

            if (PreDelete != null && PreDelete.Next != null)
            {
                PreDelete.Next = PreDelete.Next.Next;

                if (PreDelete.Next == null)  Ende = PreDelete;
                
            }
        }


    }
}

