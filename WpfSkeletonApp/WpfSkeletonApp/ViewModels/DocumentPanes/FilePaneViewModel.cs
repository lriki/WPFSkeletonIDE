using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.DocumentPanes
{
    public class FilePaneViewModel : DocumentPaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "File"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "FilePaneViewModel"; }
        }
        #endregion
    }
}
