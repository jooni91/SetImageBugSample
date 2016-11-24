using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace mvvmcross_bug_test.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private MvxCommand navigateSecondPage;
        public ICommand NavigateSecondPage
        { 
            get
            {
                navigateSecondPage = navigateSecondPage ??
                    new MvxCommand(() => Navigate());
                return navigateSecondPage;
            }
        }

        private void Navigate()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
