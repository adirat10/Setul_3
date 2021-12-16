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
