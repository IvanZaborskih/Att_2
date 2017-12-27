using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _7._1._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (input.Text.Trim().Length == 0)
            {
                Result("Массив не введен!");
                return;
            }
            int[] array = { };
            try
            {
                array = new StringUtility().StrToArray<int>(input.Text);
            }
            catch
            {
                Result("На вход принимаются только целые числа!");
                return;
            }
            WorkWithArrays Array = new WorkWithArrays(array);
            int answer = Array.IsMix();
            Result(answer.ToString());
        }

        private void Result(string text)
        {
            result.Show();
            result.Text = text;
        }      
    }
}
