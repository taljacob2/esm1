namespace esm1.Misc.Observer
{
    public interface ISubject
    {

        /// <summary>
        /// Attach an observer to the subject.
        /// </summary>
        /// <param name="observer" />
        void Attach(IObserver observer);

        /// <summary>
        /// Detach an observer from the subject.
        /// </summary>
        /// <param name="observer" />
        void Detach(IObserver observer);

        /// <summary>
        /// Notify all observers about an event.
        /// </summary>
        void Publish();
    }
}
