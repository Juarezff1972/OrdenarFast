namespace OrdenarFast
{
    public delegate void EscritaEventHandler(object sender, EventArgs e);
    public delegate void PopularEventHandler(object sender, EventArgs e);

    public partial class Form1 : Form
    {
        const string BINARYINSERTIONSORT = "BinaryInsertionSort";
        const string BITONICSORT = "BitonicSort";
        const string BUBBLESORT = "BubbleSort";
        const string BUBBLESORT2 = "BubbleSort2";
        const string BUBBLESORT3 = "BubbleSort3";
        const string COCKTAILSHAKERSORT = "CocktailShakerSort";
        const string COMBSORT = "CombSort";
        const string COUNTINGSORT = "CountingSort";
        const string CYCLESORT = "CycleSort";
        const string FLASHSORT = "FlashSort";
        const string GNOMESORT = "GnomeSort";
        const string GRAVITYSORT = "GravitySort";
        const string HEAPSORT = "HeapSort";
        const string INSERTSORT = "InsertSort";
        const string INSERTSORT2 = "InsertSort2";
        const string MERGESORT = "MergeSort";
        const string ODDEVENSORT = "OddEvenSort";
        const string PANCAKESORT = "PancakeSort";
        const string PIGEONHOLESORT = "PigeonHoleSort";
        const string QUICKSORTDUALPIVOT = "QuickSortDualPivot";
        const string QUICKSORTLL = "QuickSortLL";
        const string QUICKSORTLR = "QuickSortLR";
        const string QUICKSORTTERNARYLR = "QuickSortTernaryLR";
        const string RADIXSORTLSD = "RadixSortLSD";
        const string RADIXSORTMSD = "RadixSortMSD";
        const string SELECTIONSORT = "SelectionSort";
        const string SHELLSORT = "ShellSort";
        const string SLOWSORT = "SlowSort";
        const string TOURNAMENTSORT = "TournamentSort";
        const string AMERICANSORT = "AmericanFlagSort";
        const string SIMPLISTICGRAVITYSORT = "SimplisticGravitySort";
        const string SANDPAPERSORT = "SandpaperSort";
        const string DIAMONDSORT = "DiamondSort";

        private int escritas;
        private int[]? m_array;
        private byte ordem;
        private ArrayItem[]? vetor;

        public Form1()
        {
            InitializeComponent();
            ordem = 1;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string? x;
            Algoritmos algo;

            x = comboBox1.SelectedItem.ToString();
            PopularEventHandler d1 = new PopularEventHandler(OnPopular);
            algo = new Algoritmos(vetor);
            algo.SetLabel(1, label3);
            algo.SetLabel(2, label4);
            algo.SetLabel(3, label5);
            algo.SetLabel(4, label10);
            //algo.SetVetor(vetor);
            algo.SetQuickSortPivot(qsPivotSel1.Text);
            algo.LimpaTXT();
            algo.Populou += d1;

            algo.mostrar = mostrar.Checked;

            button1.Enabled = false;
            button2.Enabled = false;

            label7.Text = "Tempo: 0ms";
            label7.Refresh();

            var watch = new System.Diagnostics.Stopwatch();
            escritas = 0;
            label6.Text = "Escritas: " + escritas.ToString();
            label6.Refresh();

            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;

            watch.Start();

            Form1.ActiveForm.Text = x;
            switch (x)
            {
                case INSERTSORT:
                    algo.InsertSort();
                    break;

                case SELECTIONSORT:
                    algo.SelectionSort();
                    break;

                case INSERTSORT2:
                    algo.InsertSort2();
                    break;

                case BINARYINSERTIONSORT:
                    algo.BinaryInsertionSort();
                    break;

                case MERGESORT:
                    algo.MergeSort();
                    break;

                case BUBBLESORT:
                    algo.BubbleSort();
                    break;

                case BUBBLESORT2:
                    algo.BubbleSort2();
                    break;

                case BUBBLESORT3:
                    algo.BubbleSort3();
                    break;

                case COCKTAILSHAKERSORT:
                    algo.CocktailShakerSort();
                    break;

                case GNOMESORT:
                    algo.GnomeSort();
                    break;

                case COMBSORT:
                    algo.CombSort();
                    break;

                case ODDEVENSORT:
                    algo.OddEvenSort();
                    break;

                case SHELLSORT:
                    algo.ShellSort();
                    break;

                case QUICKSORTLR:
                    algo.QuickSortLR();
                    break;

                case QUICKSORTLL:
                    algo.QuickSortLL();
                    break;

                case QUICKSORTTERNARYLR:
                    algo.QuickSortTernaryLR();
                    break;

                case QUICKSORTDUALPIVOT:
                    algo.QuickSortDualPivot();
                    break;

                case HEAPSORT:
                    algo.HeapSort();
                    break;

                case RADIXSORTMSD:
                    algo.RadixSortMSD();
                    break;

                case RADIXSORTLSD:
                    algo.RadixSortLSD();
                    break;

                case COUNTINGSORT:
                    algo.CountingSort();
                    break;

                case BITONICSORT:
                    algo.BitonicSort();
                    break;

                case SLOWSORT:
                    algo.SlowSort();
                    break;

                case CYCLESORT:
                    algo.CycleSort();
                    break;

                case PANCAKESORT:
                    algo.PancakeSort();
                    break;

                case GRAVITYSORT:
                    algo.GravitySort();
                    break;

                case FLASHSORT:
                    algo.FlashSort();
                    break;

                case PIGEONHOLESORT:
                    algo.pigeonholeSort();
                    break;

                case TOURNAMENTSORT:
                    algo.tournamentSort();
                    break;

                case AMERICANSORT:
                    algo.AmericanSort();
                    break;

                case SIMPLISTICGRAVITYSORT:
                    algo.SimplisticGravitySort();
                    break;

                case SANDPAPERSORT:
                    algo.SandpaperSort();
                    break;

                case DIAMONDSORT:
                    algo.DiamondSort();
                    break;

                default:
                    break;
            }
            watch.Stop();

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;

            label7.Text = "Tempo: " + watch.ElapsedMilliseconds + "ms";
            label7.Refresh();
            label6.Refresh();

            button1.Enabled = true;
            button2.Enabled = true;

            Popular();
        }

        private void Popular()
        {
            textBox1.Clear();
            if (vetor != null)
            {
                textBox1.Text = string.Join(" - ", (object[])vetor);
            }
            textBox1.Refresh();
        }

        public virtual void OnPopular(object sender, EventArgs e)
        {
            if (mostrar.Checked) Popular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? x;
            x = comboBox1.SelectedItem.ToString();
            qsPivotSel1.Visible = false;
            if (x != null)
            {
                if (x.StartsWith("Quick"))
                {
                    qsPivotSel1.Visible = true;
                    qsPivotSel1.SelectedIndex = 0;
                }
            }
        }

        public void ContaEscrita()
        {
            escritas++;
            label6.Text = "Escritas: " + escritas.ToString();
            //label6.Refresh();
            //Popular();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(BINARYINSERTIONSORT);
            this.comboBox1.Items.Add(BITONICSORT);
            this.comboBox1.Items.Add(BUBBLESORT);
            this.comboBox1.Items.Add(BUBBLESORT2);
            this.comboBox1.Items.Add(BUBBLESORT3);
            this.comboBox1.Items.Add(COCKTAILSHAKERSORT);
            this.comboBox1.Items.Add(COMBSORT);
            this.comboBox1.Items.Add(COUNTINGSORT);
            this.comboBox1.Items.Add(CYCLESORT);
            this.comboBox1.Items.Add(FLASHSORT);
            this.comboBox1.Items.Add(GNOMESORT);
            this.comboBox1.Items.Add(GRAVITYSORT);
            this.comboBox1.Items.Add(HEAPSORT);
            this.comboBox1.Items.Add(INSERTSORT);
            this.comboBox1.Items.Add(INSERTSORT2);
            this.comboBox1.Items.Add(MERGESORT);
            this.comboBox1.Items.Add(ODDEVENSORT);
            this.comboBox1.Items.Add(PANCAKESORT);
            this.comboBox1.Items.Add(PIGEONHOLESORT);
            this.comboBox1.Items.Add(QUICKSORTDUALPIVOT);
            this.comboBox1.Items.Add(QUICKSORTLL);
            this.comboBox1.Items.Add(QUICKSORTLR);
            this.comboBox1.Items.Add(QUICKSORTTERNARYLR);
            this.comboBox1.Items.Add(RADIXSORTLSD);
            this.comboBox1.Items.Add(RADIXSORTMSD);
            this.comboBox1.Items.Add(SELECTIONSORT);
            this.comboBox1.Items.Add(SHELLSORT);
            this.comboBox1.Items.Add(SLOWSORT);
            this.comboBox1.Items.Add(TOURNAMENTSORT);
            this.comboBox1.Items.Add(AMERICANSORT);
            this.comboBox1.Items.Add(SIMPLISTICGRAVITYSORT);
            this.comboBox1.Items.Add(SANDPAPERSORT);
            this.comboBox1.Items.Add(DIAMONDSORT);
            this.comboBox1.Sorted = true;

            this.FormBorderStyle = FormBorderStyle.Sizable;
            Resetar();

            comboBox1.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ordem = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ordem = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ordem = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ordem = 4;
        }

        public virtual void OnEscreveu(object sender, EventArgs e)
        {
            ContaEscrita();
        }

        private void Resetar()
        {
            int nums = (int)numericUpDown2.Value;
            int i;

            escritas = 0;
            label6.Text = "Escritas: " + escritas.ToString();


            m_array = Enumerable.Range(1, nums).ToArray();
            if (ordem == 3)
            {
                m_array = m_array.Reverse().ToArray();
            }
            if (ordem == 1)
            {
                Random rnd = new();
                m_array = m_array.OrderBy(c => rnd.Next()).ToArray();
            }
            if (ordem == 4)
            {
                int max = m_array.Max();
                double ang;
                for (i = 0; i < m_array.Length; i++)
                {
                    ang = ((float)m_array[i] / max) * Math.PI * 2;
                    m_array[i] = (int)Math.Round((Math.Sin(ang) * max / 2) + (max / 2));
                }
            }
            vetor = new ArrayItem[m_array.Length];
            vetor.Initialize();

            for (i = 0; i < vetor.Length; i++)
            {
                EscritaEventHandler d1 = new EscritaEventHandler(OnEscreveu);
                vetor[i] = new ArrayItem
                {
                    Indice = i
                };
                //Escreveu += new EscritaEventHandler(ContaEscrita)

                vetor[i].Escreveu += d1;
                vetor[i].Valor = m_array[i];

            }
            Popular();
            label6.Refresh();

            ArrayItem? zzz = vetor.Max();
        }
    }
}