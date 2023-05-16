using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.DocumentPanes
{
    public class ProjectSettingPaneViewModel : DocumentPaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "ProjectSetting"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "ProjectSettingPaneViewModel"; }
        }
        #endregion
    }
}
