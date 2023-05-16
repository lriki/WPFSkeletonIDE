using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.DocumentPanes
{
    public class EventEditorPaneViewModel : DocumentPaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "EventEditor"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return GetHashCode().ToString(); }
        }
        #endregion
    }
}
