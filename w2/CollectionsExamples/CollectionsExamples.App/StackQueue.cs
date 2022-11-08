using System;

namespace CollectionsExamples.App
{
    public class StackQueue
    {
        Stack<DateTime> timeStack = new Stack<DateTime>();
        Queue<DateTime> timeQueue = new Queue<DateTime>();

        public StackQueue(int mode) //0 for only initializing stack, 1 for only queue, 2 for both
        {
            if (mode == 0 || mode == 2) 
            {
                for (int i = 0; i < 100000000; i++)
                {
                    this.timeStack.Push(DateTime.Now);
                }
            }
            if (mode == 1 || mode == 2)
            {
                for (int i = 0; i < 100000000; i++)
                {
                    this.timeQueue.Enqueue(DateTime.Now);
                }
            }
        }

        public void clearStack()
        {
            while (timeStack.Count != 0)
            {
                timeStack.Pop();
            }
        }

        public void clearQueue()
        {
            while (timeQueue.Count != 0)
            {
                timeQueue.Dequeue();
            }
        }
    }
}