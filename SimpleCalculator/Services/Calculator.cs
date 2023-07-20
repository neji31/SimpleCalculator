using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public class Calculator
    {
        public static string Somme(string texta, string textb)
        {
            double a = double.Parse(texta);
            double b = double.Parse(textb);
            return (a + b).ToString();
        }
        public static string Soustraction(string texta, string textb)
        {
            double a = double.Parse(texta);
            double b = double.Parse(textb);
            return (a - b).ToString();
        }
    }
}
