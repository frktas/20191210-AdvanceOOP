using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MultipleGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyClass<string, int, decimal> myClass = new MyClass<string, int, decimal>();
            myClass.TProperty = "string veri";
            myClass.UProperty = 5;
            myClass.KProperty = 5.3m;
        }
    }
}
