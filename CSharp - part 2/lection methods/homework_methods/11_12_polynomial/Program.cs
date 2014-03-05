using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_polynomial
{
    class Program
    {
        static int[][] PolyParse()
        {
            int[][] jArr = new int[2][];
            Console.Write("Input the number of terms for your first polynomial: ");
            jArr[0] = new int[int.Parse(Console.ReadLine())];
            for (int k = 0; k < jArr[0].Length; k++)
            {
                Console.Write("Input constant {0}: ", (k + 1));
                jArr[0][k] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input the number of terms for your second polynomial: ");
            jArr[1] = new int[int.Parse(Console.ReadLine())];
            for (int l = 0; l < jArr[1].Length; l++)
            {
                Console.Write("Input constant {0}: ", (l + 1));
                jArr[1][l] = int.Parse(Console.ReadLine());
            }
            return jArr;
        }

        static int[] PolyAdd(int[] a, int[] b)
        {
            int bigger = a.Length,
                smaller = b.Length,
                check = 0;
            if (b.Length > a.Length)
            {
                bigger = b.Length;
                smaller = a.Length;
                check++;
            }
            int[] resultArr = new int[bigger];

            for (int i = smaller - 1; i >= 0; i--)
            {
                resultArr[i] = a[i] + b[i];
            }
            for (int j = bigger - 1; j >= smaller; j--)
            {
                if (check == 1) resultArr[j] = b[j];
                else resultArr[j] = a[j];
            }
            return resultArr;
        }

        static int[] PolySub(int[] a, int[] b)
        {
            int bigger = a.Length,
                smaller = b.Length,
                check = 0;
            if (b.Length > a.Length)
            {
                bigger = b.Length;
                smaller = a.Length;
                check++;
            }
            int[] resultArr = new int[bigger];

            for (int i = smaller - 1; i >= 0; i--)
            {
                resultArr[i] = a[i] - b[i];
            }
            for (int j = bigger - 1; j >= smaller; j--)
            {
                if (check == 1) resultArr[j] = b[j];
                else resultArr[j] = a[j];
            }
            return resultArr;
        }

        static int[] PolyMulti(int[] a, int[] b)
        {
            int bigger = a.Length,
                smaller = b.Length,
                check = 0;
            if (b.Length > a.Length)
            {
                bigger = b.Length;
                smaller = a.Length;
                check++;
            }
            int[] resultArr = new int[bigger];

            for (int i = smaller - 1; i >= 0; i--)
            {
                resultArr[i] = a[i] * b[i];
            }
            for (int j = bigger - 1; j >= smaller; j--)
            {
                if (check == 1) resultArr[j] = b[j];
                else resultArr[j] = a[j];
            }
            return resultArr;
        }

        static void Main()
        {
            //Addition

            int[][] pParse = PolyParse();
            int[] pAdd = PolyAdd(pParse[0], pParse[1]);
            string polynomialA = "" + string.Format("{0}x^{1}", pAdd[pAdd.Length - 1], (pAdd.Length - 1));
            for (int m = pAdd.Length - 2; m >= 0; m--)
            {
                if (m == 0) polynomialA += " + " + pAdd[m];
                else if (m == 1) polynomialA += string.Format(" + {0}x", pAdd[m]);
                else polynomialA += string.Format(" + {0}x^{1}", pAdd[m], m);
            }
            Console.WriteLine("Polynomial addition:");
            Console.WriteLine(polynomialA);

            //Substraction

            int[] pSub = PolySub(pParse[0], pParse[1]);
            string polynomialS = "" + string.Format("{0}x^{1}", pSub[pSub.Length - 1], (pSub.Length - 1));
            for (int m = pSub.Length - 2; m >= 0; m--)
            {
                if (m == 0) polynomialS += " + " + pSub[m];
                else if (m == 1) polynomialS += string.Format(" + {0}x", pSub[m]);
                else polynomialS += string.Format(" + {0}x^{1}", pSub[m], m);
            }
            Console.WriteLine("Polynomial substraction:");
            Console.WriteLine(polynomialS);

            //Multiplication

            int[] pMulti = PolyMulti(pParse[0], pParse[1]);
            string polynomialM = "" + string.Format("{0}x^{1}", pMulti[pMulti.Length - 1], (pMulti.Length - 1));
            for (int m = pMulti.Length - 2; m >= 0; m--)
            {
                if (m == 0) polynomialM += " + " + pMulti[m];
                else if (m == 1) polynomialM += string.Format(" + {0}x", pMulti[m]);
                else polynomialM += string.Format(" + {0}x^{1}", pMulti[m], m);
            }
            Console.WriteLine("Polynomial multiplication:");
            Console.WriteLine(polynomialM);
        }
    }
}
