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
    /// [プロパティ] Pane の ViewModel
    /// </summary>
    public class PropertyPaneViewModel : PaneViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "プロパティ"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "PropertyPaneViewModel"; }
        }
        #endregion
    }
}
