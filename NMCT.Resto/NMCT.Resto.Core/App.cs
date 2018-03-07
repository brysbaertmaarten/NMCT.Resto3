using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMCT.Resto.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
               .EndingWith("Repository")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.RestoTabsViewModel>();
        }
    }
}
