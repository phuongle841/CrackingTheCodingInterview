using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class orangesRotting
    {
        public static int OrangesRotting(int[,] grid)
        {
            Queue<KeyValuePair<int, int>> rottedQueue = new();
            int count = 0;
            int timer = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    var curr = new KeyValuePair<int, int>(i, j);

                    switch (grid[i, j])
                    {
                        case 1:
                            count++;
                            break;
                        case 2:
                            rottedQueue.Enqueue(curr);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (count == 0)
                return 0;

            while (rottedQueue.Count > 0)
            {
                bool RottedThisRound = false;
                int size = rottedQueue.Count;

                for (int i = 0; i < size; i++)
                {


                    KeyValuePair<int, int> curr = rottedQueue.Dequeue();
                    int[,] adj = new int[4, 2]
                    {
                    {curr.Key -1,curr.Value},
                    {curr.Key   ,curr.Value + 1},
                    {curr.Key +1,curr.Value},
                    {curr.Key   ,curr.Value - 1},
                    };

                    for (int j = 0; j < 4; j++)
                    {
                        int r = adj[j, 0];
                        int c = adj[j, 1];

                        if (r >= 0 && r < grid.GetLength(0) &&
                            c >= 0 && c < grid.GetLength(1) &&
                            grid[r, c] == 1)
                        {
                            rottedQueue.Enqueue(new KeyValuePair<int, int>(r, c));
                            grid[r, c] = 2;
                            count--;
                            RottedThisRound = true;
                        }
                    }
                }


                if (RottedThisRound)
                    timer++;

            }


            return count == 0 ? timer  : -1;
        }

    }
}
