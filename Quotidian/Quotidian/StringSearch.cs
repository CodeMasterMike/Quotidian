using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotidian.HelperObjects;

namespace Quotidian
{
    public static class StringSearch
    {
        //algorithm references gotten from https://www.programmingalgorithms.com/algorithm/
        //containsSearch was selft written
        static String str = "TestText";
        static String pat = "TestKey";
        static List<String> highlightsText = new List<String>();

        public static List<int[]> searchReadings(List<Reading> readings, string pattern)
        {
            List<int[]> searchResults = new List<int[]>();
            foreach(Reading r in readings)
            {
                str = r.text;
                pat = pattern;
                int[] currReadingResults = BoyerMooreSearch();
                searchResults.Add(currReadingResults);
            }
            return searchResults;
        }

        public static List<int[]> searchHighlights(Reading r, string pattern)
        {
            List<int[]> searchResults2 = new List<int[]>();
            highlightsText = new List<string>();
            foreach(Highlight h in r.highlights)
            {
                str = r.text.Substring(h.charNum, h.charCount);
                highlightsText.Add(str);
                pat = pattern;
                int[] currHighlightResults = BoyerMooreSearch();
                searchResults2.Add(currHighlightResults);
            }
            return searchResults2;
        }

        public static List<String> getHighlightsText()
        {
            return highlightsText;
        }

        public static double Test(int alg, String s, String p)
        {
            Stopwatch stop = new Stopwatch();
            int[] retVal;
            str = s;
            pat = p;
            stop.Start();
            switch (alg)
            {
                
                case 1://contains
                    retVal = containsSearch();
                    break;
                case 2://BoyerMoore
                    retVal = BoyerMooreSearch();
                    break;
                case 3://KMP
                    retVal = KMPSearch();
                    break;
                case 4://RabinKarpe
                    retVal = RabinKarpeSearch();
                    break;
                default:
                    retVal = new int[] { -1 };
                    break;
            }
            stop.Stop();
            //Console.WriteLine("Array Contents-->");
            //foreach (var item in retVal)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            Console.WriteLine(retVal.Count());
            return stop.ElapsedMilliseconds;
        }

        public static int[] containsSearch()
        {
            List<int> retVal = new List<int>();
            int i = str.IndexOf(pat, 0);
            //Console.WriteLine(i);
            while(i != -1)
            {
                retVal.Add(i);
                i = str.IndexOf(pat, i+1);
                //Console.WriteLine(i);
            }

            return retVal.ToArray();
        }

        public static int[] KMPSearch()
        {
            List<int> retVal = new List<int>();
            int M = pat.Length;
            int N = str.Length;
            int i = 0;
            int j = 0;
            int[] lps = new int[M];

            ComputeLPSArray(pat, M, lps);

            while (i < N)
            {
                if (pat[j] == str[i])
                {
                    j++;
                    i++;
                }

                if (j == M)
                {
                    retVal.Add(i - j);
                    j = lps[j - 1];
                }

                else if (i < N && pat[j] != str[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }

            return retVal.ToArray();
        }

        private static void ComputeLPSArray(string pat, int m, int[] lps)
        {
            int len = 0;
            int i = 1;

            lps[0] = 0;

            while (i < m)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
        }

        public static int[] RabinKarpeSearch()
        {
            String A = str;
            String B = pat;
            List<int> retVal = new List<int>();
            ulong siga = 0;
            ulong sigb = 0;
            ulong Q = 100007;
            ulong D = 256;

            for (int i = 0; i < B.Length; ++i)
            {
                siga = (siga * D + (ulong)A[i]) % Q;
                sigb = (sigb * D + (ulong)B[i]) % Q;
            }

            if (siga == sigb)
                retVal.Add(0);

            ulong pow = 1;

            for (int k = 1; k <= B.Length - 1; ++k)
                pow = (pow * D) % Q;

            for (int j = 1; j <= A.Length - B.Length; ++j)
            {
                siga = (siga + Q - pow * (ulong)A[j - 1] % Q) % Q;
                siga = (siga * D + (ulong)A[j + B.Length - 1]) % Q;

                if (siga == sigb)
                    if (A.Substring(j, B.Length) == B)
                        retVal.Add(j);
            }

            return retVal.ToArray();
        }

        //This algorithm  returns list of st
        public static int[] BoyerMooreSearch()
        {
            List<int> retVal = new List<int>();
            int m = pat.Length;
            int n = str.Length;

            int[] badChar = new int[10000];

            BadCharHeuristic(pat, m, ref badChar);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && pat[j] == str[s + j])
                    --j;

                if (j < 0)
                {
                    retVal.Add(s);
                    s += (s + m < n) ? m - badChar[str[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - badChar[str[s + j]]);
                }
            }

            return retVal.ToArray();
        }

        private static void BadCharHeuristic(string str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 10000; i++)
                badChar[i] = -1;

            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }
    }
}
