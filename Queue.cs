using System;
using Unit4.CollectionsLib;

namespace Queue
{
    public static class Program
    {
        /// <summary>
        /// Spills a queue to a different queue
        /// </summary>
        /// <param name="from"> The source queue </param>
        /// <param name="to"> The destenation queue </param>
        public static void SpillQueue<T>(Queue<T> from, Queue<T> to)
        {
            while (!from.IsEmpty())
                to.Insert(from.Remove());
        }

        /// <summary>
        /// Copies a queue
        /// Time complexity: O(n), n = number of items in the queue
        /// </summary>
        /// <param name="source"> The source queue </param>
        /// <returns> A copy of the queue </returns>
        public static Queue<T> CopyQueue<T>(Queue<T> source)
        {
            Queue<T> result = CopyQueue<T>(source, new Queue<T>());
            FlipQueue(source);
            return result;
        }
        public static Queue<T> CopyQueue<T>(Queue<T> source, Queue<T> result = null)
        {
            if (source.IsEmpty())
                return result;
            T temp = source.Remove();
            result.Insert(temp);
            result = CopyQueue(source, result);
            source.Insert(temp);
            return result;
        }

        /// <summary>
        /// Returns the number of items in the queue
        /// Time complexity: O(n), n = number of items in the queue
        /// </summary>
        /// <param name="source"> The source queue </param>
        /// <returns> The number of items in the queue </returns>
        public static int QueueSize<T>(Queue<T> source)
        {
            int size = QueueSize(source, 0);
            FlipQueue(source);
            return size;
        }
        public static int QueueSize<T>(Queue<T> source, int counter = 0)
        {
            if (source.IsEmpty())
                return 0;
            T temp = source.Remove();
            counter = 1 + QueueSize(source, 0);
            source.Insert(temp);
            return counter;
        }

        /// <summary>
        /// Flips a queue
        /// Time complexity: O(n), n = number of items in the queue
        /// </summary>
        /// <param name="source"> The source queue </param>
        public static void FlipQueue<T>(Queue<T> source)
        {
            if (source.IsEmpty())
                return;
            T temp = source.Remove();
            FlipQueue(source);
            source.Insert(temp);
        }
    }
}
