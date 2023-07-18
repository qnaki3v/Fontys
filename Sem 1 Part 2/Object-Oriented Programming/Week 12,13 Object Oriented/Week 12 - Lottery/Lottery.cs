using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Lottery
{
    public class Lottery
    {
        Random random = new Random();
        public int MaxValue { get; set; }
        public int NrOfNums { get; set; }
        public int[] LuckyNumbers { get; set; }
        public Lottery(int maxValue, int nrOfNums)
        {
            if (nrOfNums > maxValue)
            {
                MessageBox.Show("Invalid input. You are requesting too much numbers with too low max value.");
            }

            MaxValue = maxValue;
            NrOfNums = nrOfNums;
            LuckyNumbers = new int[NrOfNums];
        }
        public int[] DrawAllNumbers()
        {
            for (int i = 0; i < NrOfNums; i++)
            {
                if (LuckyNumbers[i] != 0)
                {
                    continue;
                }
                else
                {
                    int currRandom = random.Next(1, MaxValue+1);
                    while (!LuckyNumbers.Contains(currRandom))
                    {
                        LuckyNumbers[i] = currRandom;
                        currRandom = random.Next(1, MaxValue+1);
                    }
                }
            }
            return LuckyNumbers;
        }
        public int DrawNextNumber()
        {
            int currIndex = -1;
            for (int i = 0; i < NrOfNums; i++)
            {
                if (LuckyNumbers[i] == 0)
                {
                    currIndex = i;
                    break;
                }
            }
            if (currIndex != -1)
            {
                int currRandom = random.Next(1, MaxValue+1);
                while (LuckyNumbers.Contains(currRandom))
                {
                    currRandom = random.Next(1, MaxValue+1);
                }
                LuckyNumbers[currIndex] = currRandom;
                return currRandom;
            }
            else
            {
                return -1;
            }
        }
        public bool IsLotteryFinished()
        {
            if (LuckyNumbers[LuckyNumbers.Length - 1] == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < LuckyNumbers.Length; i++)
            {
                sb.Append(LuckyNumbers[i]);
                if (i != LuckyNumbers.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
