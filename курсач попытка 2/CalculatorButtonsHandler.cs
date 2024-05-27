using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calculator
{
    internal class CalculatorButtonsHandler
    {
        private string historyFilePath = "calculation_history.txt";

        private string ParseFunctions(string formula)
        {
            Dictionary<string, Func<double, double>> functions = new Dictionary<string, Func<double, double>>()
            {
                { "sin", Math.Sin },
                { "cos", Math.Cos },
                { "tan", Math.Tan },
                { "sqrt", Math.Sqrt },
                { "cbrt", x => Math.Pow(x, 1.0 / 3.0) },
                { "ln", Math.Log },
                { "abs", Math.Abs },
                { "pi", x => Math.PI },
                { "e", x => Math.E }
            };

            foreach (var function in functions)
            {
                while (formula.Contains(function.Key))
                {
                    int startIndex = formula.IndexOf(function.Key);
                    int endIndex = startIndex + function.Key.Length;

                    while (endIndex < formula.Length && (char.IsDigit(formula[endIndex]) || formula[endIndex] == ',' || formula[endIndex] == '-' || formula[endIndex] == '.'))
                    {
                        endIndex++;
                    }

                    string funcCall = formula.Substring(startIndex, endIndex - startIndex);
                    string numberStr = funcCall.Substring(function.Key.Length);
                    double number = string.IsNullOrEmpty(numberStr) ? 0 : Convert.ToDouble(numberStr, CultureInfo.InvariantCulture);

                    if (function.Key == "sin" || function.Key == "cos" || function.Key == "tan")
                    {
                        number = number * Math.PI / 180.0;
                    }

                    double result = function.Value(number);
                    formula = formula.Replace(funcCall, result.ToString(CultureInfo.InvariantCulture));
                }
            }

            return formula;
        }

        private List<string> Tokenize(string formula)
        {
            var tokens = new List<string>();
            var operand = "";
            foreach (var charx in formula)
            {
                if (char.IsDigit(charx) || charx == ',' || charx == '.')
                {
                    operand += charx;
                }
                else
                {
                    if (operand != "")
                    {
                        tokens.Add(operand);
                        operand = "";
                    }
                    if (!char.IsWhiteSpace(charx))
                    {
                        tokens.Add(charx.ToString());
                    }
                }
            }

            if (operand != "")
            {
                tokens.Add(operand);
            }
            return tokens;
        }

        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "×" || token == "/";
        }

        private bool IsFunction(string token)
        {
            return token == "sin" || token == "cos" || token == "tan" || token == "sqrt" || token == "cbrt" || token == "ln" || token == "abs" || token == "pi" || token == "e";
        }

        private int OperationPriority(string operation)
        {
            switch (operation)
            {
                case "+":
                case "-":
                    return 1;
                case "×":
                case "/":
                    return 2;
                case "sin":
                case "cos":
                case "tan":
                case "sqrt":
                case "cbrt":
                case "ln":
                case "abs":
                case "pi":
                case "e":
                    return 3;
                case "^":
                case "2^":
                case "10^":
                    return 4;
                default: return 0;
            }
        }

        private double CalculatePriorityOneAndTwo(double operand1, double operand2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "×":
                    return operand1 * operand2;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Ділення на нуль неможливе.");
                        return 0;
                    }
                    else return operand1 / operand2;
                default: MessageBox.Show("Сталася помилка."); return 0;
            }
        }

        private double CalculatePriorityThree(double operand, string funcx)
        {
            switch (funcx)
            {
                case "sin":
                    return Math.Sin(operand);
                case "cos":
                    return Math.Cos(operand);
                case "tan":
                    return Math.Tan(operand);
                case "sqrt":
                    return Math.Sqrt(operand);
                case "cbrt":
                    return Math.Pow(operand, 1.0 / 3.0);
                case "ln":
                    return Math.Log(operand);
                case "abs":
                    return Math.Abs(operand);
                case "pi":
                    return Math.PI;
                case "e":
                    return Math.E;
                default: MessageBox.Show("Сталася помилка."); return 0;
            }
        }

        private double CalculatePriorityFour(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        public double ConvertToRPN(string formula)
        {
            formula = ParseFunctions(formula);
            var queueOutput = new Queue<string>();
            var operatorStack = new Stack<string>();
            var tokens = Tokenize(formula);

            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    queueOutput.Enqueue(token);
                }
                else if (IsOperator(token) || IsFunction(token) || token == "^" || token == "2^" || token == "10^")
                {
                    while (operatorStack.Count > 0 && (IsOperator(operatorStack.Peek()) || IsFunction(operatorStack.Peek()) || operatorStack.Peek() == "^" || operatorStack.Peek() == "2^" || operatorStack.Peek() == "10^") &&
                           OperationPriority(token) <= OperationPriority(operatorStack.Peek()))
                    {
                        queueOutput.Enqueue(operatorStack.Pop());
                    }
                    operatorStack.Push(token);
                }
                else if (token == "(")
                {
                    operatorStack.Push(token);
                }
                else if (token == ")")
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                    {
                        queueOutput.Enqueue(operatorStack.Pop());
                    }
                    operatorStack.Pop();
                }
            }

            while (operatorStack.Count > 0)
            {
                queueOutput.Enqueue(operatorStack.Pop());
            }

            var evaluationStack = new Stack<double>();

            while (queueOutput.Count > 0)
            {
                var value = queueOutput.Dequeue();

                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    evaluationStack.Push(number);
                }
                else if (IsOperator(value))
                {
                    var operand2 = evaluationStack.Pop();
                    var operand1 = evaluationStack.Pop();
                    var result = CalculatePriorityOneAndTwo(operand1, operand2, value);
                    evaluationStack.Push(result);
                }
                else if (IsFunction(value))
                {
                    var operand = evaluationStack.Pop();
                    var result = CalculatePriorityThree(operand, value);
                    evaluationStack.Push(result);
                }
                else if (value == "^")
                {
                    var exponent = evaluationStack.Pop();
                    var baseNum = evaluationStack.Pop();
                    var result = CalculatePriorityFour(baseNum, exponent);
                    evaluationStack.Push(result);
                }
                else if (value == "2^")
                {
                    var exponent = evaluationStack.Pop();
                    var result = CalculatePriorityFour(2, exponent);
                    evaluationStack.Push(result);
                }
                else if (value == "10^")
                {
                    var exponent = evaluationStack.Pop();
                    var result = CalculatePriorityFour(10, exponent);
                    evaluationStack.Push(result);
                }
            }

            var finalResult = evaluationStack.Pop();
            SaveToHistory(formula, finalResult);
            return finalResult;
        }

        private void SaveToHistory(string formula, double result)
        {
            using (StreamWriter writer = new StreamWriter(historyFilePath, true))
            {
                writer.WriteLine($"{formula} = {result}");
            }
        }

        public string GetCalculationHistory()
        {
            if (File.Exists(historyFilePath))
            {
                return File.ReadAllText(historyFilePath);
            }
            return "No history available.";
        }
    }
}
