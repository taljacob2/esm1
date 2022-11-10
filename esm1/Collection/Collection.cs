using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esm1.Collection
{
    public class Collection<T> where T : IComparable<T>
    {

        private readonly List<T> _list = new();

        /// <summary>
        /// Adds the object which is given as input.
        /// The collection sorts itself when adding an object.
        /// This operation may be performed in WC time complexity of O(n).
        /// </summary>
        /// <param name="obj">The object to add to the collection.</param>
        public void Add(T obj)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                T item = _list[i];
                if (item.CompareTo(obj) <= 0)
                {
                    continue;
                }
                else
                {
                    _list.Insert(i, obj);
                    return;
                }
            }

            /*
             * If the `obj` wasn't added yet, it means it should be placed as
             * the last item.
             */
            _list.Add(obj);
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
