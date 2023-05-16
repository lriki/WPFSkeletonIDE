using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WpfSkeletonApp.ViewModels.AnchorablePanes;

namespace WpfSkeletonApp.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
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

        public AnchorablePanes.OutputPaneViewModel OutputPane { get; init; }

        public AnchorablePanes.ExplorerPaneViewModel ExplorerPane { get; init; }
        public AnchorablePanes.AssetsPaneViewModel AssetsPane { get; init; }
        public AnchorablePanes.PropertiesPaneViewModel PropertiesPane { get; init; }
        

        public MainWindowViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;

            OutputPane = new();
            ExplorerPane = new(this);
            AssetsPane = new();
            PropertiesPane = new();

            DocumentPaneViewModels = new()
            {
                new DocumentPanes.FilePaneViewModel(),
                new DocumentPanes.ProjectSettingPaneViewModel(),
            };
            AnchorablePaneViewModels = new()
            {
                OutputPane,
                ExplorerPane,
                AssetsPane,
                PropertiesPane,
            };
        }

        public bool CanFileMenu
        {
            get
            {
                return false;
            }
        }

        public void OpenFile()
        {
            DocumentPaneViewModels.Add(new DocumentPanes.FilePaneViewModel() { IsActive = true });
        }

        public void OpenMapEditor()
        {
            DocumentPaneViewModels.Add(new DocumentPanes.MapEditorPaneViewModel());
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
