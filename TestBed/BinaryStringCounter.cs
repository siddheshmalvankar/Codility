using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    public class BinaryStringCounter
    {
        public static int counting(string s)
        {

            var stringList = new List<string>();
            List<string> validString = new List<string>();
            for (int i = 0; i < s.Length; i++)
                for (int j = i; j < s.Length; j++)
                    stringList.Add(s.Substring(i, j - i + 1));


            foreach (var item in stringList)
            {
                if ((item.Count(c => c == '0') == item.Count(c => c == '1')))
                {
                    // Console.WriteLine(item);
                    int counter0 = 0;
                    int groupcount = 0;
                    char first = item[0];

                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] == first)
                            groupcount++;

                        else
                            break;


                    }
                    char prev = item[0];
                    Dictionary<char, int> keyValues = new Dictionary<char, int>();
                    for (int i = 0; i < item.Length; i++)
                    {
                        //if (!keyValues.ContainsKey(item[i]))
                        //    keyValues.Add(item[i], counter0);
                        //else
                        //    break;
                        if (prev == item[i])
                            counter0++;
                        else
                        {
                            if (groupcount != counter0)
                            {
                                counter0 = 0;
                                break;
                            }
                            else
                            {
                                prev = item[i];
                                counter0 = 0;

                            }
                        }

                        if (i == item.Length - 1)
                        {
                            if (!validString.Contains(item))
                                validString.Add(item);
                        }
                    }

                }



            }

            validString.ForEach(x => Console.WriteLine(x));

            return validString.Count;
        }
    }
}

