using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.AnchorablePanes
{
    public class AssetsPaneViewModel : AnchorablePaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "Assets"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "AssetsPaneViewModel"; }
        }
        #endregion
    }
}
