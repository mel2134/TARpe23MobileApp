﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ViewModels
{
    [INotifyPropertyChanged]
    internal partial class CalculatorPageViewModel
    {
        [ObservableProperty]
        private string inputText = "";

        [ObservableProperty]
        private string calculatedResult = "0";

        private bool isSciOpWaiting = false;

        [RelayCommand]
        private void Reset()
        {
            CalculatedResult = "0";
            InputText = "";
            isSciOpWaiting = false;
        }

        [RelayCommand]
        private void Calculate()
        {
            if (inputText.Length == 0)
            {
                return;
            }       
            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }
            try
            {
                var inputString = NormalizeInputString();
                var expression = new NCalc.Expression(inputString);
                var result = expression.Evaluate();

                CalculatedResult = result.ToString();
            }
            catch (Exception ex) { }
        }

        private string NormalizeInputString()
        {
            Dictionary<string, string> ops = new()
            {
                {"×","*"},
                {"÷","/"},
                {"SIN","Sin"},
                {"COS","Cos"},
                {"TAN","Tan"},
                {"ASIN","Asin"},
                {"ACOS","Acos"},
                {"ATAN","Atan"},
                {"LOG","Log"},
                {"EXP","Exp"},
                {"LOG10","Log10"},
                {"POW","Pow"},
                {"SQRT","Sqrt"},
                {"ABS","Abs"},
            };
            var retString = InputText;
            foreach (var op in ops.Keys)
            {
                retString = retString.Replace(op, ops[op]);
            }
            return retString;
        }
        [RelayCommand]
        private void BackSpace()
        {
            if(InputText.Length > 0)
            {
                InputText = InputText.Substring(0,InputText.Length - 1);
            }
        }
        [RelayCommand]
        private void NumberInput(string key)
        {
            InputText += key;
        }
        [RelayCommand]
        private void MathOperator(string op) {
            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }
            InputText += $" {op} ";
        }
        [RelayCommand]
        private void RegionOperator(string op)
        {
            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }
            InputText += $" {op} ";
        }
        [RelayCommand]
        private void ScientificOperator(string op) {
            InputText += $"{op}(";
            isSciOpWaiting = true;
        }
    }
}
