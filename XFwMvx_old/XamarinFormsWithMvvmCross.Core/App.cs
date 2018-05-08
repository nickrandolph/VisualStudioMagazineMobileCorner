using MvvmCross.ViewModels;
using System;
using XamarinFormsWithMvvmCross.Core.ViewModels;

namespace XamarinFormsWithMvvmCross.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<MainViewModel>();
        }
    }


}
