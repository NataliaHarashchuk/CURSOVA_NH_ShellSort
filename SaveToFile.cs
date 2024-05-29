using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CURSOVA_NH
{
    internal class SaveToFile
    {
        public static void SaveArrayToFile(int[] array, int comparisonCount, int swapCount, Label saveMessageLabel)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = $"CURSOVA_NH_output_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string filePath = Path.Combine(currentDirectory, fileName);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Масив:");
                    foreach (int element in array)
                    {
                        writer.WriteLine(element);
                    }

                    writer.WriteLine();
                    writer.WriteLine($"Кількість порівнянь: {comparisonCount}");
                    writer.WriteLine($"Кількість переміщень: {swapCount}");
                }

                saveMessageLabel.Text = $"Результат збережено за адресою: {filePath}";
            }
            catch (Exception ex)
            {
                saveMessageLabel.Text = $"Сталася помилка при збереженні файлу: {ex.Message}";
            }
        }
    }
}
