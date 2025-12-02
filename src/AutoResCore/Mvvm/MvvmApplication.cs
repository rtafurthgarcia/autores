using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResCore.Mvvm
{
    // Application with DI 
    // make sure our app has global DI enabled
    // Source is https://doi.org/10.1007/978-1-4842-8248-9 [p.215]
    public abstract class MvvmApplication: Application
    {
        public MvvmApplication(): base() {
            Current = this;

            Container = ConfigureDependencyInjection();
        }

        public static new MvvmApplication Current { get; private set; }

        public IServiceProvider Container { get; }

        IServiceProvider ConfigureDependencyInjection()
        {
            ServiceCollection services = new(); 
            ConfigureServices(services);
            return services.BuildServiceProvider();
        }

        protected abstract void ConfigureServices(IServiceCollection services);
    }
}
