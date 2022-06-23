using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._950.RevealCardsInIncreasingOrder
{
    public class CodeFile
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            var result = new int[deck.Length];
            var queue = new Queue<int>();

            Array.Sort(deck);
            for (int i = 0; i < deck.Length; i++)
            {
                queue.Enqueue(i);
            }

            var j = 0;
            while (queue.Count > 0)
            {
                var index = queue.Dequeue();
                result[index] = deck[j];

                j++;

                if (queue.Count > 0)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }

            return result;
        }
    }
}
