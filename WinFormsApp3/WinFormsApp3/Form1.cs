using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public List<double> Values = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddValue(object sender, EventArgs e) // Додавання елементу в послідовність (клік на кнопку додавання)
        {
            try // Перевірка чи правильні значення ввів користувач 
            {
                var value = Convert.ToDouble(input.Text); // конвертує строку яку ввів користувач у число
                Values.Add(value); // додається значення 
                this.textMessage.Text = "Статистичний калькулятор"; // якщо є помилка, то буде інший текст, і щоб вернути на нормальний тут вертається
                this.allValues.Text = Values.Aggregate("", (current, el) => current + (el + ",")); // вивід всіх значень які є в послідовності
                this.input.Text = ""; // Очищає строку де користувач ввід число
            } 
            catch(Exception ex) // Відловлює помилку, якщо щось неправильно введене
            {
                this.textMessage.Text = "Input correct value!"; // Виводить цей текст, якщо користувач ввів неправильне число
                this.input.Text = "";
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (this.Values.Any()) // Ящко послідовність не пуста, то обчислює 
            {
                this.Average.Text = CalculateAverage(this.Values).ToString(); // середнє арифм
                this.Median.Text = CalculateMedian(this.Values).ToString(); // медіану
                this.Min.Text = this.Values.Min().ToString(); // мінімальне
                this.Max.Text = this.Values.Max().ToString(); // максимальне
                this.HarmonicMean.Text = CalculateHarmonicMean(this.Values).ToString(); // гармонічне
                this.GeometricMean.Text = CalculateGeometricMean(this.Values).ToString(); // геометричне
                this.Range.Text = CalculateRange(this.Values).ToString(); // діапазон
            }
            else
            {
                this.textMessage.Text = "Input value!"; // якщо послідовність пуска, то нема з яких чисел обчилсяти, просить користувача ввести числа
            }
        }

        private static double CalculateAverage(List<double> arr) // Обчислення середнього арифм
        {
            var sum = arr.Sum();
            var average = sum / arr.Count();

            return average;
        }

        private static double CalculateMedian(List<double> arr) // рахуєм медіану
        {
            var index = arr.Count / 2;

            return arr[index];
        }

        private static double CalculateRange(List<double> arr) // рахуєм діапазон
        {
            var max = arr.Max();
            var min = arr.Min();

            return max - min;
        }

        private static double CalculateGeometricMean(List<double> arr) // рахуєм середнє геометричне
        {
            var multiplication = Convert.ToDouble(arr.Aggregate((x, y) => x * y));
            var power = 1 / Convert.ToDouble(arr.Count);
            var geometricMean = Math.Pow(multiplication, power);

            return geometricMean;
        }

        private static double CalculateHarmonicMean(List<double> arr) // рахкєм середнє геометричне
        {
            var sum = arr.Aggregate((x, y) => 1 / x + 1 / y);
            var harmonicMean = arr.Count / sum;

            return harmonicMean;
        }
    }
}
