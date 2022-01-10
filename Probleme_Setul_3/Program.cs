using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Setul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();?
            //P21();
            //P22();
            //P23();
            //P24();?
            //P25();
            //P26();
            //P27();
            //P28();
            //P29();
            //P30();
            //P31();
        }

        /// <summary>
        /// (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 
        /// din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unul 
        /// singur). Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>).
        /// (incercati sa gasiti o solutie liniara). 

        /// </summary>
        private static void P31()
        {
            int n, m = 0, k;
            bool exista = false;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n; i++)
            {
                k = 0;
                for (int j = 0; j < n; j++)
                {
                    if (v[j] == v[i])
                        k++;
                }
                if (k > n / 2)
                {
                    m = v[i];
                    exista = true;
                }
            }
            if (!exista)
                Console.WriteLine("nu exista");
            else
                Console.WriteLine($"Elementul majoritate este {m}");
        }

        /// <summary>
        /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un
        /// numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in ordine
        /// crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        /// </summary>
        private static void P30()
        {
            Console.Write("Vectorul E este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Vectorul W este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] E = new int[1000];
            int[] W = new int[1000];

            for (int i = 0; i < t1.Length; i++)
            {
                E[i] = int.Parse(t1[i]);
            }
            for (int i = 0; i < t2.Length; i++)
            {
                W[i] = int.Parse(t2[i]);
            }
            for (int i = 0; i < t1.Length - 1; i++)
            {
                for (int j = i + 1; j < t1.Length; j++)
                {
                    if (E[i] > E[j] || (E[i]) == E[j] && W[i] > W[j])
                    {
                        int aux = E[i];
                        E[i] = E[j];
                        E[j] = aux;
                    }
                }
            }
            Console.Write("Vectorul E[] ordonat crescator este: ");
            for (int i = 0; i < t1.Length; i++)
                Console.Write($"{E[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// MergeSort. Sortati un vector folosind metoda MergeSort.
        /// </summary>
        private static void P29()
        {
            Console.Write("Dati dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.Write("Introduceti elementele vectorului: ");
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            MergeSort(v, 0, n - 1);
            Console.Write("Vectorul ordonat crescator este: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        private static void MergeSort(int[] v, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(v, left, mid);
                MergeSort(v, mid + 1, right);
                MainMerge(v, left, mid + 1, right);
            }
        }

        private static void MainMerge(int[] v, int left, int mid, int right)
        {
            int[] t = new int[100];
            int i, poz, u, k;
            u = mid - 1;
            poz = left;
            k = right - left + 1;

            while ((left <= u) && (mid <= right))
            {
                if (v[left] <= v[mid])
                    t[poz++] = v[left++];
                else
                    t[poz++] = v[mid++];
            }
            while (left <= u)
                t[poz++] = v[left++];
            while (mid <= right)
                t[poz++] = v[mid++];
            for (i = 0; i < k; i++)
            {
                v[right] = t[right];
                right--;
            }
        }

        /// <summary>
        /// Quicksort. Sortati un vector folosind metoda QuickSort. 
        /// </summary>
        private static void P28()
        {
            Console.Write("Dati dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.Write("Introduceti elementele vectorului: ");
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            QuickSort(v, 0, n - 1);
            Console.Write("Vectorul ordonat crescator este: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        private static void QuickSort(int[] v, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(v, left, right);
                if (pivot > 1)
                    QuickSort(v, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(v, pivot + 1, right);
            }
        }

        private static int Partition(int[] v, int left, int right)
        {
            int pivot = v[left];
            while (true)
            {
                while (v[left] < pivot)
                    left++;
                while (v[right] > pivot)
                    right--;
                if (left < right)
                {
                    int aux = v[right];
                    v[right] = v[left];
                    v[left] = aux;
                }
                else
                {
                    return right;
                }
            }
        }

        /// <summary>
        /// Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi 
        /// pe pozitia index dupa ce vectorul este sortat. 
        /// </summary>
        private static void P27()
        {
            int index;
            int[] v = new int[1000];

            Console.Write("Dati elementele vectorului: ");
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < t.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            Console.Write("Index: ");
            index = int.Parse(Console.ReadLine());

            for (int i = 0; i < t.Length - 1; i++)
            {
                for (int j = i + 1; j < t.Length; j++)
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            }
            Console.WriteLine($"Valoarea de pe pozitia index este {v[index]}");
        }

        /// <summary>
        /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - 
        /// fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        private static void P26()
        {
            int i, j, n = 0, m = 0, s, d;
            Console.Write("v1[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("v2[] este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v1 = new int[1000];
            int[] v2 = new int[1000];
            int[] suma = new int[1000];
            int[] dif = new int[1000];

            int[] c1 = new int[1000];
            int[] c2 = new int[1000];

            for (i = 0; i < t1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
                c1[i] = v1[i];
                n++;
            }
            for (i = 0; i < t2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
                c2[i] = v2[i];
                m++;
            }

            s = d = 0;

            //suma

            int c = 0;

            for (i = n, j = m; i >= 0 || j >= 0; i--, j--)
            {
                if (j < 0)
                {
                    j = i;
                    v2[j] = 0;
                }
                if (i < 0)
                {
                    i = j;
                    v1[i] = 0;
                }
                if (v1[i] + v2[j] + c < 10)
                {
                    suma[s++] = v1[i] + v2[j] + c;
                    c = 0;
                }
                else
                {
                    suma[s++] = (v1[i] + v2[j] + c) % 10;
                    c = 1;
                }
            }
            if (c == 1)
                suma[s++] = c;
            for (i = s - 1; i > 0; i--)
                Console.Write($"{suma[i]}");
            Console.WriteLine();

            //diferenta

            c = 0;
            for (i = n, j = m; i >= 0 || j >= 0; i--, j--)
            {
                if (j < 0)
                {
                    j = i;
                    c2[j] = 0;
                }
                if (c1[i] - c >= c2[j])
                {
                    dif[d++] = c1[i] - c - c2[j];
                    c = 0;
                }
                else
                {
                    dif[d++] = (10 + c1[i] - c) - c2[j];
                    c = 1;
                }
            }
            for (i = d - 1; i > 0; i--)
                Console.Write($"{dif[i]}");
            Console.WriteLine();
        }

        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator
        /// format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
        /// </summary>
        private static void P25()
        {
            int i, j, k, n = 0, m = 0;
            Console.Write("v1[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("v2[] este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v1 = new int[1000];
            int[] v2 = new int[1000];
            int[] v3 = new int[2000];

            for (i = 0; i < t1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
                n++;
            }
            for (i = 0; i < t2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
                m++;
            }
            i = j = k = 0;
            while (i < n && j < m)
            {
                if (v1[i] < v2[j])
                    v3[k++] = v1[i++];
                else
                    v3[k++] = v2[j++];
            }
            while (i < n)
                v3[k++] = v1[i++];
            while (j < m)
                v3[k++] = v2[j++];
            for (i = 0; i < k; i++)
                Console.Write($"{v3[i]} ");
        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori 
        /// binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        private static void P24()
        {

        }

        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2
        /// sunt in ordine strict crescatoare. 
        /// </summary>
        private static void P23()
        {
            Console.Write("v1[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("v2[] este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v1 = new int[1000];
            int[] v2 = new int[1000];
            int k1 = 0;
            int k2 = 0;

            for (int i = 0; i < t1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
                k1++;
            }
            for (int i = 0; i < t2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
                k2++;
            }
            Console.Write($"Intersectia celor doi vectori este: ");
            for (int i = 0; i < k1; i++)
                if (cautare_binara(v1[i], v2, k2))
                    Console.Write($"{v1[i]} ");
            Console.WriteLine();
            Console.Write($"Reuniunea celor doi vectori este: ");
            for (int i = 0; i < k1; i++)
            {
                Console.Write($"{v1[i]} ");
            }
            for (int i = 0; i < k2; i++)
                if (!cautare_binara(v2[i], v1, k1))
                    Console.Write($"{v2[i]} ");
            Console.WriteLine();
            Console.Write($"Diferenta v1[]-v2[] este: ");
            for (int i = 0; i < k1; i++)
                if (!cautare_binara(v1[i], v2, k2))
                    Console.Write($"{v1[i]} ");
            Console.WriteLine();
            Console.Write($"Diferenta v2[]-v1[] este: ");
            for (int i = 0; i < k2; i++)
                if (!cautare_binara(v2[i], v1, k2))
                    Console.Write($"{v2[i]} ");
            Console.WriteLine();
        }

        private static bool cautare_binara(int v, int[] v2, int k)
        {
            int p, u, mij;
            p = 0;
            u = k;
            while (p <= u)
            {
                mij = (p + u) / 2;
                if (v == v2[mij])
                    return true;
                if (v < v2[mij])
                    u = mij - 1;
                else
                    p = mij + 1;
            }
            return false;
        }

        /// <summary>
        /// Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 
        /// (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
        /// </summary>
        private static void P22()
        {
            Console.Write("v1[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("v2[] este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v1 = new int[1000];
            int[] v2 = new int[1000];

            for (int i = 0; i < t1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
            }
            for (int i = 0; i < t2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
            }

            bool apare;
            Console.Write($"Intersectia celor doi vectori este: ");
            for (int i = 0; i < t1.Length; i++)
            {
                apare = false;
                for (int j = 0; j < t2.Length && !apare; j++)
                    if (v1[i] == v2[j])
                        apare = true;
                if (apare)
                {
                    Console.Write($"{v1[i]} ");
                }
            }
            Console.WriteLine();
            Console.Write($"Reuninuea celor doi vectori este: ");
            for (int i = 0; i < t1.Length; i++)
            {
                apare = false;
                Console.Write($"{v1[i]} ");
            }
            for (int i = 0; i < t2.Length; i++)
            {
                apare = true;
                for (int j = 0; j < t1.Length; j++)
                    if (v2[i] == v1[j])
                        apare = false;
                if (apare)
                {
                    Console.Write($"{v2[i]} ");
                }
            }
            Console.WriteLine();
            Console.Write($"Diferenta v1[]-v2[] este: ");
            for (int i = 0; i < t1.Length; i++)
            {
                apare = true;
                for (int j = 0; j < t2.Length; j++)
                    if (v1[i] == v2[j])
                        apare = false;
                if (apare)
                {
                    Console.Write($"{v1[i]} ");
                }
            }
            Console.WriteLine();
            Console.Write($"Diferenta v2[]-v1[] este: ");
            for (int i = 0; i < t2.Length; i++)
            {
                apare = true;
                for (int j = 0; j < t1.Length; j++)
                    if (v2[i] == v1[j])
                        apare = false;
                if (apare)
                {
                    Console.Write($"{v2[i]} ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        private static void P21()
        {
            Console.Write("v1[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("v2[] este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v1 = new int[1000];
            int[] v2 = new int[1000];

            for (int i = 0; i < t1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
            }
            for (int i = 0; i < t2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
            }

            bool coincid = true;
            if (v1.Length == v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                    if (v1[i] != v2[i])
                        coincid = false;
            }
            if (coincid)
            {
                Console.WriteLine("Cei doi vectori coincid");
                return;
            }

            if (v1.Length < v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    if (v1[i] < v2[i])
                    {
                        Console.WriteLine("v1[] este mai mic lexicografic decat v2[]");
                        return;
                    }
                    else if (v1[i] > v2[i])
                    {
                        Console.WriteLine("v1[] este mai mare lexicografic decat v2[]");
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    if (v1[i] < v2[i])
                    {
                        Console.WriteLine("v1[] este mai mic lexicografic decat v2[]");
                        return;
                    }
                    else if (v1[i] > v2[i])
                    {
                        Console.WriteLine("v1[] este mai mare lexicografic decat v2[]");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul
        /// de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi
        /// culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        private static void P20()
        {
            // 0 -> margea alba
            // 1 -> margea neagra
            Console.Write("Primul sirag este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Al doilea sirag este: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] s1 = new int[1000];
            int[] s2 = new int[1000];

            for (int i = 0; i < t1.Length; i++)
            {
                s1[i] = int.Parse(t1[i]);
            }
            for (int i = 0; i < t2.Length; i++)
            {
                s1[i] = int.Parse(t2[i]);
            }

            int k = 0;

            if (s1.Length < s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[i])
                        k++;
                }
            }
            else
            {
                for (int i = 0; i < s2.Length; i++)
                {
                    if (s1[i] == s2[i])
                        k++;
                }
            }
            Console.WriteLine($"Numarul de suprapuneri este de {k} ori");
        }

        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori
        /// apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        private static void P19()
        {
            Console.Write("Vectorul s[] este: ");

            string line1 = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t1 = line1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Vectorul p[] ese: ");

            string line2 = Console.ReadLine();
            string[] t2 = line2.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] s = new int[1000];
            int[] p = new int[1000];

            for (int i = 0; i < t1.Length; i++)
            {
                s[i] = int.Parse(t1[i]);
            }

            for (int i = 0; i < t2.Length; i++)
            {
                p[i] = int.Parse(t2[i]);
            }

            int cate = 0;
            bool ok;

            for (int i = 0; i < t1.Length; i++)
            {
                ok = true;
                for (int j = 0; j < t2.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                    cate++;
            }
            Console.WriteLine($"Vectorul p[] apare in vectorul s[] de {cate} ori");
        }

        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ
        /// coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
        /// </summary>
        private static void P18()
        {
            int n, x, result = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = n; i >= 0; i--)
                result = result + v[i] * (int)Math.Pow(x, i);
            Console.WriteLine($"Valoarea polinomului in punctul x={x} este {result}");
        }

        /// <summary>
        /// Se da un numar n in baza 10 si un numar b, 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.
        /// </summary>
        private static void P17()
        {
            int n, b, cifra;
            Stack<int> digits = new Stack<int>();

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int cn = n;
            while (cn > 0)
            {
                cifra = cn % b;
                digits.Push(cifra);
                cn /= b;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789ABCDEF";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }
            Console.WriteLine($"Numarul {n} in baza {b} este { sb.ToString()}");
        }

        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void P16()
        {
            int n, mincmmdc = int.MaxValue;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[n + 1];
            int[] ap = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (cmmdc(v[i], v[i + 1]) < mincmmdc)
                    mincmmdc = cmmdc(v[i], v[i + 1]);
            }
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {mincmmdc}");
        }

        private static int cmmdc(int a, int b)
        {
            int r;
            r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        /// </summary>
        private static void P15()
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[n + 1];
            int[] ap = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                ap[v[i]]++;
            }
            for (int i = 0; i < n; i++)
            {
                if (ap[v[i]] >= 2)
                {
                    for (int j = i; j < n; j++)
                        v[j] = v[j + 1];
                    n--;
                    i--;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la
        /// sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient -
        /// se va face o singura parcugere a vectorului). 
        /// </summary>
        private static void P14()
        {
            int n, i;

            Console.Write("Dati dimensiunea vectorului:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (i = 1; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (i = n - 1; i >= 0; i--)
            {
                if (v[i] == 0 && v[n - i - 1] != 0)
                    Swap(v, i, n - i - 1);
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
        /// </summary>
        private static void P13()
        {
            int n, i, k;

            Console.Write("Dati dimensiunea vectorului:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (i = 1; i < n; i++)
            {
                for (k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    Swap(v, k, k - 1);
                }
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        /// </summary>
        private static void P12()
        {
            int n, i, j, k;
            Console.Write("Dati dimensiunea vectorului:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (i = 0; i < n; i++)
            {
                k = i;
                for (j = i + 1; j < n; j++)
                {
                    if (v[j] < v[k])
                    {
                        k = j;
                    }
                }
                Swap(v, i, k);
            }
            for (i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        private static void Swap(int[] v, int i, int j)
        {
            int aux;
            aux = v[i];
            v[i] = v[j];
            v[j] = aux;
        }

        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        /// </summary>
        private static void P11()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];

            for (int i = 0; i < n; i++)
                v[i] = 0;
            v[0] = v[1] = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (v[i] == 0)
                {
                    for (int j = 2; j <= n / i; j++)
                        v[i * j] = 1;
                }
            }
            for (int i = 1; i <= n; i++)
                if (v[i] == 0)
                    Console.Write($"{i} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        private static void P10()
        {
            int n, k;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());


            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int p, u, mij, poz = -1;
            p = 0;
            u = n;
            while (p <= u)
            {
                mij = (p + u) / 2;
                if (k == v[mij])
                    poz = mij;
                if (k < v[mij])
                    u = mij - 1;
                else
                    p = mij + 1;
            }
            if (poz != -1)
                Console.WriteLine($"Elementul {k} se afla pe pozitia {poz}");
            else
                Console.WriteLine(poz);
        }

        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        private static void P9()
        {
            int n, k;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            while (k != 0)
            {
                int aux = v[0];
                for (int i = 1; i < n; i++)
                {
                    v[i - 1] = v[i];
                }
                v[n - 1] = aux;
                k--;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        private static void P8()
        {
            int n;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int aux = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i - 1] = v[i];
            }
            v[n - 1] = aux;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void P7()
        {
            int n;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n / 2; i++)
            {
                int aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        /// </summary>
        private static void P6()
        {
            int n, k;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = k; i < n; i++)
                v[i] = v[i + 1];
            n--;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
        /// Se cere sa se insereze valoarea e in vector pe pozitia k.
        /// Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>
        private static void P5()
        {
            int n, e, k;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = n - 1; i >= k; i--)
                v[i + 1] = v[i];
            v[k] = e;
            n++;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector 
        /// si de cate ori apar acestea. 
        /// </summary>
        private static void P4()
        {
            int n, minv = int.MaxValue, maxv = int.MinValue;
            int minap = 0, maxap = 0;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] < minv)
                {
                    minv = v[i];
                    minap = 1;
                }
                else if (v[i] == minv) minap++;
                if (v[i] > maxv)
                {
                    maxv = v[i];
                    maxap = 1;
                }
                else if (v[i] == maxv) maxap++;
            }
            Console.WriteLine($"Cel mai mic element din vector este {minv} si apare de {minap} ori");
            Console.WriteLine($"Cel mai mare element din vector este {maxv} si apare de {maxap} ori");
        }

        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
        /// </summary>
        private static void P3()
        {
            int n, minv = int.MaxValue, maxv = int.MinValue;
            int pozmin = -1, pozmax = -1;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] < minv)
                {
                    minv = v[i];
                    pozmin = i;
                }
                if (v[i] > maxv)
                {
                    maxv = v[i];
                    pozmax = i;
                }
            }
            Console.WriteLine($"Cel mai mic element din vector este {minv} si apare pe pozitia {pozmin}");
            Console.WriteLine($"Cel mai mare element din vector este {maxv} si apare pe pozitia {pozmax}");
        }

        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
        /// Daca k nu apare in vector rezultatul va fi -1. 
        /// </summary>
        private static void P2()
        {
            int n, k;
            int poz = -1;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] == k)
                {
                    poz = i;
                    break;
                }
            }
            if (poz != -1)
                Console.WriteLine($"Prima pozitie din vector pe care apare {k} este {poz}");
            else
                Console.WriteLine(poz);
        }

        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void P1()
        {
            int n, suma = 0;
            int[] v = new int[100];
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor din vector este {suma}");
        }
    }
}
