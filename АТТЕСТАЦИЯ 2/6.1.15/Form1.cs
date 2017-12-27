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

namespace _6._1._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {            
            string str = InputS.Text;
            int k = int.Parse(InputK.Text);
            WorkWithStr workWithStr = new WorkWithStr(str);
            result.Text = workWithStr.WordN(k);       
        }
    }
}
