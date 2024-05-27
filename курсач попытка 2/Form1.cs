using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private string input = "";
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            input += button.Text;
            textBox1.Text = input;
        }

        private void LogResult(string result)
        {
            string filePath = "CalculationLog.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(result);
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                var result = handler.ConvertToRPN(input);
                textBox1.Text = result.ToString();
                input = result.ToString();
                LogResult(result.ToString());
            }
            catch (Exception)
            {
                input = "";
                textBox1.Text = "Помилка";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input = "";
            textBox1.Text = "0";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
                textBox1.Text = input;
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Pow(num, 2).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Sqrt(num).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonCbrt_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Pow(num, 1.0 / 3.0).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Log(num).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Log10(num).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                int num = Convert.ToInt32(input);
                input = Factorial(num).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private double Factorial(int n)
        {
            if (n < 0)
            {
                MessageBox.Show("Число не може бути від'ємним.");
                return 0;
            }
            else if (n > 50)
            {
                MessageBox.Show("Число є більшим за 50.");
                return 0;
            }
            else return n == 0 ? 1 : n * Factorial(n - 1);
        }

        private void buttonAbs_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double num = Convert.ToDouble(input);
                input = Math.Abs(num).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            input = Math.E.ToString();
            if (textBox1.Text != null) textBox1.Text += input;
            else textBox1.Text = input;
            LogResult(input);
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            input = Math.PI.ToString();
            if (textBox1.Text != null) textBox1.Text += input;
            else textBox1.Text = input;
            LogResult(input);
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double baseNum = Convert.ToDouble(input);
                double exponent = Convert.ToDouble(Prompt.ShowDialog("Введіть степінь числа:", "Степінь"));
                input = Math.Pow(baseNum, exponent).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonPower2_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double exponent = Convert.ToDouble(Prompt.ShowDialog("Введіть степінь числа:", "Степінь числа 2"));
                input = Math.Pow(2, exponent).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonPower10_Click(object sender, EventArgs e)
        {
            var handler = new CalculatorButtonsHandler();
            try
            {
                double exponent = Convert.ToDouble(Prompt.ShowDialog("Введіть степінь числа:", "Степінь числа 10"));
                input = Math.Pow(10, exponent).ToString();
                textBox1.Text = input;
                LogResult(input);
            }
            catch (Exception)
            {
                textBox1.Text = "Помилка";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Для виконання простих операцій натисніть почергово кнопки з цифрами для введення першого числа, далі - символ арифметичної операції, далі - таким же чином введіть друге число і натисніть кнопку \"=\".\n\n" +
                "Для проведення операцій з факторіалами, логарифмами, коренями, степенями, модулями спочатку введіть число, потім натисніть на відповідну кнопку - якщо число одне, результат одразу виведеться на екран.\n\n" +
                "Для операцій з тригонометричними функціями спершу натисніть на кнопку з відповідною функцією (sin, cos, tan), потім введіть значення кута в градусах і натисніть \"=\".\n\n" +
                "Для очищення поля вводу натисніть кнопку С.");
        }
    }
}
