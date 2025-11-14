namespace Sorting
{
    public class Bubble
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)      // Each pass
            {
                for (int j = 0; j < n - i - 1; j++)  // Compare adjacent elements
                {
                    if (arr[j] > arr[j + 1])     // Swap if out of order
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }



        }

        public void printtheBubble()
        {


            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");
            int[] arr = text
                 .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Console.WriteLine($"Start: {string.Join(", ", arr)}");
            BubbleSort(arr);
            Console.WriteLine($"Start: {string.Join(", ", arr)}");
            Console.WriteLine("this is bubble sort");
        }
    }
}
