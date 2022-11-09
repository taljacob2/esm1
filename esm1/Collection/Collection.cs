using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esm1.Collection
{
    public class Collection<T> where T : IComparable<T>
    {

        private List<T> _list = new List<T>();

        /// <summary>
        /// Adds the object which is given as input.
        /// This operation may be performed in WC time complexity of O(n).
        /// </summary>
        /// <param name="obj"></param>
        public void Add(T obj)
        {
            if (_list.Count == 0)
            {
                _list.Add(obj);
                return;
            }

            int comparisonResult = _list[0].CompareTo(obj);
            if (comparisonResult <= 0)
            {
                _list.Add(obj);
                return;
            }
            else
            {
                _list.Add(_list[0]);
                _list[0] = obj;
            }
        }

        /// <summary>
        /// Removes the object with the maximum value and returns it.
        /// This operation is performed in WC time complexity of O(1).
        /// </summary>
        public T Remove()
        {
            return default(T);
        }

        /// <summary>
        /// Publishes a notification to subscriber objects upon any Add/Remove.
        /// </summary>
        /// <seealso cref="Add(T)"/>
        /// <seealso cref="Remove"/>
        public void Publish()
        {

        }
    }
}
