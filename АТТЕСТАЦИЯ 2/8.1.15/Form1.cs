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

namespace _8._1._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> newlist = new List<int>();
            newlist = Lists.StrToList(inputList.Text);
            Lists lists = new Lists(newlist);
            newlist = lists.CreateNewList(int.Parse(inputN.Text));
            result.Text = Lists.ListToStr(newlist);
        }
    }
}
