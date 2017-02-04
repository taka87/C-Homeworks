using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split().ToArray();
            string[] secondInput = Console.ReadLine().Split().ToArray();

            //int count = 0;
            //int counter = 0;

            ////List<string> result = new List<string>();

            //for (int i = 0; i < firstInput.Length - 1; i++)
            //{
            //        if (firstInput[i].Equals(secondInput[i]))
            //        {
            //            counter++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        //if (firstInput[i].Equals(secondInput[j]))
            //        //{

            //        //    count++;
            //        //}
            //        //else
            //        //{
            //        //    break;
            //        //}                
            //}

            //Console.WriteLine(count);
            //Console.WriteLine(counter);
            ////Console.WriteLine(string.Join(" ", result));

            int longestCommonSubsequence = LCS(firstInput, secondInput, 0, 0);
            Console.WriteLine(longestCommonSubsequence);
            //Console.Read();
        }

        //Find the longest common subsequnce starting from index1 in A and index2 in B
        //Pass A as shorter string
        public static int LCS(string[] A, string[] B, int index1, int index2)
        {
            int max = 0;
            if (index1 == A.Length)
            {
                //You have reached beyond A and thus no subsequence
                return 0;
            }
            if (index2 == B.Length)
            {   //you may reach end of 2nd string. LCS from that end is 0
                return 0;
            }

            for (int i = index1; i < A.Length; i++)
            {
                int exist = B[i].IndexOf(A[i], index2);
                if (exist != -1)
                {
                    //   found = true;

                    int temp = 1 + LCS(A, B, i + 1, exist + 1);
                    if (max < temp)
                    {
                        max = temp;
                    }
                }
            }
            return max;
        }
    }
}
