using System;
using System.Windows.Forms;
using System.Threading;

namespace ParallelSortingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Некорректный размер массива");
                return;
            }
            if (!int.TryParse(txtMin.Text, out int min) || !int.TryParse(txtMax.Text, out int max) || min > max)
            {
                MessageBox.Show("Некорректный диапазон");
                return;
            }

            var rnd = new Random();
            int[] original = new int[size];
            for (int i = 0; i < size; i++)
                original[i] = rnd.Next(min, max + 1);

            lstOriginal.Items.Clear();
            foreach (var x in original) lstOriginal.Items.Add(x);

            new Thread(() => RunSort(BubbleSort, original, lstBubble, lblBubbleStatus)).Start();
            new Thread(() => RunSort(QuickSort, original, lstQuick, lblQuickStatus)).Start();
            new Thread(() => RunSort(MergeSort, original, lstMerge, lblMergeStatus)).Start();
        }

        private void RunSort(Func<int[], SortStats> sorter, int[] data, ListBox lb, Label lbl)
        {
            var stats = sorter((int[])data.Clone());

            if (lb.InvokeRequired || lbl.InvokeRequired)
            {
                lb.Invoke((MethodInvoker)delegate
                {
                    lb.Items.Clear();
                    foreach (var x in stats.SortedArray) lb.Items.Add(x);
                    lbl.Text = $"{stats.Algorithm}\nВремя: {stats.ElapsedMs:F1} мс\nСравнений: {stats.Comparisons}\nОбменов: {stats.Swaps}";
                });
            }
        }

        class SortStats
        {
            public string Algorithm { get; set; }
            public int[] SortedArray { get; set; }
            public long Comparisons { get; set; }
            public long Swaps { get; set; }
            public double ElapsedMs { get; set; }
        }

        private SortStats BubbleSort(int[] arr)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            long comps = 0, swaps = 0;
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    comps++;
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swaps++;
                    }
                }
            }

            sw.Stop();
            return new SortStats
            {
                Algorithm = "Пузырьковая",
                SortedArray = arr,
                Comparisons = comps,
                Swaps = swaps,
                ElapsedMs = sw.Elapsed.TotalMilliseconds
            };
        }

        private SortStats QuickSort(int[] arr)
        {
            var stats = new SortStats
            {
                Algorithm = "Быстрая",
                Comparisons = 0,
                Swaps = 0
            };

            var sw = System.Diagnostics.Stopwatch.StartNew();
            QuickSortRecursive(arr, 0, arr.Length - 1, stats);
            sw.Stop();

            stats.SortedArray = arr;
            stats.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return stats;
        }

        private void QuickSortRecursive(int[] arr, int low, int high, SortStats stats)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, stats);
                QuickSortRecursive(arr, low, pi - 1, stats);
                QuickSortRecursive(arr, pi + 1, high, stats);
            }
        }

        private int Partition(int[] arr, int low, int high, SortStats stats)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                stats.Comparisons++;
                if (arr[j] <= pivot)
                {
                    i++;
                    if (i != j)
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                        stats.Swaps++;
                    }
                }
            }
            if (i + 1 != high)
            {
                (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
                stats.Swaps++;
            }
            return i + 1;
        }

        private SortStats MergeSort(int[] arr)
        {
            var stats = new SortStats
            {
                Algorithm = "Слиянием",
                Comparisons = 0,
                Swaps = 0  // в слиянии "обменов" как таковых нет, но можно считать перемещения
            };

            var sw = System.Diagnostics.Stopwatch.StartNew();
            MergeSortRecursive(arr, 0, arr.Length - 1, stats);
            sw.Stop();

            stats.SortedArray = arr;
            stats.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return stats;
        }

        private void MergeSortRecursive(int[] arr, int left, int right, SortStats stats)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortRecursive(arr, left, mid, stats);
                MergeSortRecursive(arr, mid + 1, right, stats);
                Merge(arr, left, mid, right, stats);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right, SortStats stats)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1], R = new int[n2];
            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                stats.Comparisons++;
                if (L[i] <= R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }

            while (i < n1) arr[k++] = L[i++];
            while (j < n2) arr[k++] = R[j++];
        }
    }
}