using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels
{
    internal class MainWindowViewModel : Conductor<object>
    {
        private readonly IWindowManager _windowManager;

        /// <summary>
        /// ドッキングドキュメントの ViewModel のリスト
        /// </summary>
        public ObservableCollection<DocumentPanes.DocumentPaneViewModelBase> DocumentPaneViewModels { get; private set; }

        /// <summary>
        /// ドッキングペインの ViewModel のリスト
        /// </summary>
        public ObservableCollection<AnchorablePanes.AnchorablePaneViewModelBase> AnchorablePaneViewModels { get; private set; }
        
        public DocumentPanes.FilePaneViewModel FilePane { get; private set; }
        public AnchorablePanes.OutputPaneViewModel OutputPane { get; }
        

        public MainWindowViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;

            FilePane = new();
            OutputPane = new();
            
            DocumentPaneViewModels = new()
            {
                FilePane,
            };
            AnchorablePaneViewModels = new()
            {
                OutputPane,
            };
        }

        public bool CanFileMenu
        {
            get
            {
                return false;
            }
        }
        //protected async override void OnViewLoaded(object view)
        //{
        //    base.OnViewLoaded(view);
        //    await EditCategories();
        //}

        //public Task EditCategories()
        //{
        //    var viewmodel = IoC.Get<CategoryViewModel>();
        //    return ActivateItemAsync(viewmodel, new CancellationToken());
        //}

        //public Task About()
        //{
        //    return _windowManager.ShowDialogAsync(IoC.Get<AboutViewModel>());
        //}
    }
}
