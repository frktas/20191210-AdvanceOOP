using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_GenericConstraints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConstraintClass<ILoveInterface> constraintClass = new ConstraintClass<ILoveInterface>();
            
            ConstraintClass<Hebele> constraintClass = new ConstraintClass<Hebele>();
        }
    }
}
