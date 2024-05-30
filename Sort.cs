using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOVA_NH
{
    internal class Sort
    {
        public int ComparisonsCount { get; private set; } = 0;
        public int SwapsCount { get; private set; } = 0;
        private static List<int> ShellGaps(int len)
        {
            List<int> gaps = new List<int>();
            int gap = len / 2;
            while (gap > 0)
            {
                gaps.Add(gap);
                gap = gap / 2;
            }
            return gaps;
        }
        private static List<int> SedgwickGaps(int len)
        {
            List<int> gaps = new List<int>() { 1 };
            int i = 0;
            int gap = 0;
            while (gap < len)
            {
                i++;
                gap = (int)(Math.Pow(4, i) + 3 * Math.Pow(2, i - 1) + 1);
                gaps.Add(gap);
            }
            gaps.Reverse();
            return gaps;
        }
        private static List<int> FibonacciGaps(int len)
        {
            List<int> gaps = new List<int>();
            int i = 1, j = 1;
            while (j < len)
            {
                gaps.Add(j);
                int temp = i + j;
                i = j;
                j = temp;
            }
            gaps.Reverse();
            return gaps;
        }
        private static List<int> TokudaGaps(int len)
        {
            List<int> gaps = new List<int>() { 1 };
            int i = 0;
            int gap = 0;
            while (gap < len)
            {
                i++;
                gap = (int)Math.Ceiling((9 * Math.Pow(9.0 / 4, i) - 4) * 1 / 5);
                gaps.Add(gap);
            }
            gaps.Reverse();
            return gaps;
        }
        private bool AscendingComparison(int a, int b)
        {
            return a > b;
        }
        private bool DescendingComparison(int a, int b)
        {
            return a < b;
        }
        public void ShellSort(int[] array, int sortOrder, int sortSequence)
        {
            int len = array.Length;
            List<int> gaps = new List<int>();
            Func<int, int, bool> comparisonFunction = null;
            switch (sortOrder)
            {
                case 0:
                    comparisonFunction = AscendingComparison;
                    break;
                case 1:
                    comparisonFunction = DescendingComparison;
                    break;
                default:
                    throw new ArgumentException("Unknown sortOrder value");
            }
            switch (sortSequence)
            {
                case 0:
                    gaps = ShellGaps(len);
                    break;
                case 1:
                    gaps = SedgwickGaps(len);
                    break;
                case 2:
                    gaps = FibonacciGaps(len);
                    break;
                case 3:
                    gaps = TokudaGaps(len);
                    break;
                default:
                    throw new ArgumentException("Unknown sortSequence value");
            }

            foreach (int gap in gaps)
            {
                for (int i = gap; i < len; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap)
                    {
                        ComparisonsCount++;
                        if (comparisonFunction(array[j - gap], temp))
                        {
                            SwapsCount++;
                            array[j] = array[j - gap];
                        }
                        else { break; }
                        j -= gap;

                    }
                    array[j] = temp;
                }

            }

        }

        private readonly Brush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        private readonly Brush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public async void Animate(int[] array, Graphics graph, int maxHeight, int sortOrder, int sortSequence, int zeroLine, float rectWidth, int rectangleGap)
        {
            int len = array.Length;
            List<int> gaps = new List<int>();
            Func<int, int, bool> comparisonFunction = null;

            int MaxInArray = array.Max();

            switch (sortOrder)
            {
                case 0:
                    comparisonFunction = AscendingComparison;
                    break;
                case 1:
                    comparisonFunction = DescendingComparison;
                    break;
                default:
                    throw new ArgumentException("Unknown sortOrder value");
            }
            switch (sortSequence)
            {
                case 0:
                    gaps = ShellGaps(len);
                    break;
                case 1:
                    gaps = SedgwickGaps(len);
                    break;
                case 2:
                    gaps = FibonacciGaps(len);
                    break;
                case 3:
                    gaps = TokudaGaps(len);
                    break;
                default:
                    throw new ArgumentException("Unknown sortSequence value");
            }

            await Task.Delay(1000);
            foreach (int gap in gaps)
            {
                for (int i = gap; i < len; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && comparisonFunction(array[j - gap], temp))
                    {
                        DrawRectangle(graph, j, array[j], maxHeight, zeroLine, rectWidth, rectangleGap, blackBrush, MaxInArray);
                        array[j] = array[j - gap];                        
                        DrawRectangle(graph, j, array[j], maxHeight, zeroLine, rectWidth, rectangleGap, whiteBrush, MaxInArray);
                        j -= gap;
                    }
                    
                    DrawRectangle(graph, j, array[j], maxHeight, zeroLine, rectWidth, rectangleGap, blackBrush, MaxInArray);
                    array[j] = temp;
                    DrawRectangle(graph, j, array[j], maxHeight, zeroLine, rectWidth, rectangleGap, whiteBrush, MaxInArray);
                    await Task.Delay(100);
                }

            }
        }
        private void DrawRectangle(Graphics g, int index, int value, int maxHeight, int zeroLine, float rectWidth, int rectangleGap, Brush brush, int MaxInArray)
        {
            float rectHeight = (float)Math.Abs(value) / MaxInArray * (maxHeight / 2 - rectangleGap);
            float rectY = value >= 0 ? zeroLine - rectHeight : zeroLine;
            g.FillRectangle(brush, index * rectWidth, rectY, rectWidth, rectHeight);
        }
    }
}
