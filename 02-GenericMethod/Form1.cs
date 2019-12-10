using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_GenericMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void EnBuyuk<T> (T param1,T param2)
        {
            if (param1.ToString().CompareTo(param2.ToString()) == 1)
            {
                MessageBox.Show(param1.ToString());
            }
            else
            {
                MessageBox.Show(param2.ToString());
            }
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //string value = txtValue.Text;
            //string value2 = txtValue2.Text;

            //EnBuyuk<string>(value, value2);

            int value = int.Parse(txtValue.Text);
            int value2 = int.Parse(txtValue2.Text);

            EnBuyuk<int>(value, value2);
             

        }
    }
}
