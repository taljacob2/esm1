using esm1.Misc;
using esm1.Misc.Observer;
using System.Collections;

namespace esm1.Collection
{

    /// <summary>
    /// <para>
    /// A generic collection that sorts its elements upon <see cref="Add(T)"/>.
    /// Thus, its elements must implement the <see cref="IComparable{T}"/>
    /// interface.
    /// </para>
    /// <para>
    /// Note that this collection implements the <see cref="ISubject"/>
    /// interface. So, it can also serve as a publisher, to notify a list of
    /// <see cref="IObserver"/>s about an update. To publish a notification,
    /// invoke the <see cref="Publish"/> method.
    /// We invoked the <see cref="Publish"/> method after the executions of
    /// <see cref="Add(T)"/> / <see cref="Remove"/>, to notify all the
    /// <see cref="IObserver"/>s that were <see cref="Attach(IObserver)"/>ed
    /// to <see cref="_observerList"/> about an update.
    /// </para>
    /// </summary>
    /// <typeparam name="T">
    /// Any object type to serve as the type of element in the collection.
    /// </typeparam>
    public class Collection<T> : IEnumerable<T>, ISubject where T : IComparable<T>
    {

        /// <summary>
        /// List of objects to collect.
        /// </summary>
        private readonly List<T> _list = new();

        /// <summary>
        /// List of subscribers to this instance.
        /// </summary>
        private readonly List<IObserver> _observerList = new();

        /// <summary>
        /// The last object that was interacting with this collection.
        /// It may have been added to the collection, or removed from it.
        /// </summary>
        public T LastTouchedObject { get; private set; }

        public enum Status { Added, Removed }

        /// <summary>
        /// Stores the status of <see cref="LastTouchedObject"/>.
        /// </summary>
        public Status LastTouchedObjectStatus { get; private set; }

        /// <summary>
        /// Adds the object which is given as input.
        /// The collection sorts itself when adding an object.
        /// This operation may be performed in WC time complexity of O(n).
        /// </summary>
        /// <param name="obj">The object to add to the collection.</param>
        public void Add(T obj)
        {
            bool added = false;

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
                    added = true;
                    break;
                }
            }

            if (!added) {

                /*
                 * If the `obj` wasn't added yet, it means it should be placed
                 * as the last item.
                 */
                _list.Add(obj);
            }

            // Update the properties' data and publish to subscribers.
            LastTouchedObjectStatus = Status.Added;
            LastTouchedObject = obj;
            Publish();
        }

        /// <summary>
        /// Removes the object with the maximum value and returns it.
        /// This operation is performed in WC time complexity of O(1).
        /// </summary>
        /// <returns>
        /// The last item in the collection. While the collection is sorted,
        /// it means this item has the maximum value between all items.
        /// </returns>
        public T? Remove()
        {
            T? lastItem = _list[^1];
            _list.RemoveAt(_list.Count - 1);

            // Update the properties' data and publish to subscribers.
            LastTouchedObjectStatus = Status.Removed;
            LastTouchedObject = lastItem;
            Publish();

            return lastItem;
        }

        public override string ToString()
        {
            return this.ToStringEnumerableExtension();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }

        public void Attach(IObserver observer)
        {
            _observerList.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observerList.Remove(observer);
        }

        /// <summary>
        /// Publishes a notification to subscriber objects upon any Add/Remove.
        /// </summary>
        /// <seealso cref="Add(T)"/>
        /// <seealso cref="Remove"/>
        /// <seealso cref="ISubject.Publish"/>
        public void Publish()
        {
            foreach (IObserver observer in _observerList)
            {
                observer.Update(this);
            }
        }
    }
}
