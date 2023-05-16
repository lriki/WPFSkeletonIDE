using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.AnchorablePanes
{
    public class ExplorerPaneViewModel : AnchorablePaneViewModelBase
    {
        private readonly MainWindowViewModel _mainWindow;

        #region Title Property
        public override string Title
        {
            get { return "Explorer"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "ExplorerPaneViewModel"; }
        }
        #endregion

        public ExplorerPaneViewModel(MainWindowViewModel mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public void SubmitItem()
        {
            _mainWindow.OpenFile();
        }
    }
}
