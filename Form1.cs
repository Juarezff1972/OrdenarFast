using System.Windows.Forms;
using System.Linq;

namespace OrdenarFast
{
    public delegate void EscritaEventHandler(object sender,  EventArgs e);
    public delegate void PopularEventHandler(object sender, EventArgs e);

    public partial class Form1 : Form
    {
        private int escritas;
        private int[]? m_array;
        private byte ordem;
        private ArrayItem[]? vetor;

        public Form1()
        {
            InitializeComponent();
            ordem = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Resetar();

            comboBox1.SelectedIndex = 0;
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
                case "InsertSort":
                    algo.InsertSort();
                    break;

                case "SelectionSort":
                    algo.SelectionSort();
                    break;

                case "InsertSort2":
                    algo.InsertSort2();
                    break;

                case "BinaryInsertionSort":
                    algo.BinaryInsertionSort();
                    break;

                case "MergeSort":
                    algo.MergeSort();
                    break;

                case "BubbleSort":
                    algo.BubbleSort();
                    break;

                case "BubbleSort2":
                    algo.BubbleSort2();
                    break;

                case "BubbleSort3":
                    algo.BubbleSort3();
                    break;

                case "CocktailShakerSort":
                    algo.CocktailShakerSort();
                    break;

                case "GnomeSort":
                    algo.GnomeSort();
                    break;

                case "CombSort":
                    algo.CombSort();
                    break;

                case "OddEvenSort":
                    algo.OddEvenSort();
                    break;

                case "ShellSort":
                    algo.ShellSort();
                    break;

                case "QuickSortLR":
                    algo.QuickSortLR();
                    break;

                case "QuickSortLL":
                    algo.QuickSortLL();
                    break;

                case "QuickSortTernaryLR":
                    algo.QuickSortTernaryLR();
                    break;

                case "QuickSortDualPivot":
                    algo.QuickSortDualPivot();
                    break;

                case "HeapSort":
                    algo.HeapSort();
                    break;

                case "RadixSortMSD":
                    algo.RadixSortMSD();
                    break;

                case "RadixSortLSD":
                    algo.RadixSortLSD();
                    break;

                case "CountingSort":
                    algo.CountingSort();
                    break;

                case "BitonicSort":
                    algo.BitonicSort();
                    break;

                case "SlowSort":
                    algo.SlowSort();
                    break;

                case "CycleSort":
                    algo.CycleSort();
                    break;

                case "PancakeSort":
                    algo.PancakeSort();
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
            Popular();
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