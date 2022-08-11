namespace OrdenarFast
{
    internal class Algoritmos
    {
        // //////////////////////////////////////////////////////
        private const bool ASCENDING = true;

        private readonly string PIVOT_FIRST = "Primeiro";
        private readonly string PIVOT_LAST = "Último";
        private readonly string PIVOT_MEDIAN3 = "Mediana";
        private readonly string PIVOT_MID = "Médio";
        private readonly string PIVOT_RANDOM = "Aleatório";
        private int compar;
        private string g_quicksort_pivot;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private int recursoes;
        private int trocas;
        private int externos;
        private ArrayItem[] vetor;

        //public Algoritmos(System.Windows.Forms.PictureBox pic)
        //{
        //p = pic;
        //}

        public Algoritmos(ArrayItem[]? v)
        {
            if (v == null)
                vetor = Array.Empty<ArrayItem>();
            else
                vetor = v;

            g_quicksort_pivot = "";
            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();
        }

        public event PopularEventHandler? Populou;

        public void Dispara(EventArgs e)
        {
            Populou?.Invoke(this, e);
        }

        private void Swap(int a, int b)
        {
            ArrayItem c;
            c = vetor[a];
            vetor[a] = vetor[b];
            vetor[b] = c;
            vetor[a].Mudou = true;
            vetor[b].Mudou = true;
            trocas++;
            l1.Text = "Trocas: " + trocas.ToString();
            //ChecaSegmentos();
        }

        /*private void ChecaSegmentos()
        {
            segmentos = 1;
            int i;
            for (i = 1; i < vetor.Length - 1; i++)
            {
                if (vetor[i].CompareTo(vetor[i - 1]) == -1)
                {
                    segmentos++;
                }
            }
            l4.Text = "Escrita em vetores externos: " + externos.ToString();
            l5.Text = "Segmentos: " + segmentos.ToString();
            l4.Refresh();
            l5.Refresh();
        }*/

        private void RmRecursao()
        {
            recursoes--;
            l2.Text = "Recursões: " + recursoes.ToString();
        }

        /*private static int PrevPowerOfTwo(int x)
        {
            x |= x >> 1; x |= x >> 2; x |= x >> 4;
            x |= x >> 8; x |= x >> 16;
            return x - (x >> 1);
        }*/

        private static int Comp(int v1, int v2)
        {
            return (v1 == v2 ? 0 : v1 < v2 ? -1 : +1);
        }

        private void ContaComparacao()
        {
            compar++;
            l3.Text = "Comparações: " + compar.ToString();
            if (compar % 100 == 0)
            {
                l3.Refresh();
                Dispara(new EventArgs());
            }
        }

        private static int GreatestPowerOfTwoLessThan(int n)
        {
            int k = 1;
            while (k < n)
            {
                k <<= 1;
            }

            return k >> 1;
        }

        private void AdRecursao()
        {
            recursoes++;
            l2.Text = "Recursões: " + recursoes.ToString();
            l2.Refresh();
        }

        public void SetVetor(ArrayItem[]? v)
        {
            if (v == null)
                vetor = Array.Empty<ArrayItem>();
            else
                vetor = v;
        }

        public void SetLabel(int i, Label l)
        {
            switch (i)
            {
                case 1:
                    l1 = l;
                    break;
                case 2:
                    l2 = l;
                    break;
                case 3:
                    l3 = l;
                    break;
                case 4:
                    l4 = l;
                    break;
            }
        }

        public void LimpaTXT()
        {
            trocas = 0;
            recursoes = 0;
            compar = 0;
            //segmentos = 0;
            externos = 0;
            l1.Text = "Trocas: " + trocas.ToString();
            l3.Text = "Comparações: " + compar.ToString();
            l2.Text = "Recursões: " + recursoes.ToString();
            l4.Text = "Escrita em vetores externos: " + externos.ToString();
            //l5.Text = "Segmentos: " + segmentos.ToString();
            l1.Refresh();
            l2.Refresh();
            l3.Refresh();
            l4.Refresh();
            //l5.Refresh();
        }

        // //////////////////////////////////////////////////////
        /*private bool isPowerOfTwo(int x)
        {
            int y = (~(x & (x - 1)));

            return ((x != 0) && (y != 0));
        }*/
        /*public void setLogText(TextBox t)
        {
            logText = t;
            logText.Text = "Log";
        }*/

        // //////////////////////////////////////////////////////
        public void BinaryInsertionSort()
        {
            ////ChecaSegmentos();
            for (int i = 1; i < vetor.Length; ++i)
            {
                int key = vetor[i].Valor;
                int lo = 0, hi = i;
                while (lo < hi)
                {
                    int mid = (lo + hi) / 2;
                    ContaComparacao();
                    if (key <= vetor[mid].Valor)
                    {
                        hi = mid;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                // item has to go into position lo

                int j = i - 1;
                while (j >= lo)
                {
                    Swap(j, j + 1);
                    j--;
                }
                ////ChecaSegmentos();
            }
        }
        // //////////////////////////////////////////////////////
        public void BitonicSort()
        {
            BitonicSort(0, vetor.Length, ASCENDING);
        }

        private void Bitonic_compare(int i, int j, bool dir)
        {
            ContaComparacao();
            if (dir == (vetor[i].CompareTo(vetor[j]) == 1))
            {
                Swap(i, j);
            }
        }

        private void BitonicMerge(int lo, int n, bool dir)
        {
            AdRecursao();
            if (n > 1)
            {
                int m = GreatestPowerOfTwoLessThan(n);
                for (int i = lo; i < lo + n - m; i++)
                {
                    Bitonic_compare(i, i + m, dir);
                }

                BitonicMerge(lo, m, dir);
                BitonicMerge(lo + m, n - m, dir);
            }
            RmRecursao();
        }

        private void BitonicSort(int lo, int n, bool dir)
        {
            ////ChecaSegmentos();
            AdRecursao();
            if (n > 1)
            {
                int m = n / 2;
                BitonicSort(lo, m, !dir);
                BitonicSort(lo + m, n - m, dir);
                BitonicMerge(lo, n, dir);
            }
            RmRecursao();
        }
        // //////////////////////////////////////////////////////
        public void BubbleSort()
        {
            ////ChecaSegmentos();
            for (int i = 0; i < vetor.Length - 1; ++i)
            {
                for (int j = 0; j < vetor.Length - 1 - i; ++j)
                {
                    ContaComparacao();
                    if (vetor[j].CompareTo(vetor[j + 1]) == 1)
                    {
                        Swap(j, j + 1);
                        Application.DoEvents();
                        //Pausa();
                    }
                }
            }
        }
        // //////////////////////////////////////////////////////
        public void BubbleSort2()
        {
            int i;
            int j;
            int max;
            int maxidx = 0;
            ////ChecaSegmentos();
            for (i = vetor.Length - 1; i >= 0; i--)
            {
                max = 0;
                for (j = 0; j < i; j++)
                {
                    ContaComparacao();

                    if (max < vetor[j].Valor)
                    {
                        max = vetor[j].Valor;
                        maxidx = j;
                    }
                }
                ContaComparacao();
                if (vetor[i].CompareTo(vetor[maxidx]) == -1)
                {
                    Swap(i, maxidx);
                }
            }
            //ChecaSegmentos();
        }
        // //////////////////////////////////////////////////////
        public void BubbleSort3()
        {
            int i;
            //int j;
            int max;
            int maxidx = 0;
            int minidx = vetor.Length - 1;
            int min;
            int inicio = 0;
            int final = vetor.Length;

            //ChecaSegmentos();
            while (inicio < final)
            {
                max = 0;
                min = vetor.Max().Valor + 1;
                for (i = inicio; i < final; i++)
                {
                    if (max < vetor[i].Valor)
                    {
                        max = vetor[i].Valor;
                        maxidx = i;
                    }
                    ContaComparacao();
                    if (min > vetor[i].Valor)
                    {
                        min = vetor[i].Valor;
                        minidx = i;
                    }
                }
                ContaComparacao();
                if (vetor[final - 1].CompareTo(vetor[maxidx]) == -1)
                {
                    Swap(maxidx, final - 1);

                    if ((final - 1) == minidx)
                    {
                        minidx = maxidx;
                    }
                }
                ContaComparacao();
                if (vetor[inicio].CompareTo(vetor[minidx]) == 1)
                {
                    Swap(minidx, inicio);
                }
                final--;
                inicio++;
            }
            //ChecaSegmentos();
        }
        // //////////////////////////////////////////////////////
        public void CocktailShakerSort()
        {
            int lo = 0;
            int hi = vetor.Length - 1;
            int mov = lo;

            //ChecaSegmentos();
            while (lo < hi)
            {
                for (int i = hi; i > lo; --i)
                {
                    ContaComparacao();
                    if (vetor[i - 1].CompareTo(vetor[i]) == 1)
                    {
                        Swap(i - 1, i);
                        mov = i;
                    }
                }
                lo = mov;

                for (int i = lo; i < hi; ++i)
                {
                    ContaComparacao();
                    if (vetor[i].CompareTo(vetor[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        mov = i;
                    }
                }
                hi = mov;
            }
        }
        // //////////////////////////////////////////////////////
        public void CombSort()
        {
            const double shrink = 1.3;

            bool swapped = false;
            int gap = vetor.Length;
            //ChecaSegmentos();
            while ((gap > 1) || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)((float)gap / shrink);
                }

                swapped = false;

                for (int i = 0; gap + i < vetor.Length; ++i)
                {
                    ContaComparacao();
                    if (vetor[i].CompareTo(vetor[i + gap]) == 1)
                    {
                        Swap(i, i + gap);
                        swapped = true;
                    }
                }
            }
        }
        // //////////////////////////////////////////////////////
        public void CountingSort()
        {
            int max = vetor.Length - 1;
            int mc = vetor.Max().Valor;
            long[] cnt = new long[mc + 1];
            int[] b = new int[max + 1];
            long idx;

            //ChecaSegmentos();
            cnt.Initialize();
            int j;

            for (j = 0; j <= max; j++)
            {
                int l = vetor[j].Valor;
                cnt[l]++;
                b[j] = vetor[j].Valor;
                externos++;
            }
            for (int i = 1; i <= mc; i++)
            {
                cnt[i] = cnt[i] + cnt[i - 1];
                externos++;
            }
            for (j = max; j >= 0; j--)
            {
                idx = vetor[j].Valor;
                b[cnt[idx] - 1] = vetor[j].Valor;
                externos++;
                cnt[idx]--;
            }
            for (j = 0; j <= max; j++)
            {
                vetor[j].Valor = b[j];
            }
            l4.Text = "Escrita em vetores externos: " + externos.ToString();
            //l4.Refresh();
            //ChecaSegmentos();
        }
        // //////////////////////////////////////////////////////
        public void CycleSort()
        {
            int cycle_start;
            int tmp;
            //ChecaSegmentos();
            for (cycle_start = 0; cycle_start < vetor.Length - 1; cycle_start++)
            {
                int item = vetor[cycle_start].Valor;
                int pos = cycle_start;

                for (int i = cycle_start + 1; i < vetor.Length; i++)
                {
                    ContaComparacao();
                    if (vetor[i].Valor < item)
                    {
                        pos++;
                    }
                }

                if (pos != cycle_start)
                {
                    while (item == vetor[pos].Valor)
                    {
                        ContaComparacao();
                        pos++;
                    }

                    tmp = vetor[pos].Valor;
                    vetor[pos].Valor = item;
                    item = tmp;

                    while (pos != cycle_start)
                    {
                        pos = cycle_start;
                        for (int i = cycle_start + 1; i < vetor.Length; i++)
                        {
                            ContaComparacao();
                            if (vetor[i].Valor < item)
                            {
                                pos++;
                            }

                        }
                        while (item == vetor[pos].Valor)
                        {
                            ContaComparacao();
                            pos++;
                        }
                        tmp = vetor[pos].Valor;
                        vetor[pos].Valor = item;
                        item = tmp;
                    }
                }
            }
            //ChecaSegmentos();
        }
        // //////////////////////////////////////////////////////
        public void GnomeSort()
        {
            //ChecaSegmentos();
            for (int i = 1; i < vetor.Length;)
            {
                ContaComparacao();
                if (vetor[i].CompareTo(vetor[i - 1]) >= 0)
                {
                    ++i;
                }
                else
                {
                    Swap(i, i - 1);
                    if (i > 1)
                    {
                        --i;
                    }
                }
            }
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////
        public void HeapSort()
        {
            int n = vetor.Length, i = n / 2;
            //ChecaSegmentos();

            while (true)
            {
                if (i > 0)
                {
                    // build heap, sift A[i] down the heap
                    i--;
                }
                else
                {

                    // pop largest element from heap: swap front to back, and sift
                    // front A[0] down the heap
                    n--;
                    if (n == 0)
                    {
                        return;
                    }

                    Swap(0, n);
                }

                int parent = i;
                int child = i * 2 + 1;

                // sift operation - push the value of A[i] down the heap
                while (child < n)
                {
                    ContaComparacao();
                    if (child + 1 < n && (vetor[child + 1].CompareTo(vetor[child]) == 1))
                    {
                        child++;
                    }
                    ContaComparacao();
                    if (vetor[child].CompareTo(vetor[parent]) == 1)
                    {
                        Swap(parent, child);
                        parent = child;
                        child = parent * 2 + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        // //////////////////////////////////////////////////////
        public void InsertSort()
        {
            //ChecaSegmentos();
            for (int i = 1; i < vetor.Length; ++i)
            {
                int key = vetor[i].Valor;

                int j = i - 1;
                while (j >= 0 && vetor[j].Valor > key)
                {
                    ContaComparacao();
                    Swap(j, j + 1);
                    j--;
                }
            }
        }
        // //////////////////////////////////////////////////////
        public void InsertSort2()
        {
            //ChecaSegmentos();
            for (int i = 1; i < vetor.Length; ++i)
            {
                int tmp, key = vetor[i].Valor;

                int j = i - 1;
                while (j >= 0 && (tmp = vetor[j].Valor) > key)
                {
                    ContaComparacao();
                    vetor[j + 1].Valor = tmp;
                    j--;
                }
                vetor[j + 1].Valor = key;
            }
        }
        // //////////////////////////////////////////////////////
        public void OddEvenSort()
        {
            bool sorted = false;
            //ChecaSegmentos();
            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i < vetor.Length - 1; i += 2)
                {
                    ContaComparacao();
                    if (vetor[i].CompareTo(vetor[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        sorted = false;
                    }
                }

                for (int i = 0; i < vetor.Length - 1; i += 2)
                {
                    ContaComparacao();
                    if (vetor[i].CompareTo(vetor[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        sorted = false;
                    }
                }
            }
        }
        // //////////////////////////////////////////////////////
        private void Flip(int k)
        {
            int left = 0;
            while (left < k)
            {
                Swap(k, left);
                k--;
                left++;
            }
        }

        private int MaxIndex(int k)
        {
            int index = 0;
            for (int i = 0; i < k; i++)
            {
                ContaComparacao();
                if (vetor[i].CompareTo(vetor[index]) == 1)
                {
                    index = i;
                }
            }
            return index;
        }

        public void PancakeSort(int n)
        {
            int maxdex;
            while (n > 1)
            {
                maxdex = MaxIndex(n);
                if (maxdex != n)
                {
                    Flip(maxdex);
                    Flip(n - 1);
                }
                n--;
            }
        }

        public void PancakeSort()
        {
            //ChecaSegmentos();
            PancakeSort(vetor.Length);
        }
        // //////////////////////////////////////////////////////
        public void SetQuickSortPivot(string q)
        {
            g_quicksort_pivot = q;
        }

        public void QuickSortDualPivot()
        {
            QuickSortDualPivotYaroslavskiy(0, vetor.Length - 1);
        }

        public void QuickSortLL()
        {
            QuickSortLL(0, vetor.Length);
        }

        public void QuickSortLR()
        {
            QuickSortLR(0, vetor.Length - 1);
        }

        public void QuickSortTernaryLR()
        {
            QuickSortTernaryLR(0, vetor.Length - 1);
        }

        private void QuickSortDualPivotYaroslavskiy(int left, int right)
        {
            //ChecaSegmentos();
            AdRecursao();

            if (right > left)
            {
                ContaComparacao();
                if (vetor[left].CompareTo(vetor[right]) == 1)
                {
                    Swap(left, right);
                }

                int p1 = vetor[left].Valor;
                int q = vetor[right].Valor;

                int l = left + 1;
                int g = right - 1;
                int k = l;

                while (k <= g)
                {
                    //MarkArr[k] = 1;
                    ContaComparacao();
                    if (vetor[k].Valor < p1)
                    {
                        Swap(k, l);
                        ++l;
                    }
                    else if (vetor[k].Valor >= q)
                    {
                        while (vetor[g].Valor > q && k < g)
                        {
                            --g;
                        }

                        Swap(k, g);
                        --g;

                        if (vetor[k].Valor < p1)
                        {
                            Swap(k, l);
                            ++l;
                        }
                    }
                    ++k;
                }
                --l;
                ++g;
                Swap(left, l);
                Swap(right, g);

                QuickSortDualPivotYaroslavskiy(left, l - 1);
                QuickSortDualPivotYaroslavskiy(l + 1, g - 1);
                QuickSortDualPivotYaroslavskiy(g + 1, right);
            }
            RmRecursao();
        }

        private int QuickSortSelectPivot(int lo, int hi)
        {
            Random rnd = new();
            if (g_quicksort_pivot == PIVOT_FIRST)
            {
                return lo;
            }

            if (g_quicksort_pivot == PIVOT_LAST)
            {
                return hi - 1;
            }

            if (g_quicksort_pivot == PIVOT_MID)
            {
                return (lo + hi) / 2;
            }

            if (g_quicksort_pivot == PIVOT_RANDOM)
            {
                return lo + (rnd.Next() % (hi - lo));
            }

            if (g_quicksort_pivot == PIVOT_MEDIAN3)
            {
                int mid = (lo + hi) / 2;

                // cases if two are equal
                if (vetor[lo].CompareTo(vetor[mid]) == 0)
                {
                    return lo;
                }

                if (vetor[lo].CompareTo(vetor[hi - 1]) == 0 || vetor[mid].CompareTo(vetor[hi - 1]) == 0)
                {
                    return hi - 1;
                }

                // cases if three are different
                return vetor[lo].CompareTo(vetor[mid]) == -1
                    ? (vetor[mid].CompareTo(vetor[hi - 1]) == -1 ? mid : (vetor[lo].CompareTo(vetor[hi - 1]) == -1 ? hi - 1 : lo))
                    : (vetor[mid].CompareTo(vetor[hi - 1]) == 1 ? mid : (vetor[lo].CompareTo(vetor[hi - 1]) == -1 ? lo : hi - 1));
            }

            return lo;
        }

        private void QuickSortLL(int lo, int hi)
        {
            AdRecursao();
            if (lo + 1 < hi)
            {
                int mid = QuickSortLLPartition(lo, hi);

                QuickSortLL(lo, mid);
                QuickSortLL(mid + 1, hi);
            }
            RmRecursao();
            //ChecaSegmentos();
        }

        private int QuickSortLLPartition(int lo, int hi)
        {

            // pick pivot and move to back
            int p1 = QuickSortSelectPivot(lo, hi);

            int pivot = vetor[p1].Valor;
            Swap(p1, hi - 1);
            int i = lo;

            for (int j = lo; j < hi - 1; ++j)
            {
                ContaComparacao();
                if (vetor[j].Valor <= pivot)
                {
                    Swap(i, j);
                    ++i;
                }
            }

            Swap(i, hi - 1);
            return i;
        }

        private void QuickSortLR(int lo, int hi)
        {
            AdRecursao();
            // pick pivot and watch
            int p1 = QuickSortSelectPivot(lo, hi + 1);

            int pivot = vetor[p1].Valor;

            //Pausa();

            int i = lo, j = hi;

            while (i <= j)
            {
                while (vetor[i].Valor < pivot)
                {
                    ContaComparacao();
                    i++;
                }

                while (vetor[j].Valor > pivot)
                {
                    ContaComparacao();
                    j--;
                }

                if (i <= j)
                {
                    Swap(i, j);

                    // follow pivot if it is swapped
                    if (p1 == i)
                    {
                        p1 = j;
                    }
                    else if (p1 == j)
                    {
                        p1 = i;
                    }

                    i++;
                    j--;
                }
            }

            if (lo < j)
            {
                QuickSortLR(lo, j);
            }

            if (i < hi)
            {
                QuickSortLR(i, hi);
            }

            RmRecursao();
            //ChecaSegmentos();
        }

        private void QuickSortTernaryLR(int lo, int hi)
        {
            //ChecaSegmentos();
            AdRecursao();

            if (hi <= lo)
            {
                return;
            }

            int cmp;

            // pick pivot and swap to back
            int piv = QuickSortSelectPivot(lo, hi + 1);
            Swap(piv, hi);

            int pivot = vetor[hi].Valor;

            // schema: |p ===  |i <<< | ??? |j >>> |q === |piv
            int i = lo;
            int j = hi - 1;
            int p1 = lo;
            int q = hi - 1;

            for (; ; )
            {
                // partition on left
                while (i <= j && ((cmp = Comp(vetor[i].Valor, pivot)) <= 0))
                {
                    if (cmp == 0)
                    {
                        Swap(i, p1++);
                    }
                    ++i;
                }

                // partition on right
                while (i <= j && ((cmp = Comp(vetor[j].Valor, pivot)) >= 0))
                {
                    if (cmp == 0)
                    {
                        Swap(j, q--);
                    }
                    --j;
                }

                if (i > j)
                {
                    break;
                }

                // swap item between < > regions
                Swap(i++, j--);
            }

            // swap pivot to right place
            Swap(i, hi);

            int num_less = i - p1;
            int num_greater = q - j;

            // swap equal ranges into center, but avoid swapping equal elements
            j = i - 1; i += 1;

            int pe = lo + Math.Min(p1 - lo, num_less);
            for (int k = lo; k < pe; k++, j--)
            {
                Swap(k, j);
            }

            int qe = hi - 1 - Math.Min(hi - 1 - q, num_greater - 1); // one already greater at end
            for (int k = hi - 1; k > qe; k--, i++)
            {
                Swap(i, k);
            }
            //Pausa();

            QuickSortTernaryLR(lo, lo + num_less - 1);
            QuickSortTernaryLR(hi - num_greater + 1, hi);
            RmRecursao();
            //ChecaSegmentos();
        }
        // //////////////////////////////////////////////////////
        public void RadixSortLSD()
        {
            // radix and base calculations
            const int RADIX = 4;

            uint pmax = (uint)Math.Ceiling(Math.Log(vetor.Max().Valor + 1) / Math.Log(RADIX));
            //ChecaSegmentos();
            for (uint p1 = 0; p1 < pmax; ++p1)
            {
                int base1 = (int)Math.Pow(RADIX, p1);

                // count digits and copy data
                int[] count = new int[RADIX];
                count.Initialize();
                int[] copy = new int[vetor.Length];
                copy.Initialize();

                for (int i = 0; i < vetor.Length; ++i)
                {
                    copy[i] = vetor[i].Valor;
                    externos++;
                    int r = copy[i] / base1 % RADIX;
                    count[r]++;
                    externos++;
                }

                // exclusive prefix sum
                int[] bkt = new int[RADIX + 1];
                bkt.Initialize();
                for (int z = 0; z < count.Length; z++)
                {
                    for (int y = 0; y <= z; y++)
                    {
                        bkt[z + 1] += count[y];
                        externos++;
                    }
                }

                // mark bucket boundaries
                for (int i = 0; i < bkt.Length - 1; ++i)
                {
                    if (bkt[i] >= vetor.Length)
                    {
                        continue;
                    }
                }

                // redistribute items back into array (stable)
                for (int i = 0; i < vetor.Length; ++i)
                {
                    int r = copy[i] / base1 % RADIX;
                    vetor[bkt[r]++].Valor = copy[i];
                }

                l4.Text = "Escrita em vetores externos: " + externos.ToString();
                //l4.Refresh();
            }
        }
        // //////////////////////////////////////////////////////
        private void RadixSortMSD(int lo, int hi, int depth)
        {
            //ChecaSegmentos();
            AdRecursao();

            // radix and base calculations
            const uint RADIX = 4;

            uint pmax = (uint)Math.Floor(Math.Log(vetor.Max().Valor + 1) / Math.Log(RADIX));

            uint base1 = (uint)Math.Pow(RADIX, pmax - depth);

            // count digits
            //std::vector<size_t> count(RADIX, 0);
            int[] count = new int[RADIX];
            count.Initialize();

            for (int i = lo; i < hi; ++i)
            {
                uint r = (uint)vetor[i].Valor / base1 % RADIX;
                count[r]++;
                externos++;
            }

            // inclusive prefix sum
            //std::vector<size_t> bkt(RADIX, 0);
            //std::partial_sum(count.begin(), count.end(), bkt.begin());
            int[] bkt = new int[RADIX];
            bkt.Initialize();
            for (int z = 0; z < count.Length; z++)
            {
                for (int y = 0; y <= z; y++)
                {
                    bkt[z] += count[y];
                    externos++;
                }
            }

            // mark bucket boundaries
            for (int i = 0; i < bkt.Length; ++i)
            {
                if (bkt[i] == 0)
                {
                    continue;
                }
            }

            l4.Text = "Escrita em vetores externos: " + externos.ToString();
            l4.Refresh();

            // reorder items in-place by walking cycles
            for (int i = 0, j; i < (hi - lo);)
            {
                while ((j = --bkt[(vetor[lo + i].Valor / base1 % RADIX)]) > i)
                {
                    Swap(lo + i, lo + j);
                }
                //Pausa();
                i += count[(vetor[lo + i].Valor / base1 % RADIX)];
            }

            // no more depth to sort?
            if (depth + 1 > pmax)
            {
                return;
            }

            // recurse on buckets
            int sum = lo;
            for (int i = 0; i < RADIX; ++i)
            {
                if (count[i] <= 1)
                {
                    continue;
                }

                RadixSortMSD(sum, sum + count[i], depth + 1);
                sum += count[i];
            }
            RmRecursao();
        }

        public void RadixSortMSD()
        {
            RadixSortMSD(0, vetor.Length, 0);
        }
        // //////////////////////////////////////////////////////
        public void SelectionSort()
        {
            //ChecaSegmentos();
            for (int i = 0; i < vetor.Length - 1; ++i)
            {
                int jMin = i;
                for (int j = i + 1; j < vetor.Length; ++j)
                {
                    ContaComparacao();
                    if (vetor[j].CompareTo(vetor[jMin]) == -1)
                    {
                        jMin = j;
                    }
                }


                Swap(i, jMin);
            }
        }
        // //////////////////////////////////////////////////////
        public void ShellSort()
        {
            int[] incs = { 1391376, 463792, 198768, 86961, 33936, 13776, 4592, 1968, 861, 336, 112, 48, 21, 7, 3, 1 };
            //ChecaSegmentos();
            for (int k = 0; k < 16; k++)
            {
                for (int h = incs[k], i = h; i < vetor.Length; i++)
                {
                    int v = vetor[i].Valor;
                    int j = i;
                    while (j >= h && vetor[j - h].Valor > v)
                    {
                        ContaComparacao();
                        vetor[j].Valor = vetor[j - h].Valor;
                        j -= h;
                    }
                    vetor[j].Valor = v;
                }
            }
        }
        // //////////////////////////////////////////////////////

        private void Merge(int lo, int mid, int hi)
        {
            int[] outA;

            //ChecaSegmentos();
            // mark merge boundaries

            // allocate output
            outA = new int[hi - lo];
            //std::vector < value_type > out(hi - lo);

            // merge
            int i = lo; int j = mid; int o = 0; // first and second halves
            while (i < mid && j < hi)
            {
                // copy out for fewer time steps
                int ai = vetor[i].Valor;
                int aj = vetor[j].Valor;
                ContaComparacao();
                if (ai < aj)
                {
                    ++i;
                    outA[o++] = ai;
                }
                else
                {
                    ++j;
                    outA[o++] = aj;
                }
                externos++;
            }

            // copy rest
            while (i < mid)
            {
                outA[o++] = vetor[i++].Valor;
            }

            while (j < hi)
            {
                outA[o++] = vetor[j++].Valor;
            }
            externos++;

            l4.Text = "Escrita em vetores externos: " + externos.ToString();
            //l4.Refresh();

            // copy back
            for (i = 0; i < hi - lo; ++i)
            {
                vetor[lo + i].Valor = outA[i];
            }
        }

        private void MergeSort(int lo, int hi)
        {
            //ChecaSegmentos();
            AdRecursao();
            if (lo + 1 < hi)
            {
                int mid = (lo + hi) / 2;

                MergeSort(lo, mid);
                MergeSort(mid, hi);

                Merge(lo, mid, hi);
            }
            RmRecursao();
        }

        public void MergeSort()
        {
            MergeSort(0, vetor.Length);
        }
        // //////////////////////////////////////////////////////
        public void GravitySort()
        {
            int max = vetor.Max().Valor;
            Array[] abacus;
            int i;
            int j;
            int droppos;
            int count;
            int x;
            int y;

            abacus = new Array[vetor.Length];
            for (i = 0; i < abacus.Length; i++)
            {
                abacus[i] = new int[max];
            }
            for (i = 0; i < vetor.Length; i++)
            {
                for (j = 0; j < vetor[i].Valor; j++)
                {
                    abacus[i].SetValue(1, abacus[0].Length - j - 1);
                    externos++;

                    l4.Text = "Escrita em vetores externos: " + externos.ToString();
                    l4.Refresh();
                }
            }
            for (i = 0; i < abacus[0].Length; i++)
            {
                for (j = 0; j < abacus.Length; j++)
                {
                    if ((int)abacus[j].GetValue(i) == 1)
                    {
                        droppos = j;
                        while (droppos + 1 < abacus.Length && (int)abacus[droppos].GetValue(i) == 1)
                        {
                            droppos++;
                        }
                        if ((int)abacus[droppos].GetValue(i) == 0)
                        {
                            abacus[j].SetValue(0, i);
                            abacus[droppos].SetValue(1, i);
                            externos++;

                            l4.Text = "Escrita em vetores externos: " + externos.ToString();
                            l4.Refresh();
                        }
                    }
                }
                count = 0;
                for (x = 0; x < abacus.Length; x++)
                {
                    count = 0;
                    for (y = 0; y < abacus[0].Length; y++)
                    {
                        count += (int)abacus[x].GetValue(y);
                    }
                    vetor[x].Valor = count;
                }
            }
        }
        // //////////////////////////////////////////////////////
        private void SlowSort(int i, int j)
        {
            //ChecaSegmentos();
            AdRecursao();
            if (i >= j)
            {
                RmRecursao();
                return;
            }

            int m = (i + j) / 2;

            SlowSort(i, m);
            SlowSort(m + 1, j);

            ContaComparacao();
            if (vetor[m].CompareTo(vetor[j]) == 1)
            {
                Swap(m, j);
            }
            SlowSort(i, j - 1);

            RmRecursao();
        }
        public void SlowSort()
        {
            SlowSort(0, vetor.Length - 1);
            //ChecaSegmentos();
        }

        /*public ArrayItem ArrayItem
        {
            get => default;
            set
            {
            }
        }*/
        // //////////////////////////////////////////////////////

    }
}
