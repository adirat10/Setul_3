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
            P19();
        }

        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori
        /// apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
        /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        private static void P19()
        {

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
