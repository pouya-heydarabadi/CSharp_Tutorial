namespace _02._02.CollectionsSample.QueueSample;

public class PriorityQueueSample<E,P>
{
    public PriorityQueue<E, P> objPriorityQueue = new PriorityQueue<E, P>();

    public void Add(E element, P priority)
    {
        objPriorityQueue.Enqueue(element, priority);
    }

    public object DeQueue()
    {
       return objPriorityQueue.Dequeue();
    }

    public object Peek()
    {
        return objPriorityQueue.Peek();
    }
}
