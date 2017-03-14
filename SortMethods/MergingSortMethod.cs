using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMethods
{
    public class MergingSortMethod
    {
        /// <summary>
        /// This method written to sort massive of integers. 
        /// </summary>
        /// <param name="imputMass">This is the massive we need to sort.</param>
        /// <param name="outputMass">This is going to be our sorted massive.</param>
        /// <param name="left">This is the beginning index of the part of massive <paramref>imputMassive</paramref> to be sorted.(To start from the first element enter 0.)</param>
        /// <param name="right">This is the ending index of the part of massive <paramref>imputMassive</paramref> to be sorted.</param>
        /// <returns>Return our imput massive <paramref>imputMassive</paramref> as sorted one in <paramref>result</paramref></returns>

        public static int[] MergingMethod(int[] imputMass)
        {
            // Here we check if our massive contains only one element.

            if (imputMass.Length ==1)
            {
                return imputMass;
            }

            int middle = imputMass.Length / 2;

            int[] imputMassleft = new int[middle];
            int[] imputMassright = new int[imputMass.Length-middle];

            for (int i = 0; i < imputMassleft.Length; i++)
            {
                imputMassleft[i] = imputMass[i];
            }
            for (int i = 0; i < imputMassright.Length; i++)
            {
                imputMassright[i] = imputMass[imputMassleft.Length + i];
            }


            return MergedMass(MergingMethod(imputMassleft), MergingMethod(imputMassright));
        }


        internal static int[] MergedMass(int[] mass1, int[] mass2)
        {
            int current_left = 0;
            int current_right = 0;
            int[] merged = new int[mass1.Length + mass2.Length];

            for (int i = 0; i <= merged.Length; i++)
            {
                /* if (current_right >= mass2.Length)
                 { merged[i] = mass1[current_left]; current_left++; }

                 else if (current_left < mass1.Length && mass1[current_left] < mass2[current_right])
                 {
                     merged[i] = mass1[current_left];
                     current_left++;
                 }

                 else
                 {
                     merged[i] = mass2[current_right];
                     current_right++;
                 }*/

                //////////////////////////////////////////////////////////////////////////////////

                /* if (current_right < mass2.Length && current_left < mass1.Length)
                     if (mass1[current_left] > mass2[current_right])
                         merged[i] = mass2[current_right++];
                     else //if int go for
                         merged[i] = mass1[current_left++];
                 else
       if (current_right < mass2.Length)
                     merged[i] = mass2[current_right++];
                 else
                     merged[i] = mass1[current_left++]; */

                ///////////////////////////////////////////////////////////////

                if (current_left > (merged.Length/2))
                {
                    merged[i] = mass2[current_right];
                    current_right++;
                }
                else if (current_right > merged.Length - merged.Length / 2)
                {
                    merged[i] = mass1[current_left];
                    current_left++;
                }
                else if (mass2[current_right] < mass1[current_left])
                {
                    merged[i] = mass2[current_right];
                    current_right++;
                }
                else {
                    merged[i] = mass1[current_left];
                    current_left++;
                }

                Console.WriteLine(current_left);
                Console.WriteLine(current_right);
            }
            
            return merged;    
        }
    }
}

