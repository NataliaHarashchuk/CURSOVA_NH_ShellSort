using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURSOVA_NH
{
    public partial class MainForm : Form
    {
        private int generateOrder = 0;
        private int sortOrder = 0;
        private int sortSequence = 0;
        private int MaxArrayLengthForVisualization = 200;

        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButtonGeneratorAscending_CheckedChanged(object sender, EventArgs e)
        {
            generateOrder = 0;
        }
        private void radioButtonGeneratorDescending_CheckedChanged(object sender, EventArgs e)
        {
            generateOrder = 1;
        }
        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            generateOrder = 2;
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            int numOfElements;
            int lowerBound;
            int UpperBound;
            

            if (!int.TryParse(textBoxGenerateNumOfElem.Text, out numOfElements))
            {
                GenerateParamError.Text = $"Помилка в кількості елементів: Введено нецілочисельні дані. Або число не належить проміжку від {int.MinValue} до {int.MaxValue}";
                return;
            }
            if (!int.TryParse(textBoxGenerateLowerBound.Text, out lowerBound))
            {
                GenerateParamError.Text = $"Помилка в нижній границі діапазону: Введено нецілочисельні дані. Або число не належить проміжку від {int.MinValue} до {int.MaxValue}";
                return;
            }
            if (!int.TryParse(textBoxGenerateUpperBound.Text, out UpperBound))
            {
                GenerateParamError.Text = $"Помилка в верхній границі діапазону: Введено нецілочисельні дані. Або число не належить проміжку від {int.MinValue} до {int.MaxValue}";
                return;
            }

            GenerateParamError.Text = "";

            int[] array = InputFunctions.GenerateArray(numOfElements, lowerBound, UpperBound, generateOrder, GenerateParamError);
            if (array != null)
            {
                textBoxArray.Text = string.Join(" ", array);
            }

        }
        private void radioButtonSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            sortOrder = 0;
        }
        private void radioButtonSortDesc_CheckedChanged(object sender, EventArgs e)
        {
            sortOrder = 1;
        }
        private void radioButtonSortClassic_CheckedChanged(object sender, EventArgs e)
        {
            sortSequence = 0;
        }
        private void radioButtonSortSedgwick_CheckedChanged(object sender, EventArgs e)
        {
            sortSequence = 1;
        }
        private void radioButtonDortFibonacci_CheckedChanged(object sender, EventArgs e)
        {
            sortSequence = 2;
        }
        private void radioButtonSortTokuda_CheckedChanged(object sender, EventArgs e)
        {
            sortSequence = 3;
        }
        private void ButtonStartSort_Click(object sender, EventArgs e)
        {
            int[] array = InputFunctions.ManualInput(textBoxArray, InputError);
            if (array == null)
            {
                return;
            }

            int[] unsortedArrayForVisualizer = (int[])array.Clone();

            Sort sort = new Sort();
            sort.ShellSort(array, sortOrder, sortSequence);
            textBoxArray.Text = string.Join(" ", array);

            int comparisons = sort.ComparisonsCount;
            int swaps = sort.SwapsCount;

            labelComarisons.Text = $"{comparisons}";
            labelSwaps.Text = $"{swaps}";

            if (array.Length <= MaxArrayLengthForVisualization)
            {
                SortingVisualizer sortingVisualizer = new SortingVisualizer(unsortedArrayForVisualizer,sortOrder, sortSequence);
                sortingVisualizer.Show();
            }

            SaveToFile.SaveArrayToFile(array,comparisons,swaps, SaveMessageLabel);
        }
    }
}
