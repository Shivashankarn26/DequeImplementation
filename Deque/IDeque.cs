using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeImplementation
{
    public interface IDeque
    {
        int Count { get; }

        bool IsEmpty { get; }

        void Clear();

        IList<int> AddToFront(string Value);

        IList<int> AddToBack(string Value);

        IList<int> RemoveFromFront();

        IList<int> RemoveFromBack();

        void Print();
    }
}
