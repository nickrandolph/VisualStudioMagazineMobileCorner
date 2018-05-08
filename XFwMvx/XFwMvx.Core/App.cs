using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using XFwMvx.Core.ViewModels;

namespace XFwMvx.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }

}
