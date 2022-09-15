using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.ViewModels;
using WpfDemo;
using System.Windows;
using Caliburn.Micro;


namespace WpfDemo
{
    public class Bootstrapper: BootstrapperBase
    {
        public  Bootstrapper()
        {
            Initialize();

        }
         protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShallViewModel>();
        }

    }
}
