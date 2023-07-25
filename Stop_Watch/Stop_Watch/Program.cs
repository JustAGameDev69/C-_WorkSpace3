using System;

namespace Stop_watch
{
    class Stop_Watch
    {
        private DateTime start_time;
        private DateTime end_time;

        public DateTime Start_Time
        {
            get { return start_time; }
        }

        public DateTime End_Time
        {
            get { return end_time; }
        }

        public Stop_Watch()
        {
            start_time = DateTime.Now;
        }

        public void Start()
        {
            start_time = DateTime.Now;
        }

        public void Stop()
        {
            end_time = DateTime.Now;
        }

        public long GetElapsedTime()
        {
            return (long)(end_time - start_time).TotalMilliseconds;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100000];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }

            Stop_Watch sw_1 = new Stop_Watch();
            SelectionSort(arr);
            sw_1.Stop();

            Console.WriteLine("Elapsed Time: {0} ms!", sw_1.GetElapsedTime());
        }

        static void SelectionSort(int[] arr)
        {
            for (int i =0; i< arr.Length; i++)
            {
                int min_index = i;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min_index];
                arr[min_index] = temp;
            }
        }
    }
}