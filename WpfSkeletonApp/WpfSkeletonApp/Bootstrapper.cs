using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfSkeletonApp.ViewModels;

namespace WpfSkeletonApp
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
            StartDebugLogger();
        }

        // [Conditional("DEBUG")] You can use this conditional starting with C# 9.0
        public static void StartDebugLogger()
        {
            LogManager.GetLog = type => new DebugLog(type);
        }

        protected override void Configure()
        {
            _container.Instance(_container);
            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            // Caliburn.Micro のデフォルトの命名規則では、 "View" サフィックスが必須となる。
            // つまり、 MainWindow.xaml は MainWindowView.xaml とする必要がある。
            // 次の設定によって、これを無効化している。
            ViewLocator.AddDefaultTypeMapping("");

            foreach (var assembly in SelectAssemblies())
            {
                assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
            }
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            var c = IoC.Get<SimpleContainer>();
            await DisplayRootViewForAsync(typeof(MainWindowViewModel));
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
