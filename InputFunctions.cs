using System;
using System.Windows.Forms;

namespace CURSOVA_NH
{
    internal class InputFunctions
    {
        private const int MaxArraySize = 50000;
        private const int MinArraySize = 1;
        private const int MinValue = int.MinValue;
        private const int MaxValue=int.MaxValue;
        public static int[] ManualInput(TextBox textBox, Label InputError)
        {
            string input = textBox.Text;
            int[] array;
            if (string.IsNullOrWhiteSpace(input))
            {
                InputError.Text = "Помилка: Введено порожній масив";
                return null;
            }
            try
            {
                array = Array.ConvertAll(input.Split(new[] { ' ', ',', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            }
            catch (FormatException)
            {
                InputError.Text = "Помилка: Введено нецілочисельні дані";
                return null;
            }
            if (array.Length > MaxArraySize)
            {
                InputError.Text = "Помилка: Масив не може містити більше 50000 елементів";
                return null;
            }
            InputError.Text = "";
            return array;
        }
        public static int[] GenerateArray(int numOfElements, int lowerBound, int upperBound, int generateOrder, Label GenerateParamError)
        {

            if (numOfElements < MinArraySize || numOfElements > MaxArraySize)
            {
                GenerateParamError.Text =  $"Помилка: Кількість елементів має бути в межах від {MinArraySize} до {MaxArraySize}";
                return null;
            }
            if (lowerBound < MinValue || upperBound > MaxValue)
            {
                GenerateParamError.Text = $"Помилка: Значення мають бути у проміжку від {MinValue} до {MaxValue}";
                return null;
            }
            if (lowerBound >= upperBound)
            {
                GenerateParamError.Text = "Помилка: Неправильно введений діапазон";
                return null;
            }
            GenerateParamError.Text = "";

            int[] array = new int[numOfElements];
            Random random = new Random();

            for (int i = 0; i < numOfElements; i++)
            {
                array[i] = random.Next(lowerBound, upperBound + 1);
            }

            switch (generateOrder)
            {
                case 0:
                    Array.Sort(array);
                    break;
                case 1:
                    Array.Sort(array);
                    Array.Reverse(array);
                    break;
                case 2:

                    break;
                default:
                    throw new ArgumentException("Unknown generateOrder value");
            }
            return array;
        }

    }
}
