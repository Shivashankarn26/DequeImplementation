using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeImplementation
{
    public class Deque : IDeque
    {
        private IList<int> _queue;

        public Deque()
        {           
            _queue = new List<int>();            
        }

        //public Deque(int capacity)
        //{
        //    _queue = new List<int>(capacity);
        //    Console.WriteLine("---------Deque item created with predefined capacity---------");
        //}

        //public Deque(int[] initialList)
        //{
        //    _queue = new List<int>(initialList);
        //    Console.WriteLine("--------Deque item created with initial list of items---------");
        //}

        public int Count
        {
            get
            {
                return _queue.Count();
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _queue?.Count() == 0 ? true : false;
            }
        }

        public void Clear()
        {
            _queue.Clear();
            Console.WriteLine("-------------------Deque CLEARED------------------------");
        }

        public IList<int> AddToFront(string value)
        {
            try
            {
                int Value = Convert.ToInt32(value);
                _queue = _queue.Reverse().ToList();
                _queue = _queue.Append(Value).ToList();
                _queue = _queue.Reverse().ToList();

                Console.WriteLine($"Item added to Front :{Value} ");
                Print();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Couldn't able to add the given item. Allowed numbers are between 0 to {Int32.MaxValue.ToString()}");
                throw new Exception("Input OutofRange");
            }
            return _queue;
        }

        public IList<int> AddToBack(string value)
        {
            try
            {
                int Value = Convert.ToInt32(value);
                _queue = _queue.Append(Value).ToList();

                Console.WriteLine($"Item added to Back :{Value} ");
                Print();
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"Couldn't able to add the given item. Allowed numbers are between 0 to {Int32.MaxValue.ToString()}");
                throw new Exception("Input OutofRange");
            }
            return _queue;
        }

        public IList<int> RemoveFromFront()
        {
            if (!IsEmpty)
            {
                Console.WriteLine($"Item Removed from Front :{_queue[0]} ");
                _queue.RemoveAt(0);
                Print();
            }
            else
            {
                Console.WriteLine("Currently Queue is empty to remove item");
                throw new Exception("Empty Deque");
            }
            return _queue;
        }

        public IList<int> RemoveFromBack()
        {
            if (!IsEmpty)
            {
                int lastIndex = _queue.Count() - 1;

                Console.WriteLine($"Item Removed from Back :{_queue[lastIndex]} ");

                _queue.RemoveAt(lastIndex);
                Print();
            }
            else
            {
                Console.WriteLine("Currently Queue is empty to remove item");
                throw new Exception("Empty Deque");
            }
            return _queue;
        }

        public void Print()
        {
            string values = string.Empty;

            foreach(int item in _queue)
            {
                values += item.ToString() + ", ";
            }
            Console.WriteLine("Items available currently in DEQUE :");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(values.Trim().TrimEnd(',').Trim());
            Console.WriteLine("--------------------------------------");            
        }
    }
}
