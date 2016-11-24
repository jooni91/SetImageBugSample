using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvmcross_bug_test.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private string iconPath = "res:icon";
        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; RaisePropertyChanged(() => IconPath); }
        }

        private MvxCommand navigateBack;
        public ICommand NavigateBack
        {
            get
            {
                navigateBack = navigateBack ??
                    new MvxCommand(() => Back());
                return navigateBack;
            }
        }

        private void Back()
        {
            Close(this);
        }
    }
}
