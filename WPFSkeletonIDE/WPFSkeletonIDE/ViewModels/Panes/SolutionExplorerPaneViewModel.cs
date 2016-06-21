using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using WPFSkeletonIDE.Models;

namespace WPFSkeletonIDE.ViewModels.Panes
{
    /// <summary>
    /// [ソリューション エクスプローラ] Pane の ViewModel
    /// </summary>
    public class SolutionExplorerPaneViewModel : PaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "ソリューション エクスプローラ"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "SolutionExplorerPaneViewModel"; }
        }
        #endregion
    }
}
