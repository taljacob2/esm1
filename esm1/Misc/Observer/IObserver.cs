namespace esm1.Misc.Observer
{
    public interface IObserver
    {

        /// <summary>
        /// Receive update from subject.
        /// </summary>
        /// <param name="subject" />
        void Update(ISubject subject);
    }
}
