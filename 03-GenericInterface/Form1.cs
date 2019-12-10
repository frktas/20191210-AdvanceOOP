using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_GenericInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringAdd stringAdd = new StringAdd();
            MessageBox.Show(stringAdd.Add("Hello", "World!"));

            IntAdd intAdd = new IntAdd();
            MessageBox.Show(intAdd.Add(1,5).ToString());
        }
    }
}
