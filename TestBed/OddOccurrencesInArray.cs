using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    public  class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            if (A.Length == 1)
                return A[0];

            List<int> arrayOddOcc = new List<int>();
            arrayOddOcc = A.ToList();
            for (int i = 0; i < A.Length; i++)
            {
                   var occurance = arrayOddOcc.Count(x => x == A[i]);
                if (occurance % 2 == 0)
                    arrayOddOcc.RemoveAll(r => r == A[i]);
                else
                {
                    if(occurance>2)
                    arrayOddOcc.RemoveRange(i + 1, occurance - 1);
                }
                   
                      
                if (arrayOddOcc.Count() == 1)
                    break;
            }


            if (arrayOddOcc.Count() > 0)
                return arrayOddOcc.First();
            else
                return 0;
        }

    }
}
