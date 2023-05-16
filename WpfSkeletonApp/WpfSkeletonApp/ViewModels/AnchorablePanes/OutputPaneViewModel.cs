using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.AnchorablePanes
{
    public class OutputPaneViewModel : AnchorablePaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "Output"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "OutputPaneViewModel"; }
        }
        #endregion
    }
}
