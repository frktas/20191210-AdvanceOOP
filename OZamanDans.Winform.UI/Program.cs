using Ninject;
using OZamanDans.BLL.Abstract;
using OZamanDans.BLL.IoC.Ninject;
using OZamanDans.Winform.UI.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZamanDans.Winform.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //note Ninject çalışabilsin diye var 
            CustomServiceModule module = new CustomServiceModule();
            IKernel kernel = new StandardKernel(module);
            kernel.Load<CustomDALModule>();

            IProductService productService = kernel.Get<IProductService>();
            ICategoryService categoryService = kernel.Get<ICategoryService>();

            Application.Run(new Form1(categoryService,productService));
        }
    }
}
