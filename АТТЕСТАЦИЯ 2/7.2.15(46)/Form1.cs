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

namespace _7._2._15_46_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs ex)
        {
            try
            {
                if (input.Text.Trim().Length == 0)
                    throw new Exception("Массив не введен!");

                int[] array = new StringUtility().StrToArray<int>(input.Text);
                WorkWithArrays arr = new WorkWithArrays(array);

                int size, index;
                arr.SizeAndIndex(out size, out index);
                Result(index.ToString() + ", " + size.ToString());
            }
            catch (FormatException e)
            {
                Result("На вход принимаются только целые числа!");
                return;
            }
            catch (Exception e)
            {
                Result(e.Message);
                return;
            }
        }

        private void Result(string text)
        {
            output.Show();
            output.Text = text;
        }     
    }
}
