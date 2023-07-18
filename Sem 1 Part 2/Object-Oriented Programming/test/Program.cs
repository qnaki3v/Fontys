namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {

                // Create a copy of the input array
                int[,] sortedArray = (int[,])array.Clone();

                // Start at the center of the array
                int x = sortedArray.GetLength(0) / 2;
                int y = sortedArray.GetLength(1) / 2;

                // Initialize variables for the spiral loop
                int dx = 1;
                int dy = 0;
                int dirChanges = 0;
                int visits = 0;

                // Loop through the array in a spiral pattern
                while (visits < sortedArray.Length)
                {
                    // Sort the current element
                    int temp = sortedArray[x, y];
                    sortedArray[x, y] = sortedArray[visits % sortedArray.GetLength(0), visits / sortedArray.GetLength(0)];
                    sortedArray[visits % sortedArray.GetLength(0), visits / sortedArray.GetLength(0)] = temp;

                    // Move to the next element in the spiral
                    x += dx;
                    y += dy;
                    visits++;

                    // Change direction if necessary
                    if (x == sortedArray.GetLength(0) || y == sortedArray.GetLength(1) || x < 0 || y < 0 || sortedArray[x, y] != 0)
                    {
                        dirChanges++;
                        if (dirChanges % 2 == 1)
                        {
                            int tempDx = dy;
                            dy = dx;
                            dx = tempDx;
                        }
                        else
                        {
                            int tempDx = dy;
                            dy = -dx;
                            dx = -tempDx;
                        }
                        if (dirChanges % 4 == 2)
                        {
                            x += dx;
                            y += dy;
                        }
                    }
                }

                // Reverse the array to get the final sorted result
                Array.Reverse(sortedArray);
                return sortedArray;

            }
        }
    }
}