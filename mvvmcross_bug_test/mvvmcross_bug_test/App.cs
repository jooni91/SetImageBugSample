using MvvmCross.Platform.IoC;
using System.Threading.Tasks;

namespace mvvmcross_bug_test
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public async override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.FirstViewModel>();

            await System.Threading.Tasks.Task.Run(() =>
            {
                while (true)
                {
                    System.Threading.Tasks.Task.Delay(500).Wait();
                    System.GC.Collect();
                }
            }).ConfigureAwait(false);
        }
    }
}
