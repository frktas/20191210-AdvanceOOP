using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStringData_Click(object sender, EventArgs e)
        {
            string source = "www.furkantas.com";
            //..
            string data = "Furkan TAS datası";
            Result<string> result = new Result<string>();
            result.Data = data;
            result.IsSuccess = true;
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Data);
            }
            else
            {
                MessageBox.Show("Kaynağa erişilemedi");
            }
        }

        private void btnDecimalData_Click(object sender, EventArgs e)
        {
            string source = "www.furkantas.com";
            //..
            decimal data = 3.56m;
            Result<decimal> result = new Result<decimal>();
            result.Data = data;
            result.IsSuccess = true;
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Data.ToString());
            }
            else
            {
                MessageBox.Show("Kaynağa erişilemedi");
            }
        }
    }
}
