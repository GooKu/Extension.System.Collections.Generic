using System.Collections.Generic;

namespace Goo.Extension.System.Collections.Generic
{
    public static class QueueExtension
    {
        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }
    }
}
