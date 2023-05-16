using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.AnchorablePanes
{
    public class PropertiesPaneViewModel : AnchorablePaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "Properties"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "PropertiesPaneViewModel"; }
        }
        #endregion
    }
}
