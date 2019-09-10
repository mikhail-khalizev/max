namespace QuickGraph.Collections
{
#if !SILVERLIGHT
    [Serializable]
#endif
    public sealed class Queue<T> : 
        System.Collections.Generic.Queue<T>,
        IQueue<T>
    {
    }
}
