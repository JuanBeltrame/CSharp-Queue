using System.Security.Cryptography;

namespace Queue_Practice_04__Library_
{
    public class Queue
    {
        public int  MaxSize { get; set; } // Sets the number of elements because this is an array
        public int[] QueueArray { get; set; } // Actual array we will store elements in
        public int Front { get; set; } // Index to keep track of front
        public int Rear { get; set; } // Index to keep track of adds
        public int NItems { get; set; } // This will keep track of lenght


        public Queue(int size)
        {
            MaxSize = size;
            QueueArray = new int[size];
            Front = default;
            Rear = -1;
        }

        // Somebody is going into the line
        public void Enqueue(int item)
        {
            // Incremento our pointer
            Rear++;
            // Insert into where the rear was incremented
            QueueArray[Rear] = item;
            // Increment
            NItems++;
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];
        }
    }
}
